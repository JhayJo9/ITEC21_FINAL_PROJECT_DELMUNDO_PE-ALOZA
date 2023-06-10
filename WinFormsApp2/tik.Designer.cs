namespace WinFormsApp2
{
    partial class tik
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            b9 = new System.Windows.Forms.Button();
            b8 = new System.Windows.Forms.Button();
            b7 = new System.Windows.Forms.Button();
            b6 = new System.Windows.Forms.Button();
            b5 = new System.Windows.Forms.Button();
            b4 = new System.Windows.Forms.Button();
            b3 = new System.Windows.Forms.Button();
            b2 = new System.Windows.Forms.Button();
            b1 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newGameToolStripMenuItem, infoToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(975, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // infoToolStripMenuItem
            // 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            infoToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            infoToolStripMenuItem.Text = "Info";
            infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += tool_exit;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.4856224F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.5143776F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 297F));
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(51, 66);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            tableLayoutPanel1.Size = new System.Drawing.Size(878, 423);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // b9
            // 
            b9.Dock = System.Windows.Forms.DockStyle.Fill;
            b9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b9.FlatAppearance.BorderSize = 7;
            b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b9.Location = new System.Drawing.Point(583, 299);
            b9.Name = "b9";
            b9.Size = new System.Drawing.Size(292, 121);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = true;
            b9.Click += button_click;
            // 
            // b8
            // 
            b8.Dock = System.Windows.Forms.DockStyle.Fill;
            b8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b8.FlatAppearance.BorderSize = 7;
            b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b8.Location = new System.Drawing.Point(273, 299);
            b8.Name = "b8";
            b8.Size = new System.Drawing.Size(304, 121);
            b8.TabIndex = 7;
            b8.UseVisualStyleBackColor = true;
            b8.Click += button_click;
            // 
            // b7
            // 
            b7.Dock = System.Windows.Forms.DockStyle.Fill;
            b7.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b7.FlatAppearance.BorderSize = 7;
            b7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b7.Location = new System.Drawing.Point(3, 299);
            b7.Name = "b7";
            b7.Size = new System.Drawing.Size(264, 121);
            b7.TabIndex = 6;
            b7.UseVisualStyleBackColor = true;
            b7.Click += button_click;
            // 
            // b6
            // 
            b6.Dock = System.Windows.Forms.DockStyle.Fill;
            b6.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b6.FlatAppearance.BorderSize = 7;
            b6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b6.Location = new System.Drawing.Point(583, 151);
            b6.Name = "b6";
            b6.Size = new System.Drawing.Size(292, 142);
            b6.TabIndex = 5;
            b6.UseVisualStyleBackColor = true;
            b6.Click += button_click;
            // 
            // b5
            // 
            b5.Dock = System.Windows.Forms.DockStyle.Fill;
            b5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b5.FlatAppearance.BorderSize = 7;
            b5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b5.Location = new System.Drawing.Point(273, 151);
            b5.Name = "b5";
            b5.Size = new System.Drawing.Size(304, 142);
            b5.TabIndex = 4;
            b5.UseVisualStyleBackColor = true;
            b5.Click += button_click;
            // 
            // b4
            // 
            b4.Dock = System.Windows.Forms.DockStyle.Fill;
            b4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b4.FlatAppearance.BorderSize = 7;
            b4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b4.Location = new System.Drawing.Point(3, 151);
            b4.Name = "b4";
            b4.Size = new System.Drawing.Size(264, 142);
            b4.TabIndex = 3;
            b4.UseVisualStyleBackColor = true;
            b4.Click += button_click;
            // 
            // b3
            // 
            b3.Dock = System.Windows.Forms.DockStyle.Fill;
            b3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b3.FlatAppearance.BorderSize = 7;
            b3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b3.Location = new System.Drawing.Point(583, 3);
            b3.Name = "b3";
            b3.Size = new System.Drawing.Size(292, 142);
            b3.TabIndex = 2;
            b3.UseVisualStyleBackColor = true;
            b3.Click += button_click;
            // 
            // b2
            // 
            b2.Dock = System.Windows.Forms.DockStyle.Fill;
            b2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b2.FlatAppearance.BorderSize = 7;
            b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b2.Location = new System.Drawing.Point(273, 3);
            b2.Name = "b2";
            b2.Size = new System.Drawing.Size(304, 142);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += button_click;
            // 
            // b1
            // 
            b1.Dock = System.Windows.Forms.DockStyle.Fill;
            b1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b1.FlatAppearance.BorderSize = 7;
            b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b1.Location = new System.Drawing.Point(3, 3);
            b1.Name = "b1";
            b1.Size = new System.Drawing.Size(264, 142);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += button_click;
            // 
            // tik
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(975, 542);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "tik";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}