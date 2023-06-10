using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class tik : Form
    {
        char who = 'O';
        short movement = 0;

        public tik()
        {
            InitializeComponent();
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            who = 'O';
            movement = 0;
            b1.Enabled = true; b1.Text = "";
            b2.Enabled = true; b2.Text = "";
            b3.Enabled = true; b3.Text = "";
            b4.Enabled = true; b4.Text = "";
            b5.Enabled = true; b5.Text = "";
            b6.Enabled = true; b6.Text = "";
            b7.Enabled = true; b7.Text = "";
            b8.Enabled = true; b8.Text = "";
            b9.Enabled = true; b9.Text = "";
            tableLayoutPanel1.Enabled = true;
        }

        private void buttonS_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            bt.BackColor = Color.Orange;
            if (who == 'O')
            {
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b2.Text != "" ||
                    b4.Text == b5.Text && b5.Text == b6.Text && b5.Text != "" ||
                     b7.Text == b8.Text && b8.Text == b9.Text && b8.Text != "" ||
                      b1.Text == b4.Text && b4.Text == b7.Text && b4.Text != "" ||
                       b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "" ||
                        b3.Text == b6.Text && b6.Text == b9.Text && b6.Text != "" ||
                          b1.Text == b5.Text && b5.Text == b9.Text && b5.Text != "" ||
                            b3.Text == b5.Text && b5.Text == b7.Text && b5.Text != ""))
                {
                    MessageBox.Show(($"The winner is {who.ToString().ToUpper()} !!!"));
                    tableLayoutPanel1.Enabled = false;
                }
                else if (movement == 8)
                {
                    MessageBox.Show("Draw !!!");
                }
                who = 'X';


            }
            else if (who == 'X')
            {
                bt.Text = "X";
                who = 'O';

            }
            movement++;
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This game is tic tac toe and the author of this game is Marc and JhayJ");
        }

        private void tool_exit(object sender, EventArgs e)
        {
            this.Hide();
            Form toe_menu = new Main_menu();
            toe_menu.ShowDialog();
        }
    }
}
