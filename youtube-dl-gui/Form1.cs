using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace youtube_dl_gui
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            QualityDropDown.SelectedIndex = 0;
            FPSDropDown.SelectedIndex = 0;
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string URL = URLTextBox.Text;
            string dlPath = downloadPathTxtBox.Text.Replace('\\','/');
            string height = QualityDropDown.Text.Substring(0, QualityDropDown.Text.LastIndexOf("p"));
            string fps = FPSDropDown.Text;

            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-o " + dlPath + "/%(title)s.%(ext)s -f bestvideo[height<=?" + height + "][fps<=?" + fps + "]+bestaudio/best -i --ignore-config --hls-prefer-native " + URL;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (Process p = Process.Start(startInfo))
                {
                    p.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }

        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                downloadPathTxtBox.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-U";

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (Process p = Process.Start(startInfo))
                {
                    p.WaitForExit();
                }
            }
            catch
            {
                // Log error.
            }
        }
    }
}
