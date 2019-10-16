﻿namespace Packman_Game
{
    partial class Scene2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PacmanGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucScene11 = new Packman_Game.UCScene1();
            this.dots1 = new Packman_Game.Characters.Dots();
            this.pacman1 = new Packman_Game.Characters.Pacman();
            this.PacmanGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 704);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 704);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "[You Score]";
            // 
            // PacmanGroupBox
            // 
            this.PacmanGroupBox.Controls.Add(this.pacman1);
            this.PacmanGroupBox.Controls.Add(this.dots1);
            this.PacmanGroupBox.Controls.Add(this.ucScene11);
            this.PacmanGroupBox.Location = new System.Drawing.Point(16, 15);
            this.PacmanGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.PacmanGroupBox.Name = "PacmanGroupBox";
            this.PacmanGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PacmanGroupBox.Size = new System.Drawing.Size(883, 671);
            this.PacmanGroupBox.TabIndex = 2;
            this.PacmanGroupBox.TabStop = false;
            this.PacmanGroupBox.Text = "Pacman ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 704);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note: W= Up , S = Down , D = Right , A = Left";
            // 
            // ucScene11
            // 
            this.ucScene11.Location = new System.Drawing.Point(8, 23);
            this.ucScene11.Name = "ucScene11";
            this.ucScene11.Size = new System.Drawing.Size(809, 614);
            this.ucScene11.TabIndex = 0;
            // 
            // dots1
            // 
            this.dots1.Dot_Color = System.Drawing.Color.Yellow;
            this.dots1.Location = new System.Drawing.Point(278, 205);
            this.dots1.Name = "dots1";
            this.dots1.Size = new System.Drawing.Size(30, 30);
            this.dots1.TabIndex = 1;
            this.dots1.Text = "dots1";
            // 
            // pacman1
            // 
            this.pacman1.Location = new System.Drawing.Point(267, 253);
            this.pacman1.Name = "pacman1";
            this.pacman1.Size = new System.Drawing.Size(40, 40);
            this.pacman1.Speed = 20;
            this.pacman1.TabIndex = 2;
            this.pacman1.Text = "pacman1";
            this.pacman1.TotalPoints = 0;
            // 
            // Scene2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(915, 747);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PacmanGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Scene2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Scene2_KeyDown);
            this.PacmanGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox PacmanGroupBox;
        private System.Windows.Forms.Label label2;
        private UCScene1 ucScene11;
        private Characters.Pacman pacman1;
        private Characters.Dots dots1;
    }
}

