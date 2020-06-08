using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeDownloader.Constats;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public static class Helper
    {
        public static string BuildPath(Video videoInfo, IVideoStreamInfo streamInfo, Label completeText )
        {
            completeText.Text = "";
            var title = videoInfo.Title;
            foreach (var charToRemove in Consts.specialChars)
            {
                title = title.Replace(charToRemove, String.Empty);
            }
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                folderPath = folderBrowserDialog1.SelectedPath;

            if (!Directory.Exists(folderPath))
                throw new Exception("La cartella di destinazione non è stata trovata!");

            return folderPath + @"\" + title + "." + streamInfo.Container;
        }
        public static string BuildPath(Video videoInfo, IStreamInfo streamInfo, Label completeText)
        {
            completeText.Text = "";
            var title = videoInfo.Title;
            foreach (var charToRemove in Consts.specialChars)
            {
                title = title.Replace(charToRemove, String.Empty);
            }
            string folderPath = "";
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                folderPath = folderBrowserDialog1.SelectedPath;

            if (!Directory.Exists(folderPath))
                throw new Exception("La cartella di destinazione non è stata trovata!");

            return folderPath + @"\" + title + ".mp3";
        }
        public static string ManifestExtractor(string fullYoutubePath)
        {
            if (String.IsNullOrEmpty(fullYoutubePath) && String.IsNullOrWhiteSpace(fullYoutubePath))
                throw new Exception("Inserire link!");

            var splittedPath = fullYoutubePath.Split('=');

            return splittedPath[1];
        }
    }
}
