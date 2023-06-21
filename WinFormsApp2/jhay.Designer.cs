namespace WinFormsApp2
{
    partial class jhay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jhay));
            pictureBox3 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            credit_exit_marc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG20220827161846;
            pictureBox3.Location = new System.Drawing.Point(12, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(169, 162);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(187, 59);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(258, 80);
            label1.TabIndex = 5;
            label1.Text = "Name: Jhay D. Peñaloza\r\nEmail: penalozajhay8@gmail.com\r\nContact No: 09915086824\r\nAddress: Sungay West, Tagaytay City";
            // 
            // credit_exit_marc
            // 
            credit_exit_marc.BackColor = System.Drawing.Color.Transparent;
            credit_exit_marc.Location = new System.Drawing.Point(393, 183);
            credit_exit_marc.Name = "credit_exit_marc";
            credit_exit_marc.Size = new System.Drawing.Size(94, 29);
            credit_exit_marc.TabIndex = 6;
            credit_exit_marc.Text = "Exit";
            credit_exit_marc.UseVisualStyleBackColor = false;
            credit_exit_marc.Click += credit_exit_marc_Click;
            // 
            // jhay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.carousel1;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(486, 211);
            Controls.Add(credit_exit_marc);
            Controls.Add(label1);
            Controls.Add(pictureBox3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "jhay";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "jhay";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button credit_exit_marc;
    }
}