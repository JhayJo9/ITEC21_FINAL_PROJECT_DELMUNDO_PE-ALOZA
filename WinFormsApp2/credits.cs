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
            BG1.Location = new Point(167, 26);
            BG2.Visible = false;
            picniJahy.Visible = false;
            picniMarc.Location = new Point(227, 78);
            credit_exit.Visible = false;
            btn_back.Visible = true;

        }

        private void picbox_jj(object sender, EventArgs e)
        {

            label2.Visible = true;
            BG2.Location = new Point(167, 26);
            BG1.Visible = false;
            picniMarc.Visible = false;
            picniJahy.Location = new Point(227, 78);
            credit_exit.Visible = false;
            btn_back.Visible = true;

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

        private void back_click(object sender, EventArgs e)
        {

            BG2.Visible = true;
            picniJahy.Visible = true;
            credit_exit.Visible = true;
            btn_back.Visible = false;
            BG1.Visible = true;
            BG1.Location = new Point(29, 26);
            picniMarc.Visible = true;
            picniMarc.Location = new Point(89, 78);
            BG2.Visible = true;
            BG2.Location = new Point(344, 26);
            picniJahy.Location = new Point(402, 78);
            label1.Visible = false;
            label2.Visible = false;

        }
    }
}
