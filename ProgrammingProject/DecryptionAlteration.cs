using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ProgrammingProject
{
    public partial class DecryptionAlteration : Form
    {
        public DecryptionAlteration()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        DBAccess dba = new DBAccess();
        User user = new User();

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            ArrayList arrinsert = new ArrayList();

            
        }

        private void DecryptionAlteration_Load(object sender, EventArgs e)
        {
            List<User> popUsers = new List<User>();

            popUsers = user.PopulateUsers();
            bs.DataSource = popUsers;
            dgvDisplay.DataSource = bs;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            
            User user = (User)bs.Current;
            txtAge.Text = user.Age.ToString();
            txtIDNumber.Text = user.IdNumber;
            txtName.Text = user.Name;
            txtPassword.Text = user.Password;
            txtRank.Text = user.Rank;
            txtSurname.Text = user.Surname;
            txtUsername.Text = user.Username;
            if (user.IsAdmin == true)
            {
                chkIsAdmin.Checked = true;
            }
            else
            {
                chkIsAdmin.Checked = false;
            }
        }
    }
}
