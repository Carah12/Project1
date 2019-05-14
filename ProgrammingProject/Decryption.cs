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


namespace ProgrammingProject
{
    public partial class Decryption : Form
    {
        public Decryption()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDecryption_Click_1(object sender, EventArgs e)
        {
            string filename = txtBrowse.Text;
            Filehandler fh = new Filehandler();
            Decoding.
        }
    }
}
