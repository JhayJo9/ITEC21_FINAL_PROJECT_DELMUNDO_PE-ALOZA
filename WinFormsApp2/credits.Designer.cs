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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            credit_exit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.received_3654478954784803_removebg_preview;
            pictureBox1.Location = new System.Drawing.Point(29, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(283, 250);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.received_3654478954784803_removebg_preview;
            pictureBox2.Location = new System.Drawing.Point(344, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(283, 250);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.received_982814002891459;
            pictureBox3.Location = new System.Drawing.Point(89, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(169, 158);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += picbox_marc;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.IMG20220827161846;
            pictureBox4.Location = new System.Drawing.Point(402, 78);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(169, 158);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Click += picbox_jj;
            // 
            // credit_exit
            // 
            credit_exit.BackColor = System.Drawing.Color.Transparent;
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
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(29, 302);
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
            label2.Location = new System.Drawing.Point(344, 293);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(258, 80);
            label2.TabIndex = 9;
            label2.Text = "Name: Jhay D. Peñaloza\r\nEmail: penalozajhay8@gmail.com\r\nContact No: 09915086824\r\nAddress: Sungay West, Tagaytay City";
            label2.Visible = false;
            // 
            // credits
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(660, 427);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(credit_exit);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "credits";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "credits";
            Load += credits_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button credit_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}