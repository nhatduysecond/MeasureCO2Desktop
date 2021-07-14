
namespace MeasureCO2Desktop
{
    partial class Control
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelSensor = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelMQTT = new System.Windows.Forms.Label();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textPpm = new System.Windows.Forms.TextBox();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelMachine);
            this.panel1.Controls.Add(this.labelSensor);
            this.panel1.Controls.Add(this.labelDevice);
            this.panel1.Controls.Add(this.labelMQTT);
            this.panel1.Controls.Add(this.labelNetwork);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 100);
            this.panel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(203, 63);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(65, 13);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Đang load...";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.ForeColor = System.Drawing.Color.White;
            this.labelMachine.Location = new System.Drawing.Point(440, 63);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(96, 13);
            this.labelMachine.TabIndex = 10;
            this.labelMachine.Text = "Đợi kết nối mạng...";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.ForeColor = System.Drawing.Color.White;
            this.labelSensor.Location = new System.Drawing.Point(440, 37);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(96, 13);
            this.labelSensor.TabIndex = 9;
            this.labelSensor.Text = "Đợi kết nối mạng...";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.ForeColor = System.Drawing.Color.White;
            this.labelDevice.Location = new System.Drawing.Point(440, 9);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(96, 13);
            this.labelDevice.TabIndex = 8;
            this.labelDevice.Text = "Đợi kết nối mạng...";
            // 
            // labelMQTT
            // 
            this.labelMQTT.AutoSize = true;
            this.labelMQTT.ForeColor = System.Drawing.Color.White;
            this.labelMQTT.Location = new System.Drawing.Point(203, 37);
            this.labelMQTT.Name = "labelMQTT";
            this.labelMQTT.Size = new System.Drawing.Size(96, 13);
            this.labelMQTT.TabIndex = 7;
            this.labelMQTT.Text = "Đợi kết nối mạng...";
            // 
            // labelNetwork
            // 
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.ForeColor = System.Drawing.Color.White;
            this.labelNetwork.Location = new System.Drawing.Point(203, 9);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(77, 13);
            this.labelNetwork.TabIndex = 6;
            this.labelNetwork.Text = "Đang kết nối...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chế độ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(329, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái máy quạt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(329, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái cảm biến:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(329, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái thiết bị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái kết nối MQTT Broker:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái kết nối mạng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 342);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Dữ liệu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textData
            // 
            this.textData.AcceptsReturn = true;
            this.textData.HideSelection = false;
            this.textData.Location = new System.Drawing.Point(0, 19);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.ReadOnly = true;
            this.textData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textData.ShortcutsEnabled = false;
            this.textData.Size = new System.Drawing.Size(200, 323);
            this.textData.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(73)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textPpm);
            this.panel3.Controls.Add(this.btnOff);
            this.panel3.Controls.Add(this.btnAuto);
            this.panel3.Controls.Add(this.btnSet);
            this.panel3.Controls.Add(this.btnOn);
            this.panel3.Controls.Add(this.btnManual);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 342);
            this.panel3.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(292, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Auto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(63, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Manual";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(143, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn chế độ";
            // 
            // textPpm
            // 
            this.textPpm.Location = new System.Drawing.Point(256, 92);
            this.textPpm.Name = "textPpm";
            this.textPpm.Size = new System.Drawing.Size(100, 20);
            this.textPpm.TabIndex = 2;
            this.textPpm.Text = "Nhập ppm CO2";
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(87, 92);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(75, 23);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Tắt";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(178, 19);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(256, 118);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(100, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(6, 92);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(75, 23);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Bật";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(97, 19);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(75, 23);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(568, 442);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Control";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Label labelMQTT;
        private System.Windows.Forms.Label labelNetwork;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textPpm;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnManual;
    }
}