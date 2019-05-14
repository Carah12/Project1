using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {

             string Caesar(string value, int shift)
             {
                char[] buffer = value.ToCharArray();
                for (int i = 0; i < buffer.Length; i++)
                {
                    // Defines the letter
                    char letter = buffer[i];
                    // Adds shifts to all the letters
                    letter = (char)(letter + shift);
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

            //try
            //{
            //    MailMessage mail = new MailMessage();
            //    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            //    mail.From = new MailAddress("testdummyprg@gmail.com");
            //    mail.To.Add("anrichvanzyl99@gmail.com");
            //    mail.To.Add("your mail here");
            //    mail.Subject = "Test Mail";
            //    mail.Body = "This is for testing SMTP mail from GMAIL";

            //    SmtpServer.Port = 587;
            //    SmtpServer.Credentials = new System.Net.NetworkCredential("testdummyprg@gmail.com", "incognit0");
            //    SmtpServer.EnableSsl = true;

            //    SmtpServer.Send(mail);
            //    MessageBox.Show("mail Send");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}

        }
    }
}
