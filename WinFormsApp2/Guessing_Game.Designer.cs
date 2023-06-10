namespace WinFormsApp2
{
    partial class Guessing_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guessing_Game));
            label1 = new System.Windows.Forms.Label();
            txtEnterNumber = new System.Windows.Forms.TextBox();
            checkbutton = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            lblguess = new System.Windows.Forms.Label();
            lblGuessed = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            Btn_play_again = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Transparent;
            label1.Image = Properties.Resources._348361713_1312682249332706_4222577188304713038_n;
            label1.Location = new System.Drawing.Point(70, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(352, 28);
            label1.TabIndex = 0;
            label1.Text = "Enter a number  between 1 and 100";
            // 
            // txtEnterNumber
            // 
            txtEnterNumber.Location = new System.Drawing.Point(188, 99);
            txtEnterNumber.Name = "txtEnterNumber";
            txtEnterNumber.PlaceholderText = "Guess number";
            txtEnterNumber.Size = new System.Drawing.Size(125, 27);
            txtEnterNumber.TabIndex = 1;
            txtEnterNumber.TextChanged += textBox1_TextChanged;
            // 
            // checkbutton
            // 
            checkbutton.BackgroundImage = (System.Drawing.Image)resources.GetObject("checkbutton.BackgroundImage");
            checkbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            checkbutton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkbutton.ForeColor = System.Drawing.Color.White;
            checkbutton.Location = new System.Drawing.Point(85, 153);
            checkbutton.Name = "checkbutton";
            checkbutton.Size = new System.Drawing.Size(94, 29);
            checkbutton.TabIndex = 2;
            checkbutton.Text = "CHECK";
            checkbutton.UseVisualStyleBackColor = true;
            checkbutton.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.Transparent;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.White;
            button2.Location = new System.Drawing.Point(315, 153);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblguess
            // 
            lblguess.AutoSize = true;
            lblguess.BackColor = System.Drawing.SystemColors.ControlDark;
            lblguess.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblguess.Image = Properties.Resources.images__9__removebg_preview3;
            lblguess.Location = new System.Drawing.Point(244, 129);
            lblguess.Name = "lblguess";
            lblguess.Size = new System.Drawing.Size(0, 31);
            lblguess.TabIndex = 4;
            // 
            // lblGuessed
            // 
            lblGuessed.AutoSize = true;
            lblGuessed.BackColor = System.Drawing.Color.Transparent;
            lblGuessed.ForeColor = System.Drawing.SystemColors.Control;
            lblGuessed.Image = Properties.Resources._348361713_1312682249332706_4222577188304713038_n;
            lblGuessed.Location = new System.Drawing.Point(179, 129);
            lblGuessed.Name = "lblGuessed";
            lblGuessed.Size = new System.Drawing.Size(0, 20);
            lblGuessed.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ivv;
            pictureBox1.Location = new System.Drawing.Point(-5, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(492, 306);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Btn_play_again
            // 
            Btn_play_again.BackgroundImage = (System.Drawing.Image)resources.GetObject("Btn_play_again.BackgroundImage");
            Btn_play_again.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Btn_play_again.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Btn_play_again.ForeColor = System.Drawing.Color.White;
            Btn_play_again.Location = new System.Drawing.Point(168, 188);
            Btn_play_again.Name = "Btn_play_again";
            Btn_play_again.Size = new System.Drawing.Size(154, 29);
            Btn_play_again.TabIndex = 7;
            Btn_play_again.Text = "PLAY AGAIN";
            Btn_play_again.UseVisualStyleBackColor = true;
            Btn_play_again.Visible = false;
            Btn_play_again.Click += Btn_play_again_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Guessing_Game
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(487, 302);
            ControlBox = false;
            Controls.Add(Btn_play_again);
            Controls.Add(lblguess);
            Controls.Add(lblGuessed);
            Controls.Add(button2);
            Controls.Add(checkbutton);
            Controls.Add(txtEnterNumber);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Guessing_Game";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Guessing_Game";
            Load += Guessing_Game_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterNumber;
        private System.Windows.Forms.Button checkbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblguess;
        private System.Windows.Forms.Label lblGuessed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_play_again;
        private System.Windows.Forms.Timer timer1;
    }
}