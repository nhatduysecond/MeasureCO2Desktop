using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace MeasureCO2Desktop
{
    public partial class Modify : Form
    {
        bool canUpdate;
        public Modify()
        {
            InitializeComponent();
            System.Windows.Forms.Timer atimer = new System.Windows.Forms.Timer();
            atimer.Tick += new EventHandler(OnTimeEvent); //chay hàm thực hiện OnTimeEvent
            atimer.Interval = 1000*60; //moi 15 ngày thuc hien viec gi do
            atimer.Start();
            checkVersion();
        }
        //hàm khởi chạy cho timer
        private void OnTimeEvent(object sender, EventArgs e)
        {
            checkVersion();
        }
        //update click button function
        private void setServer_Click(object sender, EventArgs e)
        {
            if (canUpdate == true)
            {

                WebClient webclient = new WebClient();
                string downloadFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                webclient.DownloadFileAsync(new Uri("https://duydang.xyz/CO2/MeasureCO2Desktop.zip"), @"C:\\Users\nhatd\Downloads\MeasureCO2Desktop.zip");
                webclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
            }
            else
            {
                MessageBox.Show("Phiên bản hiện tại đang là phiên bản mới nhất!", "Update new version",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Form loadForm = new LoadFormProgress("Đang tải...",e.ProgressPercentage);
            
            //Form load = new LoadFormProgress();
            loadForm.Show();
            //loadForm.ShowDialog();
        }
        //hàm kiểm tra phiê bản mới trên web
        public void checkVersion()
        {
            string ver = "0.1"; //phiên bản hiện tại, update phải thay lại
            labelOldVersion.Text = ver;
            string url = "https://duydang.xyz/CO2/CO2DesktopVersion.xml"; //nơi check phiên bản
            XmlTextReader reader = new XmlTextReader(url); //đọc file xml trên web
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text) //đọc các dòng text
                {
                    string newVer = reader.Value; //đọc giá trị giữa các element <element>value</element>
                    labelNewVersion.Text = newVer;
                    if (!string.Equals(ver, newVer))
                    {
                        MessageBox.Show("Có phiên bản mới, hãy bấm nút Update để cập nhật!","Update new version",
                            MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        canUpdate = true;
                    }
                    else
                    {
                        canUpdate = false;
                    }
                }

            }
        }
        public string ver { get; set; }
        public string newVer { get; set; }
    }
}
