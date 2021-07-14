using System;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Diagnostics;
using System.IO;

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
            atimer.Interval = 1000*3600; //moi 1 phut thuc hien viec gi do
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
                new LoadFormProgress("Đang tải...").Show();
                //new MainMenu(true);
            }
            else
            {
                MessageBox.Show("Phiên bản hiện tại đang là phiên bản mới nhất!", "Update new version",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        //hàm kiểm tra phiê bản mới trên web
        public void checkVersion()
        {
            string ver = "0.3"; //phiên bản hiện tại, update phải thay lại
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
