namespace WinFormsApp2
{
    partial class tic_ai
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            scorePlayer = new System.Windows.Forms.Label();
            scoreAi = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            resetscore = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.HotTrack;
            button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(43, 56);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(140, 120);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_player_click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.HotTrack;
            button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(189, 56);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(140, 120);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += btn_player_click;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.SystemColors.HotTrack;
            button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(335, 56);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(140, 120);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += btn_player_click;
            // 
            // button4
            // 
            button4.BackColor = System.Drawing.SystemColors.HotTrack;
            button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(43, 182);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(140, 120);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.Click += btn_player_click;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.SystemColors.HotTrack;
            button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.Location = new System.Drawing.Point(189, 182);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(140, 120);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.Click += btn_player_click;
            // 
            // button6
            // 
            button6.BackColor = System.Drawing.SystemColors.HotTrack;
            button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button6.Location = new System.Drawing.Point(335, 182);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(140, 120);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += btn_player_click;
            // 
            // button7
            // 
            button7.BackColor = System.Drawing.SystemColors.HotTrack;
            button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button7.Location = new System.Drawing.Point(43, 308);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(140, 120);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += btn_player_click;
            // 
            // button8
            // 
            button8.BackColor = System.Drawing.SystemColors.HotTrack;
            button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button8.Location = new System.Drawing.Point(189, 308);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(140, 120);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += btn_player_click;
            // 
            // button9
            // 
            button9.BackColor = System.Drawing.SystemColors.HotTrack;
            button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button9.Location = new System.Drawing.Point(335, 308);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(140, 120);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += btn_player_click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += cpu_move;
            // 
            // scorePlayer
            // 
            scorePlayer.AutoSize = true;
            scorePlayer.BackColor = System.Drawing.Color.Transparent;
            scorePlayer.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            scorePlayer.ForeColor = System.Drawing.Color.White;
            scorePlayer.Location = new System.Drawing.Point(625, 150);
            scorePlayer.Name = "scorePlayer";
            scorePlayer.Size = new System.Drawing.Size(69, 25);
            scorePlayer.TabIndex = 11;
            scorePlayer.Text = "Score: ";
            scorePlayer.Click += scorePlayer_Click;
            // 
            // scoreAi
            // 
            scoreAi.AutoSize = true;
            scoreAi.BackColor = System.Drawing.Color.Transparent;
            scoreAi.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            scoreAi.ForeColor = System.Drawing.Color.White;
            scoreAi.Location = new System.Drawing.Point(625, 273);
            scoreAi.Name = "scoreAi";
            scoreAi.Size = new System.Drawing.Size(69, 25);
            scoreAi.TabIndex = 12;
            scoreAi.Text = "Score: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.player1_img_score;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Location = new System.Drawing.Point(491, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(128, 116);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.ai_img;
            pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox2.Location = new System.Drawing.Point(491, 242);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(128, 96);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // resetscore
            // 
            resetscore.AutoSize = true;
            resetscore.BackColor = System.Drawing.Color.Transparent;
            resetscore.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            resetscore.ForeColor = System.Drawing.Color.White;
            resetscore.Location = new System.Drawing.Point(583, 356);
            resetscore.Name = "resetscore";
            resetscore.Size = new System.Drawing.Size(111, 25);
            resetscore.TabIndex = 15;
            resetscore.Text = "Reset Score";
            resetscore.Click += Reset_Score;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(43, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 25);
            label1.TabIndex = 16;
            label1.Text = "New Game";
            label1.Click += new_game;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(491, 356);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(44, 25);
            label2.TabIndex = 18;
            label2.Text = "Exit";
            label2.Click += lbl_exit;
            // 
            // tic_ai
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ScrollBar;
            BackgroundImage = Properties.Resources._37f3b3367f7a29c59cd10d0b567dfb21;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(741, 475);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resetscore);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(scoreAi);
            Controls.Add(scorePlayer);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Name = "tic_ai";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "tic_ai";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorePlayer;
        private System.Windows.Forms.Label scoreAi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label resetscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}