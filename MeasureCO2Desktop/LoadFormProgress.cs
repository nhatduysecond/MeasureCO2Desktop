using System;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.ComponentModel;

namespace MeasureCO2Desktop
{
    public partial class LoadFormProgress : Form
    {
        string mainFolder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\MeasureCO2Desktop";
        public LoadFormProgress()
        {
            InitializeComponent();
        }
        public LoadFormProgress(string labelProgress )
        {
            InitializeComponent();
            this.labelProgress = labelProgress;
            WebClient webclient = new WebClient();
            if (!File.Exists(mainFolder))
            {
                Directory.CreateDirectory(mainFolder);
            }
            webclient.DownloadFileAsync(new Uri("https://duydang.xyz/CO2/MeasureCO2Desktop.zip"),
                mainFolder + @"\MeasureCO2Desktop.zip");
            if (File.Exists(mainFolder + @"\AutoUpdate.exe"))
            {
                webclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                webclient.DownloadFileCompleted += new AsyncCompletedEventHandler(ProgressDone);
            }
            else
            {
                MessageBox.Show("Không tìm thấy file AutoUpdate.exe, vui lòng tải lại chương trình hoặc liên hệ Duydang.xyz"
                        , "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            barLoad.Value = e.ProgressPercentage;
            
        }
        private void ProgressDone(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start(mainFolder + @"\AutoUpdate.exe");
            this.Close();
        }
        public string labelProgress { get; set; }

        private void LoadFormProgress_Load(object sender, EventArgs e)
        {
            labelLoad.Text = labelProgress;
            barLoad.Maximum = 100;
            barLoad.Minimum = 0;
        }

    }
}
