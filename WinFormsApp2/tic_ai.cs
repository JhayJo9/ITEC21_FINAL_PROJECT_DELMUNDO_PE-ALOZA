using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp2
{
    public partial class tic_ai : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;
        Random random = new Random();
        int score_player1 = 0;
        int score_ai = 0;
        int movement1 = 0;
        List<Button> buttons;

        public tic_ai()
        {
            InitializeComponent();
            resetGame();
        }

        private void cpu_move(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                currentPlayer = Player.X;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon;
                buttons.RemoveAt(index);
                movement1++;
                checkGame();
                timer1.Stop();
                scorePlayer.Text = "Score : " + score_player1;
                scoreAi.Text = "Score : " + score_ai;
            }
        }

        private void btn_player_click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.O;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.SlateGray;
            // button.BackgroundImage = global::WinFormsApp2.Properties.Resources.player1_img;
            //button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            buttons.Remove(button);
            movement1++;
            checkGame();
            timer1.Start();
            scorePlayer.Text = "Score : " + score_player1;
            scoreAi.Text = "Score : " + score_ai;
        }

        private void checkGame()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                score_ai++;
                timer1.Stop();
                scoreAi.Text = "Score : " + score_ai.ToString();
                movement1 = 0;
                MessageBox.Show("WINNER AI X", "Win", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                resetGame();

            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                score_player1++;
                scorePlayer.Text = "Score : " + score_player1.ToString();
                movement1 = 0;
                MessageBox.Show("WINNER PLAYER 0", "Win", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                resetGame();

            }
            else if (movement1 == 9)
            {
                MessageBox.Show("DRAW !!!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
        }
        private void resetGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4,
                button5,button6,button7,button8,button9};
            foreach (Button Btn in buttons)
            {
                Btn.Enabled = true;
                Btn.Text = "";
                Btn.BackColor = DefaultBackColor;
            }
            movement1 = 0;
        }
        private void Reset_Score(object sender, EventArgs e)
        {
            buttons = new List<Button> { button1, button2, button3, button4,
                button5,button6,button7,button8,button9};
            foreach (Button Btn in buttons)
            {
                Btn.Enabled = true;
                Btn.Text = "";
                Btn.BackColor = DefaultBackColor;
            }
            scorePlayer.Text = "Score : " + score_player1;
            scoreAi.Text = "Score : " + score_ai;
            score_player1 = 0;
            score_ai = 0;

            resetGame();
        }
        private void new_game(object sender, EventArgs e)
        {
            DialogResult mess1 = MessageBox.Show("Play again?", "", MessageBoxButtons.YesNoCancel);
            if (mess1 == DialogResult.Yes)
            {
                resetGame();
            }
        }

        private void scorePlayer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_exit(object sender, EventArgs e)
        {
            this.Hide();
            Form es = new Main_menu();
            es.ShowDialog();
        }

        private void tic_ai_Load(object sender, EventArgs e)
        {

        }
    }
}
