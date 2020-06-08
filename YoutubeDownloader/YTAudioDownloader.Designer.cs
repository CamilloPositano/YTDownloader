namespace YoutubeDownloader
{
    partial class YTAudioDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTAudioDownloader));
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CompleteTxt = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.YoutubeUrlLbl = new System.Windows.Forms.Label();
            this.UrlTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(24, 57);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(314, 19);
            this.ProgressBar.TabIndex = 13;
            // 
            // CompleteTxt
            // 
            this.CompleteTxt.AutoSize = true;
            this.CompleteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteTxt.ForeColor = System.Drawing.Color.Green;
            this.CompleteTxt.Location = new System.Drawing.Point(101, 53);
            this.CompleteTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompleteTxt.Name = "CompleteTxt";
            this.CompleteTxt.Size = new System.Drawing.Size(0, 20);
            this.CompleteTxt.TabIndex = 12;
            this.CompleteTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.Location = new System.Drawing.Point(257, 28);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(95, 24);
            this.DownloadBtn.TabIndex = 11;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // YoutubeUrlLbl
            // 
            this.YoutubeUrlLbl.AutoSize = true;
            this.YoutubeUrlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoutubeUrlLbl.Location = new System.Drawing.Point(7, 30);
            this.YoutubeUrlLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.YoutubeUrlLbl.Name = "YoutubeUrlLbl";
            this.YoutubeUrlLbl.Size = new System.Drawing.Size(92, 18);
            this.YoutubeUrlLbl.TabIndex = 10;
            this.YoutubeUrlLbl.Text = "Youtube link:";
            this.YoutubeUrlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UrlTXT
            // 
            this.UrlTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlTXT.Location = new System.Drawing.Point(100, 28);
            this.UrlTXT.Margin = new System.Windows.Forms.Padding(2);
            this.UrlTXT.Name = "UrlTXT";
            this.UrlTXT.Size = new System.Drawing.Size(154, 24);
            this.UrlTXT.TabIndex = 9;
            // 
            // YTAudioDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 110);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CompleteTxt);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.YoutubeUrlLbl);
            this.Controls.Add(this.UrlTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YTAudioDownloader";
            this.Text = "YTAudioDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label CompleteTxt;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Label YoutubeUrlLbl;
        private System.Windows.Forms.TextBox UrlTXT;
    }
}