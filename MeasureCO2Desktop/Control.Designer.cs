
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
            this.labelLight = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelSensorBui = new System.Windows.Forms.Label();
            this.labelSensor = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.labelMQTT = new System.Windows.Forms.Label();
            this.labelNetwork = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textData = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textDataBuiPM10 = new System.Windows.Forms.TextBox();
            this.textDataBuiPM25 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSetPM10 = new System.Windows.Forms.TextBox();
            this.textSetPM25 = new System.Windows.Forms.TextBox();
            this.textPpm = new System.Windows.Forms.TextBox();
            this.btnSetPM10 = new System.Windows.Forms.Button();
            this.btnLightOff = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnSetPM25 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnLightOn = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelLight);
            this.panel1.Controls.Add(this.labelMachine);
            this.panel1.Controls.Add(this.labelSensorBui);
            this.panel1.Controls.Add(this.labelSensor);
            this.panel1.Controls.Add(this.labelDevice);
            this.panel1.Controls.Add(this.labelMQTT);
            this.panel1.Controls.Add(this.labelNetwork);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 123);
            this.panel1.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.Color.White;
            this.labelStatus.Location = new System.Drawing.Point(231, 83);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(78, 16);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Đang load...";
            // 
            // labelLight
            // 
            this.labelLight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLight.AutoSize = true;
            this.labelLight.ForeColor = System.Drawing.Color.White;
            this.labelLight.Location = new System.Drawing.Point(613, 83);
            this.labelLight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(115, 16);
            this.labelLight.TabIndex = 10;
            this.labelLight.Text = "Đợi kết nối mạng...";
            // 
            // labelMachine
            // 
            this.labelMachine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMachine.AutoSize = true;
            this.labelMachine.ForeColor = System.Drawing.Color.White;
            this.labelMachine.Location = new System.Drawing.Point(613, 59);
            this.labelMachine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(115, 16);
            this.labelMachine.TabIndex = 10;
            this.labelMachine.Text = "Đợi kết nối mạng...";
            // 
            // labelSensorBui
            // 
            this.labelSensorBui.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSensorBui.AutoSize = true;
            this.labelSensorBui.ForeColor = System.Drawing.Color.White;
            this.labelSensorBui.Location = new System.Drawing.Point(613, 35);
            this.labelSensorBui.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensorBui.Name = "labelSensorBui";
            this.labelSensorBui.Size = new System.Drawing.Size(115, 16);
            this.labelSensorBui.TabIndex = 9;
            this.labelSensorBui.Text = "Đợi kết nối mạng...";
            // 
            // labelSensor
            // 
            this.labelSensor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSensor.AutoSize = true;
            this.labelSensor.ForeColor = System.Drawing.Color.White;
            this.labelSensor.Location = new System.Drawing.Point(613, 11);
            this.labelSensor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(115, 16);
            this.labelSensor.TabIndex = 9;
            this.labelSensor.Text = "Đợi kết nối mạng...";
            // 
            // labelDevice
            // 
            this.labelDevice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDevice.AutoSize = true;
            this.labelDevice.ForeColor = System.Drawing.Color.White;
            this.labelDevice.Location = new System.Drawing.Point(231, 59);
            this.labelDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(115, 16);
            this.labelDevice.TabIndex = 8;
            this.labelDevice.Text = "Đợi kết nối mạng...";
            // 
            // labelMQTT
            // 
            this.labelMQTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMQTT.AutoSize = true;
            this.labelMQTT.ForeColor = System.Drawing.Color.White;
            this.labelMQTT.Location = new System.Drawing.Point(231, 35);
            this.labelMQTT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMQTT.Name = "labelMQTT";
            this.labelMQTT.Size = new System.Drawing.Size(115, 16);
            this.labelMQTT.TabIndex = 7;
            this.labelMQTT.Text = "Đợi kết nối mạng...";
            // 
            // labelNetwork
            // 
            this.labelNetwork.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelNetwork.AutoSize = true;
            this.labelNetwork.ForeColor = System.Drawing.Color.White;
            this.labelNetwork.Location = new System.Drawing.Point(231, 11);
            this.labelNetwork.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNetwork.Name = "labelNetwork";
            this.labelNetwork.Size = new System.Drawing.Size(90, 16);
            this.labelNetwork.TabIndex = 6;
            this.labelNetwork.Text = "Đang kết nối...";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Chế độ:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(439, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 4;
            this.label13.Text = "Trạng thái đèn:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(439, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trạng thái máy quạt:";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(439, 35);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "Trạng thái cảm biến bụi:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(439, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái cảm biến CO2:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái thiết bị:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Trạng thái kết nối MQTT Broker:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trạng thái kết nối mạng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textDataBuiPM10);
            this.panel2.Controls.Add(this.textData);
            this.panel2.Controls.Add(this.textDataBuiPM25);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 421);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Maroon;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Data CO2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textData
            // 
            this.textData.AcceptsReturn = true;
            this.textData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textData.HideSelection = false;
            this.textData.Location = new System.Drawing.Point(0, 25);
            this.textData.Margin = new System.Windows.Forms.Padding(4);
            this.textData.Multiline = true;
            this.textData.Name = "textData";
            this.textData.ReadOnly = true;
            this.textData.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textData.ShortcutsEnabled = false;
            this.textData.Size = new System.Drawing.Size(75, 396);
            this.textData.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(7)))), ((int)(((byte)(27)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.textSetPM10);
            this.panel3.Controls.Add(this.textSetPM25);
            this.panel3.Controls.Add(this.textPpm);
            this.panel3.Controls.Add(this.btnSetPM10);
            this.panel3.Controls.Add(this.btnLightOff);
            this.panel3.Controls.Add(this.btnOff);
            this.panel3.Controls.Add(this.btnSetPM25);
            this.panel3.Controls.Add(this.btnAuto);
            this.panel3.Controls.Add(this.btnLightOn);
            this.panel3.Controls.Add(this.btnSet);
            this.panel3.Controls.Add(this.btnOn);
            this.panel3.Controls.Add(this.btnManual);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(250, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 421);
            this.panel3.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Maroon;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(166, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Bụi PM10";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(83, 4);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Bụi PM2.5";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(356, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Auto";
            // 
            // textDataBuiPM10
            // 
            this.textDataBuiPM10.AcceptsReturn = true;
            this.textDataBuiPM10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDataBuiPM10.HideSelection = false;
            this.textDataBuiPM10.Location = new System.Drawing.Point(166, 25);
            this.textDataBuiPM10.Margin = new System.Windows.Forms.Padding(4);
            this.textDataBuiPM10.Multiline = true;
            this.textDataBuiPM10.Name = "textDataBuiPM10";
            this.textDataBuiPM10.ReadOnly = true;
            this.textDataBuiPM10.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textDataBuiPM10.ShortcutsEnabled = false;
            this.textDataBuiPM10.Size = new System.Drawing.Size(75, 396);
            this.textDataBuiPM10.TabIndex = 0;
            // 
            // textDataBuiPM25
            // 
            this.textDataBuiPM25.AcceptsReturn = true;
            this.textDataBuiPM25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textDataBuiPM25.HideSelection = false;
            this.textDataBuiPM25.Location = new System.Drawing.Point(83, 25);
            this.textDataBuiPM25.Margin = new System.Windows.Forms.Padding(4);
            this.textDataBuiPM25.Multiline = true;
            this.textDataBuiPM25.Name = "textDataBuiPM25";
            this.textDataBuiPM25.ReadOnly = true;
            this.textDataBuiPM25.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textDataBuiPM25.ShortcutsEnabled = false;
            this.textDataBuiPM25.Size = new System.Drawing.Size(75, 396);
            this.textDataBuiPM25.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(129, 207);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 16);
            this.label14.TabIndex = 4;
            this.label14.Text = "Đèn";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(127, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Quạt";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(103, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Chọn chế độ";
            // 
            // textSetPM10
            // 
            this.textSetPM10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSetPM10.Location = new System.Drawing.Point(292, 237);
            this.textSetPM10.Margin = new System.Windows.Forms.Padding(4);
            this.textSetPM10.Name = "textSetPM10";
            this.textSetPM10.Size = new System.Drawing.Size(163, 22);
            this.textSetPM10.TabIndex = 2;
            this.textSetPM10.Text = "Nhập nồng độ bụi PM10";
            // 
            // textSetPM25
            // 
            this.textSetPM25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textSetPM25.Location = new System.Drawing.Point(292, 169);
            this.textSetPM25.Margin = new System.Windows.Forms.Padding(4);
            this.textSetPM25.Name = "textSetPM25";
            this.textSetPM25.Size = new System.Drawing.Size(163, 22);
            this.textSetPM25.TabIndex = 2;
            this.textSetPM25.Text = "Nhập nồng độ bụi PM2.5";
            // 
            // textPpm
            // 
            this.textPpm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textPpm.Location = new System.Drawing.Point(292, 98);
            this.textPpm.Margin = new System.Windows.Forms.Padding(4);
            this.textPpm.Name = "textPpm";
            this.textPpm.Size = new System.Drawing.Size(163, 22);
            this.textPpm.TabIndex = 2;
            this.textPpm.Text = "Nhập ppm CO2";
            // 
            // btnSetPM10
            // 
            this.btnSetPM10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetPM10.Location = new System.Drawing.Point(292, 269);
            this.btnSetPM10.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPM10.Name = "btnSetPM10";
            this.btnSetPM10.Size = new System.Drawing.Size(163, 28);
            this.btnSetPM10.TabIndex = 0;
            this.btnSetPM10.Text = "Set";
            this.btnSetPM10.UseVisualStyleBackColor = true;
            this.btnSetPM10.Click += new System.EventHandler(this.btnSetPM10_Click);
            // 
            // btnLightOff
            // 
            this.btnLightOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLightOff.Location = new System.Drawing.Point(146, 227);
            this.btnLightOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(100, 28);
            this.btnLightOff.TabIndex = 1;
            this.btnLightOff.Text = "Tắt";
            this.btnLightOff.UseVisualStyleBackColor = true;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // btnOff
            // 
            this.btnOff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOff.Location = new System.Drawing.Point(146, 159);
            this.btnOff.Margin = new System.Windows.Forms.Padding(4);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(100, 28);
            this.btnOff.TabIndex = 1;
            this.btnOff.Text = "Tắt";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnSetPM25
            // 
            this.btnSetPM25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSetPM25.Location = new System.Drawing.Point(292, 201);
            this.btnSetPM25.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetPM25.Name = "btnSetPM25";
            this.btnSetPM25.Size = new System.Drawing.Size(163, 28);
            this.btnSetPM25.TabIndex = 0;
            this.btnSetPM25.Text = "Set";
            this.btnSetPM25.UseVisualStyleBackColor = true;
            this.btnSetPM25.Click += new System.EventHandler(this.btnSetPM25_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAuto.Location = new System.Drawing.Point(146, 98);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(100, 28);
            this.btnAuto.TabIndex = 1;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnLightOn
            // 
            this.btnLightOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLightOn.Location = new System.Drawing.Point(38, 227);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(4);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(100, 28);
            this.btnLightOn.TabIndex = 0;
            this.btnLightOn.Text = "Bật";
            this.btnLightOn.UseVisualStyleBackColor = true;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSet.Location = new System.Drawing.Point(292, 130);
            this.btnSet.Margin = new System.Windows.Forms.Padding(4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(163, 28);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnOn
            // 
            this.btnOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOn.Location = new System.Drawing.Point(38, 159);
            this.btnOn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(100, 28);
            this.btnOn.TabIndex = 0;
            this.btnOn.Text = "Bật";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnManual
            // 
            this.btnManual.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManual.Location = new System.Drawing.Point(38, 98);
            this.btnManual.Margin = new System.Windows.Forms.Padding(4);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(100, 28);
            this.btnManual.TabIndex = 0;
            this.btnManual.Text = "Manual";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(7)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(757, 544);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textDataBuiPM25;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textDataBuiPM10;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textSetPM10;
        private System.Windows.Forms.TextBox textSetPM25;
        private System.Windows.Forms.Button btnSetPM10;
        private System.Windows.Forms.Button btnLightOff;
        private System.Windows.Forms.Button btnSetPM25;
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Label labelSensorBui;
        private System.Windows.Forms.Label label15;
    }
}