using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;
//01010100 01100101 01110011 01110100 => 'T' + 'e' + 's' + 't'

namespace ProgrammingProject
{
    public class Decoding
    {
        //This method will change a string into binary (to be used with the writing to a text file)
        public static string BinaryToString(string data)
        {
            List<byte> byteList = new List<byte>();
            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }
        //This method will change binary to a string which we will use with the reading of the textfile
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in data.ToCharArray())
            {
                sb.Append(Convert.ToString(item, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        //This will return the file's values as strings
        public static string FileToString(string filename)
        {
            string messageDecrypted = "";
            Filehandler fh = new Filehandler();
            List<string> myList = new List<string>();
            myList = fh.Readfile(filename);

            foreach (string line in myList)
            {
                messageDecrypted = messageDecrypted + BinaryToString(line);
            }
            return messageDecrypted;
        }
        //This method will return the first letter of every word and check if it is a palindrome or not
        public static bool IsPalindrome(string message)
        {
            string dataToReturn = "";
            string[] stringSplit = message.Split();
            foreach (string item in stringSplit)
            {
                dataToReturn = dataToReturn + item.Substring(0, 1);
            }
            string first = dataToReturn.Substring(0, dataToReturn.Length / 2);
            char[] charArr = dataToReturn.ToCharArray();
            Array.Reverse(charArr);
            string temp = new string(charArr);
            string second = temp.Substring(0, temp.Length / 2);
            return first.Equals(second);
        }
        //Method for the cipher
        public static string Caesar(string value, int key)
        {
            char[] buffer = value.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                // Defines the letter
                char letter = buffer[i];
                // Adds shifts to all the letters
                letter = (char)(letter + key);
                if (letter > 'z')
                {
                    letter = (char)(letter - 26);
                }
                else if (letter < 'a')
                {
                    letter = (char)(letter + 26);
                }
                // Stores it
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        //Method to send email (used after the IsPalindrome when checking t/f)
        public static void SendEmail(bool isPalindrome)
        {
            if (isPalindrome)
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("testdummyprg@gmail.com");
                    mail.To.Add("anrichvanzyl99@gmail.com");
                    mail.To.Add("your mail here");
                    mail.Subject = "The Secret Message";
                    mail.Body = "This is where the decrpyted message goes";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("testdummyprg@gmail.com", "incognit0");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("The Message has been sent.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
