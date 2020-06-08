using AngleSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader.Utility
{
    public class InlineProgress : IProgress<double>, IDisposable
    {
        public Label completeTxt;
        public ProgressBar progressBar;
        public TextBox urlTxt;
        public Button downloadBtn;
        public InlineProgress(Label completeTxt, TextBox urlTxt, Button downloadBtn, ProgressBar progressBar)
        {
            this.completeTxt = completeTxt;
            this.urlTxt = urlTxt;
            this.downloadBtn = downloadBtn;
            this.progressBar = progressBar;
        }
        public void Dispose()
        {
            completeTxt.ForeColor = Color.Green;
            completeTxt.Text = "Download completato";
            progressBar.Visible = false;
            urlTxt.Text = "";
            urlTxt.Enabled = true;
            downloadBtn.Enabled = true;

        }

        public void Report(double progress)
        {
            urlTxt.Enabled = false;
            downloadBtn.Enabled = false;
            progressBar.Visible = true;
            completeTxt.Text = "";
            var progressPercentage = Convert.ToDouble(String.Format("{0:0.00}", progress)) * 100;
            progressBar.Value = Convert.ToInt32(progressPercentage);
        }
    }
}
