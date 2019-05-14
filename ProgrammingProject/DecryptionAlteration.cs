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

        List<User> popUsers = new List<User>();

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            DBAccess dba = new DBAccess();
            ArrayList arrInsert = new ArrayList();
            bool isAdmin;

            if (chkIsAdmin.Checked)
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }

            arrInsert.Add(txtName.Text);
            arrInsert.Add(txtSurname.Text);
            arrInsert.Add(int.Parse(txtAge.Text));
            arrInsert.Add(txtRank.Text);
            arrInsert.Add(txtIDNumber.Text);
            arrInsert.Add(txtUsername.Text);
            arrInsert.Add(txtPassword.Text);
            arrInsert.Add(isAdmin);
            dba.InsertUser(arrInsert);


            popUsers = user.PopulateUsers();
            bs.DataSource = popUsers;
            dgvDisplay.DataSource = bs;


            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = bs;
            
        }

        private void DecryptionAlteration_Load(object sender, EventArgs e)
        {

            popUsers = user.PopulateUsers();
            bs.DataSource = popUsers;
            dgvDisplay.DataSource = bs;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        int ID;
        private void dgvDisplay_SelectionChanged(object sender, EventArgs e)
        {
            
            User user = (User)bs.Current;
            ID = user.UserID;
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

            RefreshData();
        }

        public void RefreshData()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            dba.DeleteUser(ID);

            popUsers = user.PopulateUsers();
            bs.DataSource = popUsers;
            dgvDisplay.DataSource = bs;


            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = bs;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ArrayList arrUpdate = new ArrayList();
            bool isAdmin;

            if (chkIsAdmin.Checked)
            {
                isAdmin = true;
            }
            else
            {
                isAdmin = false;
            }

            arrUpdate.Add(txtName.Text);
            arrUpdate.Add(txtSurname.Text);
            arrUpdate.Add(int.Parse(txtAge.Text));
            arrUpdate.Add(txtRank.Text);
            arrUpdate.Add(txtIDNumber.Text);
            arrUpdate.Add(txtUsername.Text);
            arrUpdate.Add(txtPassword.Text);
            arrUpdate.Add(isAdmin);
            dba.UpdateUser(ID, arrUpdate);

            popUsers = user.PopulateUsers();
            bs.DataSource = popUsers;
            dgvDisplay.DataSource = bs;


            dgvDisplay.DataSource = null;
            dgvDisplay.DataSource = bs;

            

        }

        private void btnDecryption_Click(object sender, EventArgs e)
        {

        }
    }
}
