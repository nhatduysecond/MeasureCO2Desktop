using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeasureCO2Desktop
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
            Modify modify = new Modify();
            label2.Text = "Version " + modify.ver;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://duydang.xyz");
        }
    }
}
