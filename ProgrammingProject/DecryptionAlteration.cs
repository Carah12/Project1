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
    }
}
