using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MeasureCO2Desktop
{
    public partial class MainMenu : Form
    {
        Form control = new Control();
        Form chart = new Chart();
        Form modify = new Modify();
        Form info = new Info();
        public MainMenu()
        {
            InitializeComponent();
            //di chuyen file den thu muc dinh truoc
            string fullPath = Directory.GetCurrentDirectory();
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\MeasureCO2Desktop";
            if (fullPath != filePath)
            {
                string[] files = Directory.GetFiles(fullPath);
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string deshFile = Path.Combine(filePath, fileName);
                    File.Copy(file, deshFile, true);
                }
            }
            //cau hinh cac button luc vua mo chuong trinh
            control.TopLevel = false;
            control.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(control);
            btnControl.BackColor = SystemColors.Highlight;
            btnChart.BackColor = Color.FromArgb(11, 7, 17);
            btnInfo.BackColor = Color.FromArgb(11, 7, 17);
            btnModify.BackColor = Color.FromArgb(11, 7, 17);
            control.Show();
        }

        public MainMenu(bool shutdown)
        {
            InitializeComponent();
            if (shutdown==true)
            {
                this.Close();
            }
        }

        private void loadForm(object Form)
        {
            Form f = Form as Form;
            if (panelChildForm.Controls.Count > 0)
            {
                panelChildForm.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(f);
            //this.panelChildForm.Tag = f;
            f.Show();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            //loadForm(new Control());
            if (panelChildForm.Controls.Count > 0)
            {
                chart.Hide();
                modify.Hide();
                info.Hide();
            }
            control.TopLevel = false;
            control.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(control);
            btnControl.BackColor = SystemColors.Highlight;
            btnChart.BackColor = Color.FromArgb(11, 7, 17);
            btnInfo.BackColor = Color.FromArgb(11, 7, 17);
            btnModify.BackColor = Color.FromArgb(11, 7, 17);
            control.Show();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            //loadForm(new Chart());
            if (panelChildForm.Controls.Count > 0)
            {
                control.Hide();
                modify.Hide();
                info.Hide();
            }
            chart.TopLevel = false;
            chart.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(chart);
            btnControl.BackColor = Color.FromArgb(11, 7, 17);
            btnChart.BackColor = SystemColors.Highlight;
            btnInfo.BackColor = Color.FromArgb(11, 7, 17);
            btnModify.BackColor = Color.FromArgb(11, 7, 17);
            chart.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //loadForm(new Modify());
            if (panelChildForm.Controls.Count > 0)
            {
                chart.Hide();
                control.Hide();
                info.Hide();
            }
            modify.TopLevel = false;
            modify.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(modify);
            btnControl.BackColor = Color.FromArgb(11, 7, 17);
            btnChart.BackColor = Color.FromArgb(11, 7, 17);
            btnInfo.BackColor = Color.FromArgb(11, 7, 17);
            btnModify.BackColor = SystemColors.Highlight;
            modify.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (panelChildForm.Controls.Count > 0)
            {
                chart.Hide();
                control.Hide();
                modify.Hide();
            }
            info.TopLevel = false;
            info.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(info);
            btnControl.BackColor = Color.FromArgb(11, 7, 17);
            btnChart.BackColor = Color.FromArgb(11, 7, 17);
            btnInfo.BackColor = SystemColors.Highlight;
            btnModify.BackColor = Color.FromArgb(11, 7, 17);
            info.Show();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
