namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txt_user = new System.Windows.Forms.TextBox();
            txt_pass = new System.Windows.Forms.TextBox();
            btn_login = new System.Windows.Forms.Button();
            btn_exit = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Image = Properties.Resources.gd;
            label1.Location = new System.Drawing.Point(41, 53);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(93, 23);
            label1.TabIndex = 0;
            label1.Text = "  User ID:  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Image = Properties.Resources.gd;
            label2.Location = new System.Drawing.Point(41, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(90, 23);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txt_user
            // 
            txt_user.BackColor = System.Drawing.Color.DarkGoldenrod;
            txt_user.Location = new System.Drawing.Point(165, 52);
            txt_user.Name = "txt_user";
            txt_user.Size = new System.Drawing.Size(220, 27);
            txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = System.Drawing.Color.DarkGoldenrod;
            txt_pass.Location = new System.Drawing.Point(165, 96);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.Size = new System.Drawing.Size(220, 27);
            txt_pass.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_login.BackgroundImage");
            btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_login.Location = new System.Drawing.Point(421, 52);
            btn_login.Name = "btn_login";
            btn_login.Size = new System.Drawing.Size(73, 27);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackgroundImage = (System.Drawing.Image)resources.GetObject("btn_exit.BackgroundImage");
            btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_exit.Location = new System.Drawing.Point(421, 97);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new System.Drawing.Size(71, 26);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources._351441857_206318178988638_2825366696066516571_n;
            pictureBox1.Location = new System.Drawing.Point(-4, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(575, 183);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SeaGreen;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(573, 183);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
