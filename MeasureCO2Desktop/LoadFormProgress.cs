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
    public partial class LoadFormProgress : Form
    {
        public LoadFormProgress()
        {
            InitializeComponent();
        }
        public LoadFormProgress(string labelProgress, int valueProgress)
        {
            InitializeComponent();
            this.labelProgress = labelProgress;
            this.valueProgress = valueProgress;
            
        }
        public int valueProgress { get; set; }
        public string labelProgress { get; set; }

        private void LoadFormProgress_Load(object sender, EventArgs e)
        {
            labelLoad.Text = labelProgress;
            barLoad.Maximum = 100;
            barLoad.Minimum = 0;
            barLoad.Value = valueProgress;
            if (barLoad.Value == 100)
            {
                this.Close();
            }
        }
    }
}
