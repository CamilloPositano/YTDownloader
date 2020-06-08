using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeDownloader
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GoYTVideoAudio_Click(object sender, EventArgs e)
        {
            bool formOpen = false;
            FormCollection openForms = Application.OpenForms;
            foreach (Form form in openForms)
            {
                if (form.Name == "Form1")
                    formOpen = true;
            }
            if (!formOpen)
            {
                YTVideoAudioDownloader YTVideoAudioDownloader = new YTVideoAudioDownloader();
                YTVideoAudioDownloader.Show();
            }
        }
    }
}
