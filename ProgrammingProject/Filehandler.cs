using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace binaryToTextTest
{
    class Filehandler
    {
        FileStream stream;
        StreamReader reader;
        StreamWriter writer;

        public Filehandler() { }

        public List<string> Readfile(string filename)
        {
            List<string> rawdata = new List<string>();
            stream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            reader = new StreamReader(stream);

            try
            {
                if (!reader.EndOfStream)
                {
                    rawdata.Add(reader.ReadLine());
                }
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {   
                reader.Close();
                //stream.Flush();
                stream.Close();
            }
            return rawdata;
        }
        public void WriteToFile(string filename)
        {
            string dataToWrite = DateTime.Now.ToShortDateString();
            stream = new FileStream(filename, FileMode.Open, FileAccess.Write);
            writer = new StreamWriter(stream);

            try
            {
                writer.Write(Decoding.StringToBinary(dataToWrite));
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                MessageBox.Show(dnfe.Message);
            }
            catch (IOException ioe)
            {
                MessageBox.Show(ioe.Message);
            }
            finally
            {
                writer.Close();
                //stream.Flush();
                stream.Close();
            }
        }
        
    }
}
