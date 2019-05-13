using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool login;
        bool loginAdmin;
        List<User> populateUser = new List<User>();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = new User();
            populateUser = user.PopulateUsers();

            foreach (User item in populateUser)
            {
                if (username == item.Username && password == item.Password)
                {
                    login = true;
                    if (item.IsAdmin == true)
                    {
                        loginAdmin = true;
                        break;
                    }
                    else
                    {
                        loginAdmin = false;
                        break;
                    }
                }
                else
                {
                    login = false;
                   
                }
            }

            if (login == true)
            {
                MessageBox.Show("Welcome " + username, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                if (loginAdmin == true)
                {
                    DecryptionAlteration da = new DecryptionAlteration();
                    da.Show();
                }
                else
                {
                    Decryption d = new Decryption();
                    d.Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password ", "Please try again", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
