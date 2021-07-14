
namespace MeasureCO2Desktop
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelSideLeft = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelSideLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 570);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(808, 30);
            this.panelBottom.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.btnX);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(808, 25);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // panelSideLeft
            // 
            this.panelSideLeft.AutoScroll = true;
            this.panelSideLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelSideLeft.Controls.Add(this.pnlNav);
            this.panelSideLeft.Controls.Add(this.btnInfo);
            this.panelSideLeft.Controls.Add(this.btnModify);
            this.panelSideLeft.Controls.Add(this.btnChart);
            this.panelSideLeft.Controls.Add(this.btnControl);
            this.panelSideLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideLeft.Location = new System.Drawing.Point(0, 25);
            this.panelSideLeft.Name = "panelSideLeft";
            this.panelSideLeft.Size = new System.Drawing.Size(200, 545);
            this.panelSideLeft.TabIndex = 2;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 100);
            this.pnlNav.TabIndex = 0;
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnInfo.Location = new System.Drawing.Point(0, 135);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(200, 45);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Thông tin phần mềm";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModify.FlatAppearance.BorderSize = 0;
            this.btnModify.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnModify.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnModify.Location = new System.Drawing.Point(0, 90);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(200, 45);
            this.btnModify.TabIndex = 2;
            this.btnModify.Text = "Cấu hình";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnChart
            // 
            this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnChart.Location = new System.Drawing.Point(0, 45);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(200, 45);
            this.btnChart.TabIndex = 1;
            this.btnChart.Text = "Biểu đồ";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnControl
            // 
            this.btnControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnControl.FlatAppearance.BorderSize = 0;
            this.btnControl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnControl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(240)))));
            this.btnControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControl.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnControl.Location = new System.Drawing.Point(0, 0);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(200, 45);
            this.btnControl.TabIndex = 0;
            this.btnControl.Text = "Điều khiển";
            this.btnControl.UseVisualStyleBackColor = false;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.panelChildForm.Location = new System.Drawing.Point(228, 61);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(568, 442);
            this.panelChildForm.TabIndex = 3;
            // 
            // btnX
            // 
            this.btnX.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(783, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(25, 25);
            this.btnX.TabIndex = 0;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(808, 600);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panelTop.ResumeLayout(false);
            this.panelSideLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelSideLeft;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Button btnX;
    }
}