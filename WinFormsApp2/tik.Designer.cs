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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            score_player_1 = new System.Windows.Forms.Label();
            score_player_2 = new System.Windows.Forms.Label();
            lbl_reset = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { newGameToolStripMenuItem, infoToolStripMenuItem, exitToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(919, 28);
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
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.20213F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79787F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            tableLayoutPanel1.Controls.Add(b9, 2, 2);
            tableLayoutPanel1.Controls.Add(b8, 1, 2);
            tableLayoutPanel1.Controls.Add(b7, 0, 2);
            tableLayoutPanel1.Controls.Add(b6, 2, 1);
            tableLayoutPanel1.Controls.Add(b5, 1, 1);
            tableLayoutPanel1.Controls.Add(b4, 0, 1);
            tableLayoutPanel1.Controls.Add(b3, 2, 0);
            tableLayoutPanel1.Controls.Add(b2, 1, 0);
            tableLayoutPanel1.Controls.Add(b1, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(26, 31);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(560, 416);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // b9
            // 
            b9.BackColor = System.Drawing.Color.White;
            b9.Dock = System.Windows.Forms.DockStyle.Fill;
            b9.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b9.FlatAppearance.BorderSize = 7;
            b9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b9.Location = new System.Drawing.Point(365, 285);
            b9.Name = "b9";
            b9.Size = new System.Drawing.Size(192, 128);
            b9.TabIndex = 8;
            b9.UseVisualStyleBackColor = false;
            b9.Click += button_click;
            // 
            // b8
            // 
            b8.Dock = System.Windows.Forms.DockStyle.Fill;
            b8.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b8.FlatAppearance.BorderSize = 7;
            b8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b8.Location = new System.Drawing.Point(181, 285);
            b8.Name = "b8";
            b8.Size = new System.Drawing.Size(178, 128);
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
            b7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b7.Location = new System.Drawing.Point(3, 285);
            b7.Name = "b7";
            b7.Size = new System.Drawing.Size(172, 128);
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
            b6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b6.Location = new System.Drawing.Point(365, 144);
            b6.Name = "b6";
            b6.Size = new System.Drawing.Size(192, 135);
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
            b5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b5.Location = new System.Drawing.Point(181, 144);
            b5.Name = "b5";
            b5.Size = new System.Drawing.Size(178, 135);
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
            b4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b4.Location = new System.Drawing.Point(3, 144);
            b4.Name = "b4";
            b4.Size = new System.Drawing.Size(172, 135);
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
            b3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b3.Location = new System.Drawing.Point(365, 3);
            b3.Name = "b3";
            b3.Size = new System.Drawing.Size(192, 135);
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
            b2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b2.Location = new System.Drawing.Point(181, 3);
            b2.Name = "b2";
            b2.Size = new System.Drawing.Size(178, 135);
            b2.TabIndex = 1;
            b2.UseVisualStyleBackColor = true;
            b2.Click += button_click;
            // 
            // b1
            // 
            b1.BackColor = System.Drawing.Color.White;
            b1.Dock = System.Windows.Forms.DockStyle.Fill;
            b1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            b1.FlatAppearance.BorderSize = 7;
            b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            b1.Location = new System.Drawing.Point(3, 3);
            b1.Name = "b1";
            b1.Size = new System.Drawing.Size(172, 135);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = false;
            b1.Click += button_click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.player1_img_score;
            pictureBox1.Location = new System.Drawing.Point(614, 87);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(125, 120);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.player2_img_score;
            pictureBox2.Location = new System.Drawing.Point(614, 220);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(125, 120);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // score_player_1
            // 
            score_player_1.AutoSize = true;
            score_player_1.BackColor = System.Drawing.Color.Transparent;
            score_player_1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score_player_1.ForeColor = System.Drawing.Color.LightGreen;
            score_player_1.Location = new System.Drawing.Point(745, 121);
            score_player_1.Name = "score_player_1";
            score_player_1.Size = new System.Drawing.Size(102, 38);
            score_player_1.TabIndex = 4;
            score_player_1.Text = "Score:";
            // 
            // score_player_2
            // 
            score_player_2.AutoSize = true;
            score_player_2.BackColor = System.Drawing.Color.Transparent;
            score_player_2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            score_player_2.ForeColor = System.Drawing.Color.LightGreen;
            score_player_2.Location = new System.Drawing.Point(745, 265);
            score_player_2.Name = "score_player_2";
            score_player_2.Size = new System.Drawing.Size(102, 38);
            score_player_2.TabIndex = 5;
            score_player_2.Text = "Score:";
            // 
            // lbl_reset
            // 
            lbl_reset.AutoSize = true;
            lbl_reset.BackColor = System.Drawing.Color.Transparent;
            lbl_reset.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_reset.ForeColor = System.Drawing.Color.Green;
            lbl_reset.Location = new System.Drawing.Point(685, 370);
            lbl_reset.Name = "lbl_reset";
            lbl_reset.Size = new System.Drawing.Size(100, 38);
            lbl_reset.TabIndex = 6;
            lbl_reset.Text = "RESET";
            lbl_reset.Click += lblReset;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Green;
            label1.Location = new System.Drawing.Point(708, 362);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(100, 38);
            label1.TabIndex = 12;
            label1.Text = "RESET";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.LightGreen;
            label2.Location = new System.Drawing.Point(768, 113);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 38);
            label2.TabIndex = 10;
            label2.Text = "Score:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.LightGreen;
            label3.Location = new System.Drawing.Point(768, 257);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(102, 38);
            label3.TabIndex = 11;
            label3.Text = "Score:";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = System.Drawing.Color.Transparent;
            pictureBox3.Image = Properties.Resources.player2_img_score;
            pictureBox3.Location = new System.Drawing.Point(637, 212);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(125, 120);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = System.Drawing.Color.Transparent;
            pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pictureBox4.Image = Properties.Resources.player1_img_score;
            pictureBox4.Location = new System.Drawing.Point(637, 79);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(125, 120);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.20213F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79787F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            tableLayoutPanel2.Controls.Add(button1, 2, 2);
            tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Dock = System.Windows.Forms.DockStyle.Fill;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button1.FlatAppearance.BorderSize = 7;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(6, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(191, 128);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Fill;
            button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button2.FlatAppearance.BorderSize = 7;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(4, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(1, 128);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.20213F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.79787F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            tableLayoutPanel3.Controls.Add(button3, 2, 2);
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.White;
            button3.Dock = System.Windows.Forms.DockStyle.Fill;
            button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button3.FlatAppearance.BorderSize = 7;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button3.Location = new System.Drawing.Point(6, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(191, 128);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Dock = System.Windows.Forms.DockStyle.Fill;
            button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button4.FlatAppearance.BorderSize = 7;
            button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button4.Location = new System.Drawing.Point(4, 3);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(1, 128);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // tik
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = Properties.Resources._353450901_651732730147464_701035;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(919, 463);
            ControlBox = false;
            Controls.Add(lbl_reset);
            Controls.Add(score_player_1);
            Controls.Add(score_player_2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Name = "tik";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += tik_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label score_player_1;
        private System.Windows.Forms.Label score_player_2;
        private System.Windows.Forms.Label lbl_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}