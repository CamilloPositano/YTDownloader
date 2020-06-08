using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Utility;
using YoutubeExplode;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class YTVideoAudioDownloader : Form
    {
        public YTVideoAudioDownloader()
        {
            InitializeComponent();
            ProgressBar.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void DownloadBtn_Click(object sender, EventArgs e)
        {
            CompleteTxt.ForeColor = Color.Orange;
            CompleteTxt.Text = "Loading";
            UrlTXT.Enabled = false;
            DownloadBtn.Enabled = false;
            
            try
            {
                var youtube = new YoutubeClient();

                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(Helper.ManifestExtractor(UrlTXT.Text));

                var streamInfo = streamManifest.GetMuxed().WithHighestVideoQuality();

                if (streamInfo != null)
                {
                    var stream = await youtube.Videos.Streams.GetAsync(streamInfo);
                    var videoInfo = await youtube.Videos.GetAsync(UrlTXT.Text);

                    var destination = Helper.BuildPath(videoInfo, streamInfo, CompleteTxt);
                    UrlTXT.Enabled = true;
                    DownloadBtn.Enabled = true;
                    using (var progress = new InlineProgress(CompleteTxt,UrlTXT, DownloadBtn, ProgressBar))
                        await youtube.Videos.Streams.DownloadAsync(streamInfo, destination, progress);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                UrlTXT.Enabled = true;
                CompleteTxt.Text = "";
                DownloadBtn.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
