using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Newtonsoft.Json;
using System.Threading;
using System.Net;
using static Control_Station.Form1;
using System.Timers;
using System.Reflection.Emit;

namespace Control_Station
{

    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();
        UdpClient client = new UdpClient();
        //IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.137.70"), 5005); // Raspberry Pi'nin IP'si ve port numarası
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("192.168.137.160"), 2222);
        private bool listening = false;
        public Form1()
        {

            InitializeComponent();
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Interval = 250;
            timer.Start();
        }
        private void TimerOnTick(object sender, EventArgs ea)
        {
            // BU KISMI DİREKT BUTON İÇİNE DE KOYABİLİRSİN.

            listening = true;

            // Thread'de dinleme işlemini başlat
            Thread listenThread = new Thread(ListenForData);
            listenThread.Start();
            //Update();
            //Application.DoEvents();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox1 .Visible = true;  
            try
            {
                string message = "UPDATE";
                SendJsonCommand(message, "NOMOVE", 0, 0, 0);
                ///***** Aşağıdaki 2 satırı fonksiyon yapıp thread ile çağırabilirsin ***///
                //byte[] data = Encoding.ASCII.GetBytes(message);
                //client.Send(data, data.Length, ip);
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "UPDATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ///****** BURADAKİ KOD DENENCEK ******////

            //// Dinleme iş parçacığını başlat
            //Thread listenThread = new Thread(ListenForData);
            //listenThread.Start();
            btnStop.Click += new EventHandler(btnStop_Click);

        }

        private void SendData(string transferMessage)
        {
            byte[] data = Encoding.ASCII.GetBytes(transferMessage);
            client.Send(data, data.Length, ip);
        }


        private void SendDataToEncoder(string transferMessage)
        {
            byte[] data = Encoding.ASCII.GetBytes(transferMessage);
            client.Send(data, data.Length, ip);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            
            try
            {
                string message = "FORWARD";

                ///***** Aşağıdaki 2 satırı fonksiyon yapıp thread ile çağırabilirsin ***///
                //byte[] data = Encoding.ASCII.GetBytes(message);
                //client.Send(data, data.Length, ip);
                SendJsonCommand("UPDATE", message, 40, 8, 0);
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "FORWARD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string messages = "GO";
            //byte[] cmd = Encoding.ASCII.GetBytes(messages);
            //client.Send(cmd, cmd.Length, ip);
            //label12.Text = messages;

        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            
            try
            {
                string message = "BACKWARD";
                SendJsonCommand("UPDATE", message, 40, 8, 0);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "BACKWARD ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //string messages = "GO";
            //byte[] cmd = Encoding.ASCII.GetBytes(messages);
            //client.Send(cmd, cmd.Length, ip);
            //label12.Text = messages;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //string messages = "GO";
            //byte[] cmd = Encoding.ASCII.GetBytes(messages);
            //client.Send(cmd, cmd.Length, ip);
            try
            {
                string message = "STOP";
                SendData(message);
               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "STOP ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            //string messages = "GO";
            //byte[] cmd = Encoding.ASCII.GetBytes(messages);
            //client.Send(cmd, cmd.Length, ip);
            
            try
            {
                string message = "LEFT";
                SendJsonCommand("UPDATE", message, 50, 0, 100);
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "LEFT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //string messages = "GO";
            //byte[] cmd = Encoding.ASCII.GetBytes(messages);
            //client.Send(cmd, cmd.Length, ip);
            try
            {
                string message = "RIGHT";
                SendJsonCommand("UPDATE", message, 50, 0, 100);

                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "RIGHT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void f1(string sensorAdi)
        {
            label1.Invoke((MethodInvoker)(() => label1.Text = sensorAdi));

        }
        void f2(string value_1)
        {
            label2.Invoke((MethodInvoker)(() => label2.Text = value_1));

        }
        void f3(string value_2)
        {
            label3.Invoke((MethodInvoker)(() => label3.Text = value_2));

        }
        void f4(string value_3)
        {
            label4.Invoke((MethodInvoker)(() => label4.Text = value_3));

        }
        void f5(string value_4)
        {
            label10.Invoke((MethodInvoker)(() => label10.Text = value_4));

        }
        void f6(string value_5)
        {
            label15.Invoke((MethodInvoker)(() => label15.Text = value_5));

        }
        private void ListenForData()
        {
            try
            {
                ///******* AŞAĞIDAKİ İLK 3 SATIRI KALDIRMAYI DÜŞÜNÜYORUM *****////
                //string message = "GO";
                //byte[] cmd = Encoding.ASCII.GetBytes(message);
                //client.Send(cmd, cmd.Length, ip);

                ///******** Aşağıdaki İLK 2 Satırı fonksiyon yapıp bangır bangır thread uygula ***////
                byte[] receive = client.Receive(ref ip);

                string jsonData = Encoding.UTF8.GetString(receive);
                //NetworkStream stream = client.
                
                

                SensorData sensorData = JsonConvert.DeserializeObject<SensorData>(jsonData);

                //richTextBox1.Text = Convert.ToString(sensorData);
                //label13.Text = Convert.ToString(sensorData);

                Invoke(new Action(() => f1(sensorData.encoder.ToString())));
                Invoke(new Action(() => f2(sensorData.ultrasonic1.ToString())));
                Invoke(new Action(() => f3(sensorData.ultrasonic2.ToString())));
                Invoke(new Action(() => f4(sensorData.ultrasonic3.ToString())));
                Invoke(new Action(() => f5(sensorData.cpuTemperature.ToString())));
                Invoke(new Action(() => f6(sensorData.randomValue.ToString())));

                //if ((sensorData.ultrasonic1 < 20) || (sensorData.ultrasonic2 < 20) || (sensorData.ultrasonic3 < 20))
                //{
                //    btnForward.Enabled = false;
                //}

                
                //// Alınan veriyi sıfırlama
                Array.Clear(receive, 0, receive.Length);
                
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           button1.PerformClick();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            string go = "UPDATEINFO";
            string mov = "HAREKETINFO";
            int speed = 31;
            int distance;
            int turns;

            if (int.TryParse(textBox1.Text, out distance) && int.TryParse(textBox2.Text, out turns))
            {
                SendJsonCommand(go, mov, speed, distance, turns);
            }
            else
            {
                MessageBox.Show("Please enter valid integers for distance and turns.");
            }
        }
        private void SendJsonCommand(string updatedataInfo, string movementdataInfo, int speedDataInfo, int distanceDataInfo, int turnsDataInfo)
        {
            RoverCommand command = new RoverCommand
            {
                Update_Data = updatedataInfo,
                Movement_Data = movementdataInfo,
                Speed_Data = speedDataInfo,
                Distance_Data = distanceDataInfo,
                Turns_Data = turnsDataInfo
            };

            string json = JsonConvert.SerializeObject(command);
            byte[] data = Encoding.UTF8.GetBytes(json);
            client.Send(data, data.Length, ip);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = "http://192.168.137.160:2222";
            axWindowsMediaPlayer1.URL = "https://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }








        //###################################################################################################################################
        //###################################################################################################################################
        //##################                                    KEYBOARD CONTROL                                        #####################
        //###################################################################################################################################
        //###################################################################################################################################

    }
    public class SensorData
    {
        public int encoder { get; set; }
        public int ultrasonic1 { get; set; }
        public int ultrasonic2 { get; set; }
        public int ultrasonic3 { get; set; }
        public int cpuTemperature { get; set; }
        public int randomValue {  get; set; } 
    }
    public class RoverCommand
    {
        public string Update_Data { get; set; }
        public string Movement_Data { get; set; }
        public int Speed_Data { get; set; }
        public int Distance_Data { get; set; }
        public int Turns_Data { get; set; }
    }
}
