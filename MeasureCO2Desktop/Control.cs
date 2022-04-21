using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.IO;

namespace MeasureCO2Desktop
{
    public partial class Control : Form
    {
        MqttClient client;
        string clientID;
        bool checkData = false;
        public Control()
        {
            InitializeComponent();
            ketnoi();
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnSet.Enabled = false;
            btnSetPM10.Enabled = false;
            btnSetPM25.Enabled = false;
            textPpm.Enabled = false;
            textSetPM10.Enabled = false;
            textSetPM25.Enabled = false ;

            //timer
            System.Windows.Forms.Timer atimer = new System.Windows.Forms.Timer();
            atimer.Tick += new EventHandler(OnTimeEvent); //chay hàm thực hiện OnTimeEvent
            atimer.Interval = 15000; //moi 15s thuc hien viec gi do
            atimer.Start();
        }
        //hàm khi chay timer
        private void OnTimeEvent(object sender, EventArgs e)
        {
            //neu trong 15s ko nhan duoc tin hieu data tu thiet bi se tu doi label trang thai thiet bi thanh offline
            if (checkData == false)
            {
                labelDevice.Text = "Offline";
                labelMachine.Text = "Offline";
                labelLight.Text = "Offline";
                labelSensor.Text = "Offline";
                labelSensorBui.Text = "Offline";
                labelDevice.ForeColor = Color.Red;
                labelMachine.ForeColor = Color.Red;
                labelSensor.ForeColor = Color.Red;
                labelSensorBui.ForeColor = Color.Red;
                labelLight.ForeColor = Color.Red;
            }
            checkData = false;
        }
        
        //hàm kết nối mạng và mqtt broker
        private void ketnoi()
        {
            bool networkStatus = NetworkInterface.GetIsNetworkAvailable(); //hàm check kết nối mạng wifi/internet
            
            //thong tin ket noi mqtt broker
            string mqtt_server = "broker.hivemq.com";   //broker.emqx.io 
            //string mqtt_server = "broker.emqx.io";
            var mqtt_port = Convert.ToInt32(1883);
            string[] topic = { "CO2Measurement/statusSensor",
                "CO2Measurement/statusSensorBui",
                "CO2Measurement/statusMachine",
                "CO2Measurement/statusLight",
                "CO2Measurement/statusDevice",
                "CO2Measurement/statusMode",
                "CO2Measurement/Data",
                "CO2Measurement/PM10",
                "CO2Measurement/PM2.5"};
            byte[] qosLevel = { 2, 2, 2, 2, 2, 2, 2, 2, 2 };
            //bat dau ket noi mang
            if (networkStatus == true)
            {
                labelNetwork.Text = "Online";
                labelNetwork.ForeColor = Color.Green;
                try //ket noi mqtt broker
                {
                    client = new MqttClient(mqtt_server, mqtt_port, false, null, null, MqttSslProtocols.None);
                    clientID = "Desktop";
                    client.Connect(clientID);
                    client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                    client.Subscribe(topic, qosLevel);
                    //khi đã ket noi vao mqtt broker
                    if (client.IsConnected)
                    {
                        labelMQTT.Text = "Online";
                        labelMQTT.ForeColor = Color.Green;
                        client.Publish("CO2Measurement/stateNow", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    }
                }
                //ko ket noi duoc mqtt broker
                catch
                {
                    labelMQTT.Text = "Offline";
                    labelMQTT.ForeColor = Color.Red;
                    btnAuto.Enabled = false;
                    btnManual.Enabled = false;
                }
            }
            //khi ko co internet
            else
            {
                labelNetwork.Text = "Offline";
                labelNetwork.ForeColor = Color.Red;
                MessageBox.Show("Không có kết nối mạng");
            }
        }
        //function when receive messsage
        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if(this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    string ReceiveMessage = Encoding.UTF8.GetString(e.Message);
                    string ReceiveTopic = e.Topic;
                    stateNow(ReceiveMessage, ReceiveTopic);
                    string[] datas, dataPM25, dataPM10;
                    if (e.Topic == "CO2Measurement/Data")
                    {
                        textData.AppendText(ReceiveMessage + Environment.NewLine);
                        checkData = true; //kiểm tra system có hoạt động hay ko ở hàm on timer
                        datas = new string[] { ReceiveMessage };
                        file(datas, 0);
                    }
                    if (e.Topic == "CO2Measurement/PM2.5")
                    {
                        textDataBuiPM25.AppendText(ReceiveMessage + Environment.NewLine);
                        checkData = true;
                        dataPM25 = new string[] { ReceiveMessage };
                        file(dataPM25, 1);
                    }
                    if (e.Topic == "CO2Measurement/PM10")
                    {
                        textDataBuiPM10.AppendText(ReceiveMessage + Environment.NewLine);
                        checkData = true;
                        dataPM10 = new string[] { ReceiveMessage };
                        file(dataPM10, 2);
                    }
                });
            }
            else
            {
                return;
            }
            
        }
        //hàm đổi trạng thái label nằm trong callback
        private void stateNow(string ReceiveMessage, string e)
        {
            //kiem tra trang thai luc vua khoi dong
            if (e == "CO2Measurement/statusDevice")
            {
                if (ReceiveMessage == "1")
                {
                    labelDevice.Text = "Online";
                    labelDevice.ForeColor = Color.Green;
                    checkData = true;
                }
                else
                {
                    labelDevice.Text = "Offline";
                    labelDevice.ForeColor = Color.Red;
                }
            }
            if (e == "CO2Measurement/statusSensor")
            {
                if (ReceiveMessage == "1")
                {
                    labelSensor.Text = "Online";
                    labelSensor.ForeColor = Color.Green;
                }
                else
                {
                    labelSensor.Text = "Offline";
                    labelSensor.ForeColor = Color.Red;
                }
            }
            if(e == "CO2Measurement/statusSensorBui")
            {
                if(ReceiveMessage == "1")
                {
                    labelSensorBui.Text = "Online";
                    labelSensorBui.ForeColor = Color.Green;
                }
                else
                {
                    labelSensorBui.Text = "Offline";
                    labelSensorBui.ForeColor = Color.Red;
                }
            }
            if (e == "CO2Measurement/statusMachine")
            {
                if (ReceiveMessage == "1")
                {
                    labelMachine.Text = "Online";
                    labelMachine.ForeColor = Color.Green;
                }
                else
                {
                    labelMachine.Text = "Offline";
                    labelMachine.ForeColor = Color.Red;
                }
            }
            if (e == "CO2Measurement/statusLight")
            {
                if (ReceiveMessage == "1")
                {
                    labelLight.Text = "Online";
                    labelLight.ForeColor = Color.Green;
                }
                else
                {
                    labelLight.Text = "Offline";
                    labelLight.ForeColor = Color.Red;
                }
            }
            if (e == "CO2Measurement/statusMode")
            {
                if (ReceiveMessage == "1")
                {
                    labelStatus.Text = "Manual";
                    labelStatus.ForeColor = Color.Yellow;
                }
                else
                {
                    labelStatus.Text = "Auto";
                    labelStatus.ForeColor = Color.Green;
                }
            }
            DisableButton();
        }
        //cac ha lien quan đến nút nhấn
        #region button
        private void DisableButton()
        {
            if (labelStatus.Text == "Auto")
            {
                btnAuto.Enabled = false;
                btnManual.Enabled = true;
                btnOn.Enabled = false;
                btnOff.Enabled = false;
                btnLightOff.Enabled = false;
                btnLightOn.Enabled = false;
                textPpm.Enabled = true;
                textSetPM10.Enabled = true;
                textSetPM25.Enabled = true;
                btnSet.Enabled = true;
                btnSetPM10.Enabled = true;
                btnSetPM25.Enabled = true;
            }
            if (labelStatus.Text == "Manual")
            {
                btnAuto.Enabled = true;
                btnManual.Enabled = false;
                btnOn.Enabled = true;
                btnOff.Enabled = true;
                btnLightOn.Enabled= true;
                btnLightOff.Enabled = true;
                btnSet.Enabled = false;
                textPpm.Enabled = false;
                textSetPM25.Enabled = false;
                textSetPM10.Enabled = false;
                btnSetPM25.Enabled = false;
                btnSetPM10.Enabled= false;
            }
            if (labelStatus.Text == "Đang load...")
            {
                btnAuto.Enabled = false;
                btnManual.Enabled = false;
            }

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            btnManual.Enabled = false;
            btnAuto.Enabled = true;
            btnOn.Enabled = true;
            btnOff.Enabled = true;
            btnLightOff.Enabled = true;
            btnLightOn.Enabled = true;  
            btnSet.Enabled = false;
            btnSetPM10.Enabled = false;
            btnSetPM25.Enabled = false;
            textPpm.Enabled = false;
            textSetPM10.Enabled = false;
            textSetPM25.Enabled = false;
            //labelStatus.Text = "Manual";
            client.Publish("CO2Measurement/mode", Encoding.UTF8.GetBytes("manual"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            btnManual.Enabled = true;
            btnAuto.Enabled = false;
            btnOn.Enabled = false;
            btnOff.Enabled = false;
            btnLightOn.Enabled = false;
            btnLightOff.Enabled = false;
            textPpm.Enabled = true;
            textSetPM10.Enabled = true;
            textSetPM25.Enabled = true;
            btnSet.Enabled = true;
            btnSetPM25.Enabled = true;
            btnSetPM10.Enabled = true;
            //labelStatus.Text = "Auto";
            client.Publish("CO2Measurement/mode", Encoding.UTF8.GetBytes("auto"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            client.Publish("CO2Measurement/machine", Encoding.UTF8.GetBytes("on"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            client.Publish("CO2Measurement/machine", Encoding.UTF8.GetBytes("off"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }
        private void btnLightOn_Click(object sender, EventArgs e)
        {
            client.Publish("CO2Measurement/setLight", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnLightOff_Click(object sender, EventArgs e)
        {
            client.Publish("CO2Measurement/setLight", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (textPpm.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số ppm");
            }
            else
            { client.Publish("CO2Measurement/setPPMAuto", Encoding.UTF8.GetBytes(textPpm.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true); }

        }
        private void btnSetPM25_Click(object sender, EventArgs e)
        {
            if (textSetPM25.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông số bụi PM2.5");
            }
            else
            { client.Publish("CO2Measurement/setPM25Auto", Encoding.UTF8.GetBytes(textSetPM25.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true); }

        }
        private void btnSetPM10_Click(object sender, EventArgs e)
        {
            if (textSetPM10.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông số bụi PM10");
            }
            else
            { client.Publish("CO2Measurement/setPM10Auto", Encoding.UTF8.GetBytes(textSetPM10.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true); }

        }
        #endregion button

        //ghi file log
        private void file(string[] value, int addr)
        {
            //tao ten file log_ngay_thang_nam.txt
            DateTime date = DateTime.Now;
            if(addr == 0)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + ".txt";
                File.AppendAllLines(filePath, value);
            }
            else if(addr == 1)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_25.txt";
                File.AppendAllLines(filePath, value);
            }
            else if(addr == 2)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_10.txt";
                File.AppendAllLines(filePath, value);
            }
            
        }
    }

}
