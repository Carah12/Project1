using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Mail;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ProgrammingProject
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }


        FileHandler fh = new FileHandler();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDecryption_Click_1(object sender, EventArgs e)
        {
            string filename = txtBrowse.Text;
            try 
	        {	        
		        
                if (filename != null)
	            {
                    string messageDecrypted = "";
                    List<string> myList = new List<string>();
                    myList = fh.Readfile(filename);
                    int shiftKey = 1;

                    foreach (string line in myList)
                    {
                        string lineToCheck = Decoding.Caesar(line,shiftKey);
                        //We check if the string is english or not...
                        if (Regex.IsMatch(lineToCheck,"^[a-zA-Z0-9]*$"))
	                    {
                            bool isSecret = Decoding.IsPalindrome(lineToCheck);
                            Decoding.SendEmail(isSecret);
                            messageDecrypted = messageDecrypted + " | " + lineToCheck;
                            shiftKey = 1;
	                    }
                        else
	                    {
                            shiftKey += shiftKey;
	                    }
                        //return messageDecrypted;
                    }
                    DBAccess dba = new DBAccess();
                    //
                    //
                    //Add the insert to database here...
                    //
                    //
	            }
	        }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                fh.WriteToFile(filename);
            }
        }

        private void Decryption_Load(object sender, EventArgs e)
        {

        }
    }
}
