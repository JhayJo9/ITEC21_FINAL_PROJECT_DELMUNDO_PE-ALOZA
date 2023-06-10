using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Main_menu : Form
    {
        public Main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to Guessing Game");
            Form frm2 = new Guessing_Game();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            label1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Welcome to flappy bird!!");
            Form formf = new flappy_bird();
            formf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Thank you for using our project!!!");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form tik_1 = new tik();
            tik_1.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // label_1.Visible = true;

            this.progressBar1.Increment(7);
            if (progressBar1.Value == 100)
            {
                progressBar1.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                label_1.Visible = false;
                label1.Visible = true;


            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
