namespace WinFormsApp2
{
    partial class flappy_bird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flappy_bird));
            pipetop = new System.Windows.Forms.PictureBox();
            pipe_bottom = new System.Windows.Forms.PictureBox();
            bird_ko = new System.Windows.Forms.PictureBox();
            gametimer = new System.Windows.Forms.Timer(components);
            ground = new System.Windows.Forms.PictureBox();
            score_txt = new System.Windows.Forms.Label();
            Go = new System.Windows.Forms.Label();
            lbl_play = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pipetop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipe_bottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bird_ko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipetop
            // 
            pipetop.BackColor = System.Drawing.Color.Transparent;
            pipetop.BackgroundImage = Properties.Resources._351647856_925997351830902_1435861530976694320_n_1_removebg_preview;
            pipetop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pipetop.ErrorImage = null;
            pipetop.Location = new System.Drawing.Point(457, 0);
            pipetop.Name = "pipetop";
            pipetop.Size = new System.Drawing.Size(141, 131);
            pipetop.TabIndex = 0;
            pipetop.TabStop = false;
            // 
            // pipe_bottom
            // 
            pipe_bottom.BackColor = System.Drawing.Color.Transparent;
            pipe_bottom.BackgroundImage = Properties.Resources._350221162_273687345038563_2938339687383004408_n_removebg_preview;
            pipe_bottom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pipe_bottom.Location = new System.Drawing.Point(376, 431);
            pipe_bottom.Name = "pipe_bottom";
            pipe_bottom.Size = new System.Drawing.Size(146, 135);
            pipe_bottom.TabIndex = 2;
            pipe_bottom.TabStop = false;
            // 
            // bird_ko
            // 
            bird_ko.BackColor = System.Drawing.Color.Transparent;
            bird_ko.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bird_ko.Image = Properties.Resources.output_onlinegiftools;
            bird_ko.Location = new System.Drawing.Point(74, 145);
            bird_ko.Name = "bird_ko";
            bird_ko.Size = new System.Drawing.Size(96, 72);
            bird_ko.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            bird_ko.TabIndex = 3;
            bird_ko.TabStop = false;
            bird_ko.Click += bird_ko_Click;
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gametimeevent;
            // 
            // ground
            // 
            ground.BackColor = System.Drawing.Color.Transparent;
            ground.BackgroundImage = (System.Drawing.Image)resources.GetObject("ground.BackgroundImage");
            ground.Location = new System.Drawing.Point(-32, 562);
            ground.Name = "ground";
            ground.Size = new System.Drawing.Size(721, 112);
            ground.TabIndex = 4;
            ground.TabStop = false;
            // 
            // score_txt
            // 
            score_txt.AutoSize = true;
            score_txt.BackColor = System.Drawing.Color.Transparent;
            score_txt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score_txt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            score_txt.Location = new System.Drawing.Point(44, 599);
            score_txt.Name = "score_txt";
            score_txt.Size = new System.Drawing.Size(111, 41);
            score_txt.TabIndex = 5;
            score_txt.Text = "Score: ";
            // 
            // Go
            // 
            Go.AutoSize = true;
            Go.BackColor = System.Drawing.Color.Transparent;
            Go.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Go.Location = new System.Drawing.Point(249, 220);
            Go.Name = "Go";
            Go.Size = new System.Drawing.Size(213, 54);
            Go.TabIndex = 9;
            Go.Text = "Press R to Restart\r\n  Press Q to Exit";
            Go.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Go.Visible = false;
            // 
            // lbl_play
            // 
            lbl_play.AutoSize = true;
            lbl_play.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_play.Location = new System.Drawing.Point(313, 248);
            lbl_play.Name = "lbl_play";
            lbl_play.Size = new System.Drawing.Size(96, 41);
            lbl_play.TabIndex = 10;
            lbl_play.Text = "PLAY";
            lbl_play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl_play.Click += play_click;
            // 
            // flappy_bird
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.MenuHighlight;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(687, 658);
            Controls.Add(lbl_play);
            Controls.Add(Go);
            Controls.Add(score_txt);
            Controls.Add(bird_ko);
            Controls.Add(ground);
            Controls.Add(pipe_bottom);
            Controls.Add(pipetop);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "flappy_bird";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Flying Waddles";
            Load += flappy_bird_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipetop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipe_bottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)bird_ko).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pipetop;
        private System.Windows.Forms.PictureBox pipe_bottom;
        private System.Windows.Forms.PictureBox bird_ko;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label score_txt;
        private System.Windows.Forms.Label Go;
        private System.Windows.Forms.Label lbl_play;
    }
}