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
        public string[] qualities = { "4320", "2160", "1440", "1080", "720", "480", "360", "240", "144" };
        public string[] framerates = { "60", "50", "48", "30", "24" };
        string format;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            QualityDropDown.SelectedIndex = 0;
            FPSDropDown.SelectedIndex = 0;
        }

        private void buildFormat(int qualSkip,int fpsSkip)
        {
            string[] qualitiesMin = qualities.Skip(qualSkip).ToArray();
            string[] frameratesMin = framerates.Skip(fpsSkip).ToArray();
            format = "-f ";
            foreach (string quality in qualitiesMin)
            {
                foreach (string framerate in frameratesMin)
                {
                    format += "bestvideo[height=?" + quality + "][fps=?" + framerate + "]+bestaudio/";
                }
            }
            format += "best";
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            string URL = URLTextBox.Text;
            string dlPath = downloadPathTxtBox.Text.Replace('\\','/');
            int height = Convert.ToInt16(QualityDropDown.Text.Substring(0, QualityDropDown.Text.LastIndexOf("p")));
            int fps = Convert.ToInt16(FPSDropDown.Text);
            

            if (height == 4320 && fps == 60)
            {
                buildFormat(0, 0);
            }
            else if(height == 4320 && fps == 30)
            {
                buildFormat(0, 3);
            }
            else if (height == 2160 && fps == 60)
            {
                buildFormat(1, 0);
            }
            else if (height == 2160 && fps == 30)
            {
                buildFormat(1, 3);
            }
            else if (height == 1440 && fps == 60)
            {
                buildFormat(2, 0);
            }
            else if (height == 1440 && fps == 30)
            {
                buildFormat(2, 3);
            }
            else if (height == 1080 && fps == 60)
            {
                buildFormat(3, 0);
            }
            else if (height == 1080 && fps == 30)
            {
                buildFormat(3, 3);
            }
            else if (height == 720 && fps == 60)
            {
                buildFormat(4, 0);
            }
            else if (height == 720 && fps == 30)
            {
                buildFormat(4, 3);
            }
            else if (height == 480)
            {
                buildFormat(5, 3);
            }
            else if (height == 360)
            {
                buildFormat(6, 3);
            }
            else if (height == 240)
            {
                buildFormat(7, 3);
            }
            else if (height == 144)
            {
                buildFormat(8, 3);
            }
            else
            {
                format = "-f bestvideo+bestaudio/best";
            }

            // Use ProcessStartInfo class.
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = "youtube-dl.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "-o "+dlPath+"/%(title)s.%(ext)s "+format+" -i --ignore-config --hls-prefer-native "+URL;
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using-statement will close.
                using (Process p = Process.Start(startInfo))
                {
                    p.WaitForExit();
                }
                format = "";
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
