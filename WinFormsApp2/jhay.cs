using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class jhay : Form
    {
        public jhay()
        {
            InitializeComponent();
        }

        private void credit_exit_marc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form a = new credits();
            a.Show();
        }
    }
}
