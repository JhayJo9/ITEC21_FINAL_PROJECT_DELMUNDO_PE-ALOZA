namespace WinFormsApp2
{
    partial class credits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(credits));
            BG1 = new System.Windows.Forms.PictureBox();
            BG2 = new System.Windows.Forms.PictureBox();
            picniMarc = new System.Windows.Forms.PictureBox();
            picniJahy = new System.Windows.Forms.PictureBox();
            credit_exit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)BG1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BG2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picniMarc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picniJahy).BeginInit();
            SuspendLayout();
            // 
            // BG1
            // 
            BG1.BackColor = System.Drawing.Color.Transparent;
            BG1.Image = Properties.Resources.received_3654478954784803_removebg_preview;
            BG1.Location = new System.Drawing.Point(29, 26);
            BG1.Name = "BG1";
            BG1.Size = new System.Drawing.Size(283, 250);
            BG1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BG1.TabIndex = 0;
            BG1.TabStop = false;
            // 
            // BG2
            // 
            BG2.BackColor = System.Drawing.Color.Transparent;
            BG2.Image = Properties.Resources.received_3654478954784803_removebg_preview;
            BG2.Location = new System.Drawing.Point(344, 26);
            BG2.Name = "BG2";
            BG2.Size = new System.Drawing.Size(283, 250);
            BG2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BG2.TabIndex = 1;
            BG2.TabStop = false;
            // 
            // picniMarc
            // 
            picniMarc.Image = Properties.Resources.received_982814002891459;
            picniMarc.Location = new System.Drawing.Point(89, 78);
            picniMarc.Name = "picniMarc";
            picniMarc.Size = new System.Drawing.Size(169, 158);
            picniMarc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picniMarc.TabIndex = 2;
            picniMarc.TabStop = false;
            picniMarc.Click += picbox_marc;
            // 
            // picniJahy
            // 
            picniJahy.Image = Properties.Resources.IMG20220827161846;
            picniJahy.Location = new System.Drawing.Point(402, 78);
            picniJahy.Name = "picniJahy";
            picniJahy.Size = new System.Drawing.Size(169, 158);
            picniJahy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picniJahy.TabIndex = 3;
            picniJahy.TabStop = false;
            picniJahy.Click += picbox_jj;
            // 
            // credit_exit
            // 
            credit_exit.BackColor = System.Drawing.Color.Transparent;
            credit_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            credit_exit.Image = Properties.Resources.images__2_;
            credit_exit.Location = new System.Drawing.Point(282, 396);
            credit_exit.Name = "credit_exit";
            credit_exit.Size = new System.Drawing.Size(94, 29);
            credit_exit.TabIndex = 7;
            credit_exit.Text = "Exit";
            credit_exit.UseVisualStyleBackColor = false;
            credit_exit.Click += credit_exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(184, 293);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(292, 80);
            label1.TabIndex = 8;
            label1.Text = "Name: Marc Joseph Del Mundo\r\nEmail: marcjdm15@gmail.com\r\nContact No: 09951023976\r\nAddress: 124 Tolentino East, Tagaytay City";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(184, 293);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 80);
            label2.TabIndex = 9;
            label2.Text = "Name: Jhay D. Peñaloza\r\nEmail: penalozajhay8@gmail.com\r\nContact No: 09915086824\r\nAddress: Sungay West, Tagaytay City";
            label2.Visible = false;
            // 
            // btn_back
            // 
            btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_back.Image = Properties.Resources.images__2_;
            btn_back.Location = new System.Drawing.Point(282, 396);
            btn_back.Name = "btn_back";
            btn_back.Size = new System.Drawing.Size(94, 29);
            btn_back.TabIndex = 10;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Visible = false;
            btn_back.Click += back_click;
            // 
            // credits
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._355875621_772702274730688_615971;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(660, 427);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(credit_exit);
            Controls.Add(picniJahy);
            Controls.Add(picniMarc);
            Controls.Add(BG2);
            Controls.Add(BG1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "credits";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "credits";
            Load += credits_Load;
            ((System.ComponentModel.ISupportInitialize)BG1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BG2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picniMarc).EndInit();
            ((System.ComponentModel.ISupportInitialize)picniJahy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox BG1;
        private System.Windows.Forms.PictureBox BG2;
        private System.Windows.Forms.PictureBox picniMarc;
        private System.Windows.Forms.PictureBox picniJahy;
        private System.Windows.Forms.Button credit_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
    }
}