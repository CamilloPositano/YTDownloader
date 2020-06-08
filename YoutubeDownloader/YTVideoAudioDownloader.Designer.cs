namespace YoutubeDownloader
{
    partial class YTVideoAudioDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YTVideoAudioDownloader));
            this.UrlTXT = new System.Windows.Forms.TextBox();
            this.YoutubeUrlLbl = new System.Windows.Forms.Label();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.CompleteTxt = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.QualityCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UrlTXT
            // 
            this.UrlTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrlTXT.Location = new System.Drawing.Point(131, 32);
            this.UrlTXT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UrlTXT.Name = "UrlTXT";
            this.UrlTXT.Size = new System.Drawing.Size(204, 28);
            this.UrlTXT.TabIndex = 0;
            // 
            // YoutubeUrlLbl
            // 
            this.YoutubeUrlLbl.AutoSize = true;
            this.YoutubeUrlLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YoutubeUrlLbl.Location = new System.Drawing.Point(7, 34);
            this.YoutubeUrlLbl.Name = "YoutubeUrlLbl";
            this.YoutubeUrlLbl.Size = new System.Drawing.Size(119, 24);
            this.YoutubeUrlLbl.TabIndex = 1;
            this.YoutubeUrlLbl.Text = "Youtube link:";
            this.YoutubeUrlLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.YoutubeUrlLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.Location = new System.Drawing.Point(340, 32);
            this.DownloadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(127, 30);
            this.DownloadBtn.TabIndex = 4;
            this.DownloadBtn.Text = "Download";
            this.DownloadBtn.UseVisualStyleBackColor = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // CompleteTxt
            // 
            this.CompleteTxt.AutoSize = true;
            this.CompleteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompleteTxt.ForeColor = System.Drawing.Color.Green;
            this.CompleteTxt.Location = new System.Drawing.Point(132, 63);
            this.CompleteTxt.Name = "CompleteTxt";
            this.CompleteTxt.Size = new System.Drawing.Size(0, 25);
            this.CompleteTxt.TabIndex = 5;
            this.CompleteTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(29, 68);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(419, 23);
            this.ProgressBar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qualità:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QualityCombo
            // 
            this.QualityCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QualityCombo.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QualityCombo.FormattingEnabled = true;
            this.QualityCombo.Items.AddRange(new object[] {
            "1080p - FULL HD",
            "720P - HD"});
            this.QualityCombo.Location = new System.Drawing.Point(131, 103);
            this.QualityCombo.Name = "QualityCombo";
            this.QualityCombo.Size = new System.Drawing.Size(160, 27);
            this.QualityCombo.TabIndex = 8;
            this.QualityCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // YTVideoAudioDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 136);
            this.Controls.Add(this.QualityCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CompleteTxt);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.YoutubeUrlLbl);
            this.Controls.Add(this.UrlTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YTVideoAudioDownloader";
            this.Text = "Youtube Downloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlTXT;
        private System.Windows.Forms.Label YoutubeUrlLbl;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.Label CompleteTxt;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QualityCombo;
    }
}

