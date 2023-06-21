using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class credits : Form
    {
        public credits()
        {
            InitializeComponent();
        }

        private void picbox_marc(object sender, EventArgs e)
        {


            label1.Visible = true;

        }

        private void picbox_jj(object sender, EventArgs e)
        {

            label2.Visible = true;
        }

        private void credit_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form a = new Main_menu();
            a.ShowDialog();
        }

        private void credits_Load(object sender, EventArgs e)
        {

        }

        private void view_creator(object sender, EventArgs e)
        {
           
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
