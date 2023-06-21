using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class flappy_bird : Form
    {
        int gravity = 15;
        int pipe_speed = 8;
        int score = 0;
        bool game_over;
        public flappy_bird()
        {
            InitializeComponent();
            restart_game();
            gametimer.Stop();
            ground.Controls.Add(score_txt);
            score_txt.Left = 35;
            score_txt.Top = 30;
        }

        private void gametimeevent(object sender, EventArgs e)
        {
            bird_ko.Top += gravity;
            pipe_bottom.Left -= pipe_speed;
            pipetop.Left -= pipe_speed;
            score_txt.Text = "Score: " + score;
            if (pipe_bottom.Left < -150)
            {
                pipe_bottom.Left = 705;
                score++;
            }
            if (pipetop.Left < -80)
            {
                pipetop.Left = 705;
                score++;
            }
            if (bird_ko.Bounds.IntersectsWith(pipe_bottom.Bounds) ||
                    bird_ko.Bounds.IntersectsWith(pipetop.Bounds) ||
                    bird_ko.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                ENDgAME();
            }
            if (score > 5)
            {
                pipe_speed = 15;
            }
            if (bird_ko.Top < -25)
            {
                ENDgAME();
            }
        }

        private void bird_ko_Click(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {

                gravity = -15;
            }
            if (e.KeyCode == Keys.R && game_over)
            {
                Go.Visible = false;
                restart_game();
            }
            if (e.KeyCode == Keys.Q && game_over)
            {
                this.Hide();
                Form frm3 = new Main_menu();
                frm3.Show();
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void ENDgAME()
        {

            Go.Visible = true;
            gametimer.Stop();
            score_txt.Visible = true;

            game_over = true;

        }

        private void restart_game()
        {
            score_txt.Visible = true;
            Go.Visible = false;
            game_over = false;
            bird_ko.Location = new Point(96, 72);
            pipetop.Left = 705;
            pipe_bottom.Left = 1200;
            score = 0;
            pipe_speed = 8;
            score_txt.Text = "Score : ";
            gametimer.Stop();
            lbl_play.Visible = true;



        }
        private void restartclick_event(object sender, EventArgs e)
        {
            restart_game();
            gametimer.Stop();
        }

        private void exitclick_event(object sender, EventArgs e)
        {
            this.Hide();

            Form frm3 = new Main_menu();
            frm3.Show();
        }

        private void flappy_bird_Load(object sender, EventArgs e)
        {

        }

        private void play_click(object sender, EventArgs e)
        {
            lbl_play.Visible = false;
            gametimer.Start();
        }


    }
}
