﻿namespace YoutubeDownloader
{
    partial class MainMenu
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
            this.TitleLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GoYTVideoAudio = new System.Windows.Forms.Button();
            this.YoutubeDownloaderLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLbl
            // 
            this.TitleLbl.AutoSize = true;
            this.TitleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLbl.Location = new System.Drawing.Point(12, 86);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(208, 20);
            this.TitleLbl.TabIndex = 0;
            this.TitleLbl.Text = "SCEGLI FUNZIONALITÀ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.GoYTVideoAudio);
            this.panel1.Controls.Add(this.YoutubeDownloaderLbl);
            this.panel1.Location = new System.Drawing.Point(17, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 41);
            this.panel1.TabIndex = 1;
            // 
            // GoYTVideoAudio
            // 
            this.GoYTVideoAudio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GoYTVideoAudio.Location = new System.Drawing.Point(249, 8);
            this.GoYTVideoAudio.Name = "GoYTVideoAudio";
            this.GoYTVideoAudio.Size = new System.Drawing.Size(75, 23);
            this.GoYTVideoAudio.TabIndex = 1;
            this.GoYTVideoAudio.Text = "VAI";
            this.GoYTVideoAudio.UseVisualStyleBackColor = false;
            this.GoYTVideoAudio.Click += new System.EventHandler(this.GoYTVideoAudio_Click);
            // 
            // YoutubeDownloaderLbl
            // 
            this.YoutubeDownloaderLbl.AutoSize = true;
            this.YoutubeDownloaderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoutubeDownloaderLbl.Location = new System.Drawing.Point(3, 9);
            this.YoutubeDownloaderLbl.Name = "YoutubeDownloaderLbl";
            this.YoutubeDownloaderLbl.Size = new System.Drawing.Size(228, 18);
            this.YoutubeDownloaderLbl.TabIndex = 0;
            this.YoutubeDownloaderLbl.Text = "Youtube Video/Audio Downloader";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "PROGRAMMI UTILI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TitleLbl);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GoYTVideoAudio;
        private System.Windows.Forms.Label YoutubeDownloaderLbl;
    }
}