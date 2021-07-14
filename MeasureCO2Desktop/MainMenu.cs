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

        int mov;
        int movX;
        int movY;
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
            btnControl.BackColor = Color.FromArgb(46, 54, 73);
            btnChart.BackColor = Color.FromArgb(24, 30, 54);
            btnInfo.BackColor = Color.FromArgb(24, 30, 54);
            btnModify.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Top = btnControl.Top;
            pnlNav.Height = btnControl.Height;
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
        #region button
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
            btnControl.BackColor = Color.FromArgb(46, 54, 73); ;
            btnChart.BackColor = Color.FromArgb(24, 30, 54);
            btnInfo.BackColor = Color.FromArgb(24, 30, 54);
            btnModify.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnControl.Height;
            pnlNav.Top = btnControl.Top;
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
            btnControl.BackColor = Color.FromArgb(24, 30, 54);
            btnChart.BackColor = Color.FromArgb(46, 54, 73); ;
            btnInfo.BackColor = Color.FromArgb(24, 30, 54);
            btnModify.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnChart.Height;
            pnlNav.Top = btnChart.Top;
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
            btnControl.BackColor = Color.FromArgb(24, 30, 54);
            btnChart.BackColor = Color.FromArgb(24, 30, 54);
            btnInfo.BackColor = Color.FromArgb(24, 30, 54);
            btnModify.BackColor = Color.FromArgb(46, 54, 73); ;
            pnlNav.Height = btnModify.Height;
            pnlNav.Top = btnModify.Top;
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
            btnControl.BackColor = Color.FromArgb(24, 30, 54);
            btnChart.BackColor = Color.FromArgb(24, 30, 54);
            btnInfo.BackColor = Color.FromArgb(46, 54, 73); ;
            btnModify.BackColor = Color.FromArgb(24, 30, 54);
            pnlNav.Height = btnInfo.Height;
            pnlNav.Top = btnInfo.Top;
            info.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
            control.Close();
            chart.Close();
            info.Close();
            modify.Close();
        }
        #endregion button
        //tao title bar co the di chuyen cho panel
        #region panel to titlebar can move form
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        #endregion panel to titlebar can move form
    }
}
