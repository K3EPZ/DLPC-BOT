﻿namespace DuelLinks_BOT
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.procIDlabel = new System.Windows.Forms.Label();
            this.procStatus = new System.Windows.Forms.Label();
            this.fastlevel = new System.Windows.Forms.CheckBox();
            this.screenshot = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Process Status:";
            // 
            // procIDlabel
            // 
            this.procIDlabel.AutoSize = true;
            this.procIDlabel.Location = new System.Drawing.Point(80, 9);
            this.procIDlabel.Name = "procIDlabel";
            this.procIDlabel.Size = new System.Drawing.Size(14, 13);
            this.procIDlabel.TabIndex = 3;
            this.procIDlabel.Text = "#";
            // 
            // procStatus
            // 
            this.procStatus.AutoSize = true;
            this.procStatus.ForeColor = System.Drawing.Color.Red;
            this.procStatus.Location = new System.Drawing.Point(99, 37);
            this.procStatus.Name = "procStatus";
            this.procStatus.Size = new System.Drawing.Size(50, 13);
            this.procStatus.TabIndex = 4;
            this.procStatus.Text = "CLOSED";
            // 
            // fastlevel
            // 
            this.fastlevel.AutoSize = true;
            this.fastlevel.Location = new System.Drawing.Point(12, 83);
            this.fastlevel.Name = "fastlevel";
            this.fastlevel.Size = new System.Drawing.Size(133, 17);
            this.fastlevel.TabIndex = 5;
            this.fastlevel.Text = "Fast Level (LD Lvl. 10)";
            this.fastlevel.UseVisualStyleBackColor = true;
            this.fastlevel.CheckedChanged += new System.EventHandler(this.fastlevel_CheckedChanged);
            // 
            // screenshot
            // 
            this.screenshot.Location = new System.Drawing.Point(193, 79);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(108, 23);
            this.screenshot.TabIndex = 6;
            this.screenshot.Text = "Search Vagabond";
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.Click += new System.EventHandler(this.screenshot_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // openGame
            // 
            this.openGame.Location = new System.Drawing.Point(193, 4);
            this.openGame.Name = "openGame";
            this.openGame.Size = new System.Drawing.Size(108, 23);
            this.openGame.TabIndex = 7;
            this.openGame.Text = "Open Game";
            this.openGame.UseVisualStyleBackColor = true;
            this.openGame.Click += new System.EventHandler(this.openGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 107);
            this.Controls.Add(this.openGame);
            this.Controls.Add(this.screenshot);
            this.Controls.Add(this.fastlevel);
            this.Controls.Add(this.procStatus);
            this.Controls.Add(this.procIDlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label procIDlabel;
        private System.Windows.Forms.Label procStatus;
        private System.Windows.Forms.CheckBox fastlevel;
        private System.Windows.Forms.Button screenshot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button openGame;
    }
}

