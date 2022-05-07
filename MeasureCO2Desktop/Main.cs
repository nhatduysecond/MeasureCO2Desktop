using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.IO;
using System.Net.NetworkInformation;

namespace MeasureCO2Desktop
{
    public partial class Main : Form
    {
        MqttClient client;
        string clientID;
        public Main()
        {
            InitializeComponent();
            ketnoi();
        }

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

            if (networkStatus)
            {
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
                        client.Publish("CO2Measurement/stateNow", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                    }
                }
                //ko ket noi duoc mqtt broker
                catch
                {
                    MessageBox.Show("Error! Cannot connect to MQTT Broker","ERROR!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //khi ko co internet
            else
            {
                MessageBox.Show("Error! Cannot connect to Internet", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    string ReceiveMessage = Encoding.UTF8.GetString(e.Message);
                    string ReceiveTopic = e.Topic;
                    stateNow(ReceiveMessage, ReceiveTopic);
                    string[] datas, dataPM25, dataPM10, finalDatas;
                    string data = "", datapm25 = "", datapm10 = "", finalData;
                    if (e.Topic == "CO2Measurement/Data")
                    {
                        arcScaleComponent1.Value = float.Parse(ReceiveMessage);
                        datas = new string[] { ReceiveMessage };
                        data = ReceiveMessage;
                        file(datas, 0);
                    }
                    if (e.Topic == "CO2Measurement/PM2.5")
                    {
                        arcScaleComponent3.Value = float.Parse(ReceiveMessage);
                        dataPM25 = new string[] { ReceiveMessage };
                        datapm25 = ReceiveMessage;
                        file(dataPM25, 1);
                    }
                    if (e.Topic == "CO2Measurement/PM10")
                    {
                        arcScaleComponent2.Value = float.Parse(ReceiveMessage);
                        dataPM10 = new string[] { ReceiveMessage };
                        datapm10 = ReceiveMessage;
                        file(dataPM10, 2);
                    }
                    finalData = DateTime.Now.ToString() + " " + data + " " + datapm25 + " " + datapm10;
                    finalDatas = new string[] { finalData };
                    file(finalDatas, 3);
                });
            }
            else
            {
                return;
            }

        }

        private void stateNow(string ReceiveMessage, string e)
        {
            //kiem tra trang thai luc vua khoi dong
         
            if (e == "CO2Measurement/statusMachine")
            {
                if (ReceiveMessage == "1")
                {
                    pictureBox8.Image = Properties.Resources.fan_icon_133581;
                }
                else
                {
                    pictureBox8.Image = Properties.Resources.Fan_icon_icons_com_52103;
                }
            }
            if (e == "CO2Measurement/statusLight")
            {
                if (ReceiveMessage == "1")
                {
                    pictureBox7.Image = Properties.Resources.light_on_removebg_preview;
                }
                else
                {
                    pictureBox7.Image = Properties.Resources.light_off_removebg_preview;
                }
            }
        }

        //ghi file log
        private void file(string[] value, int addr)
        {
            //tao ten file log_ngay_thang_nam.txt
            DateTime date = DateTime.Now;
            if (addr == 0)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + ".txt";
                File.AppendAllLines(filePath, value);
            }
            else if (addr == 1)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_25.txt";
                File.AppendAllLines(filePath, value);
            }
            else if (addr == 2)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_10.txt";
                File.AppendAllLines(filePath, value);
            }
            else if (addr == 3)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
                + @"\MeasureCO2Desktop" + @"\log_" + date.Day + "_" + date.Month + "_" + date.Year + "_final.txt";
                File.AppendAllLines(filePath, value);
            }
        }

        private void toggleButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManualMode.Checked == true)
            {
                toggleButtonLight.Enabled = true;
                if (toggleButtonLight.CheckState == CheckState.Unchecked)
                {
                    client.Publish("CO2Measurement/setLight", Encoding.UTF8.GetBytes("0"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
                else
                {
                    client.Publish("CO2Measurement/setLight", Encoding.UTF8.GetBytes("1"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
            }
            else if (RadioAutoMode.Checked == true)
            {
                toggleButtonLight.Checked = false;
            }
            
        }

        private void toggleButtonFan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioManualMode.Checked == true)
            {
                toggleButtonFan.Enabled = true;
                if (toggleButtonFan.CheckState == CheckState.Checked)
                {
                    client.Publish("CO2Measurement/machine", Encoding.UTF8.GetBytes("on"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
                else
                {
                    client.Publish("CO2Measurement/machine", Encoding.UTF8.GetBytes("off"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                }
            }
            else if (RadioAutoMode.Checked == true)
            {
                toggleButtonFan.Checked = false;
            }
            
        }

        private void RadioAutoMode_CheckedChanged(object sender, EventArgs e)
        {
            
            client.Publish("CO2Measurement/mode", Encoding.UTF8.GetBytes("auto"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void radioManualMode_CheckedChanged(object sender, EventArgs e)
        {
            
            client.Publish("CO2Measurement/mode", Encoding.UTF8.GetBytes("manual"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
        }

        private void btnSetNguong_Click(object sender, EventArgs e)
        {
            if(textBoxCO2.Text == "" || textBoxPM10.Text =="" || textBoxPM2_5.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ vào tất cả các trường", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                client.Publish("CO2Measurement/setPPMAuto", Encoding.UTF8.GetBytes(textBoxCO2.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                client.Publish("CO2Measurement/setPM25Auto", Encoding.UTF8.GetBytes(textBoxPM2_5.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
                client.Publish("CO2Measurement/setPM10Auto", Encoding.UTF8.GetBytes(textBoxPM10.Text), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
            }
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
