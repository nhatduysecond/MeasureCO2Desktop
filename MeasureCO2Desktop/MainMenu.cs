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
using System.IO.Ports;
using System.Xml;

namespace MeasureCO2Desktop
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            
        }
        private void loadForm(object Form)
        {
            Form f = Form as Form;
            if (this.panelChildForm.Controls.Count > 0)
            {
                this.panelChildForm.Controls.RemoveAt(0);
            }
            
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelChildForm.Controls.Add(f);
            //this.panelChildForm.Tag = f;
            f.Show();
            
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            loadForm(new Control());
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            loadForm(new Chart());

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            loadForm(new Modify());
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
