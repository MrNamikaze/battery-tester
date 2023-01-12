using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms.DataVisualization.Charting;
using CsvHelper;
using System.Globalization;
using static WindowsFormsApp1.Form1;
using CsvHelper.Configuration.Attributes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public class FormatCsv
        {
            public int no { get; set; }
            public string arus { get; set; }
            public string volt { get; set; }
            public string temp { get; set; }
            public string waktu { get; set; }
        }
        private delegate void SafeCallDelegate(string text, int batas);
        // form
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.Text = "115200";
            textBox1.Text = "300";
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ports);
            button2.Enabled = false;
            
        }
        List<string> data_time = new List<string>();
        List<string> data_amp = new List<string>();
        List<string> data_volt = new List<string>();
        List<string> data_temp = new List<string>();
        string[] waktu;
        string[] amp;
        string[] volt;
        string[] temp;
        // relay button
        int status1;
        int status2;
        int status3;
        int status4;
        int status5;
        int status6;
        int status7;
        int status8;
        int status9;
        int status10;
        int status11;
        int status12;
        int status13;
        int status14;
        int status15;
        int status16;
        private void tombol_1_Click(object sender, EventArgs e)
        {
            string nilai_relay1;
            if (status1 == 0)
            {
                status1 = 1;
                relay_off1.Visible = false;
                relay_on1.Visible = true;
                status_relay1.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay1 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay1);
            }
            else
            {
                status1 = 0;
                relay_off1.Visible = true;
                relay_on1.Visible = false;
                status_relay1.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay1 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay1);

            }
        }
        private void tombol_2_Click(object sender, EventArgs e)
        {
            string nilai_relay2;
            if (status2 == 0)
            {
                status2 = 1;
                relay_off2.Visible = false;
                relay_on2.Visible = true;
                status_relay2.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay2 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay2);
            }
            else
            {
                status2 = 0;
                relay_off2.Visible = true;
                relay_on2.Visible = false;
                status_relay2.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay2 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay2);

            }
        }

        private void tombol_3_Click(object sender, EventArgs e)
        {
            string nilai_relay3;
            if (status3 == 0)
            {
                status3 = 1;
                relay_off3.Visible = false;
                relay_on3.Visible = true;
                status_relay3.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay3 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay3);
            }
            else
            {
                status3 = 0;
                relay_off3.Visible = true;
                relay_on3.Visible = false;
                status_relay3.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay3 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay3);

            }
        }

        private void tombol_4_Click(object sender, EventArgs e)
        {
            string nilai_relay4;
            if (status4 == 0)
            {
                status4 = 1;
                relay_off4.Visible = false;
                relay_on4.Visible = true;
                status_relay4.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay4 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay4);
            }
            else
            {
                status4 = 0;
                relay_off4.Visible = true;
                relay_on4.Visible = false;
                status_relay4.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay4 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay4);

            }
        }

        private void tombol_5_Click(object sender, EventArgs e)
        {
            string nilai_relay5;
            if (status5 == 0)
            {
                status5 = 1;
                relay_off5.Visible = false;
                relay_on5.Visible = true;
                status_relay5.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay5 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay5);
            }
            else
            {
                status5 = 0;
                relay_off5.Visible = true;
                relay_on5.Visible = false;
                status_relay5.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay5 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay5);

            }
        }

        private void tombol_6_Click(object sender, EventArgs e)
        {
            string nilai_relay6;
            if (status6 == 0)
            {
                status6 = 1;
                relay_off6.Visible = false;
                relay_on6.Visible = true;
                status_relay6.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay6 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay6);
            }
            else
            {
                status6 = 0;
                relay_off6.Visible = true;
                relay_on6.Visible = false;
                status_relay6.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay6 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay6);

            }
        }

        private void tombol_7_Click(object sender, EventArgs e)
        {
            string nilai_relay7;
            if (status7 == 0)
            {
                status7 = 1;
                relay_off7.Visible = false;
                relay_on7.Visible = true;
                status_relay7.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay7 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay7);
            }
            else
            {
                status7 = 0;
                relay_off7.Visible = true;
                relay_on7.Visible = false;
                status_relay7.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay7 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay7);

            }
        }

        private void tombol_8_Click(object sender, EventArgs e)
        {
            string nilai_relay8;
            if (status8 == 0)
            {
                status8 = 1;
                relay_off8.Visible = false;
                relay_on8.Visible = true;
                status_relay8.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay8 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay8);
            }
            else
            {
                status8 = 0;
                relay_off8.Visible = true;
                relay_on8.Visible = false;
                status_relay8.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay8 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay8);

            }
        }

        private void tombol_9_Click(object sender, EventArgs e)
        {
            string nilai_relay9;
            if (status9 == 0)
            {
                status9 = 1;
                relay_off9.Visible = false;
                relay_on9.Visible = true;
                status_relay9.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay9 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay9);
            }
            else
            {
                status9 = 0;
                relay_off9.Visible = true;
                relay_on9.Visible = false;
                status_relay9.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay9 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay9);

            }
        }

        private void tombol_10_Click(object sender, EventArgs e)
        {
            string nilai_relay10;
            if (status10 == 0)
            {
                status10 = 1;
                relay_off10.Visible = false;
                relay_on10.Visible = true;
                status_relay10.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay10 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay10);
            }
            else
            {
                status10 = 0;
                relay_off10.Visible = true;
                relay_on10.Visible = false;
                status_relay10.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay10 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay10);

            }
        }

        private void tombol_11_Click(object sender, EventArgs e)
        {
            string nilai_relay11;
            if (status11 == 0)
            {
                status11 = 1;
                relay_off11.Visible = false;
                relay_on11.Visible = true;
                status_relay11.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay11 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay11);
            }
            else
            {
                status11 = 0;
                relay_off11.Visible = true;
                relay_on11.Visible = false;
                status_relay11.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay11 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay11);

            }
        }

        private void tombol_12_Click(object sender, EventArgs e)
        {
            string nilai_relay12;
            if (status12 == 0)
            {
                status12 = 1;
                relay_off12.Visible = false;
                relay_on12.Visible = true;
                status_relay12.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay12 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay12);
            }
            else
            {
                status12 = 0;
                relay_off12.Visible = true;
                relay_on12.Visible = false;
                status_relay12.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay12 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay12);

            }
        }

        private void tombol_13_Click(object sender, EventArgs e)
        {
            string nilai_relay13;
            if (status13 == 0)
            {
                status13 = 1;
                relay_off13.Visible = false;
                relay_on13.Visible = true;
                status_relay13.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay13 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay13);
            }
            else
            {
                status13 = 0;
                relay_off13.Visible = true;
                relay_on13.Visible = false;
                status_relay13.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay13 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay13);

            }
        }

        private void tombol_14_Click(object sender, EventArgs e)
        {
            string nilai_relay14;
            if (status14 == 0)
            {
                status14 = 1;
                relay_off14.Visible = false;
                relay_on14.Visible = true;
                status_relay14.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay14 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay14);
            }
            else
            {
                status14 = 0;
                relay_off14.Visible = true;
                relay_on14.Visible = false;
                status_relay14.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay14 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay14);

            }
        }

        private void tombol_15_Click(object sender, EventArgs e)
        {
            string nilai_relay15;
            if (status15 == 0)
            {
                status15 = 1;
                relay_off15.Visible = false;
                relay_on15.Visible = true;
                status_relay15.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay15 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay15);
            }
            else
            {
                status15 = 0;
                relay_off15.Visible = true;
                relay_on15.Visible = false;
                status_relay15.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay15 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay15);

            }
        }

        private void tombol_16_Click(object sender, EventArgs e)
        {
            string nilai_relay16;
            if (status16 == 0)
            {
                status16 = 1;
                relay_off16.Visible = false;
                relay_on16.Visible = true;
                status_relay16.Text = "On";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay16 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay16);
            }
            else
            {
                status16 = 0;
                relay_off16.Visible = true;
                relay_on16.Visible = false;
                status_relay16.Text = "Off";
                string status1_string = status1.ToString();
                string status2_string = status2.ToString();
                string status3_string = status3.ToString();
                string status4_string = status4.ToString();
                string status5_string = status5.ToString();
                string status6_string = status6.ToString();
                string status7_string = status7.ToString();
                string status8_string = status8.ToString();
                string status9_string = status9.ToString();
                string status10_string = status10.ToString();
                string status11_string = status11.ToString();
                string status12_string = status12.ToString();
                string status13_string = status13.ToString();
                string status14_string = status14.ToString();
                string status15_string = status15.ToString();
                string status16_string = status16.ToString();
                string nilai_relay = status1_string + status2_string + status3_string +
                    status4_string + status5_string + status6_string + status7_string +
                    status8_string + status9_string + status10_string + status11_string +
                    status12_string + status13_string + status14_string + status15_string +
                    status16_string;
                nilai_relay16 = "0xAA" + nilai_relay;
                serialPort1.WriteLine(nilai_relay16);

            }
        }
        // waktu
        private DateTime _start;
        private void button1_Click(object sender, EventArgs e)
        {
            _start = DateTime.Now;
            int status = 1;
            data_time.Clear();
            data_amp.Clear();
            data_volt.Clear();
            data_temp.Clear();
            Thread t = new Thread(() => RekamData(status));
            t.Start();
            timer2.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }
        private void RekamData(int status)
        {
            string interval = textBox1.Text;
            string nama_path = namaPath.Text;
            string nama_file = namaFile.Text;
            string gabung = nama_path + "\\" + nama_file + ".csv";
            //int waktu = int.Parse(interval);
            List<FormatCsv> formatCsv = new List<FormatCsv>();
            int a = 1;
            if (label25.InvokeRequired)
            {
                label25.Invoke(new MethodInvoker(delegate {label25.Text = "a"; }));
            }
            while (label25.Text == "a")
            {
                Thread.Sleep(1000);
                formatCsv.Add(new FormatCsv() { no = a, arus = label23.Text, volt = label24.Text, temp = label29.Text, waktu = waktu_berjalan.Text});
                data_time.Add(waktu_berjalan.Text);
                data_amp.Add(label23.Text);
                data_volt.Add(label24.Text);
                data_temp.Add(label29.Text);
                a++;
            }
            
            using (var writer = new StreamWriter(gabung))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(formatCsv);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] waktu = new string[data_amp.Count];
            string[] amp = new string[data_amp.Count];
            string[] volt = new string[data_amp.Count];
            string[] temp = new string[data_amp.Count];
            for (int b = 0; b < data_amp.Count; b++)
            {
                waktu[b] = data_time[b];
                amp[b] = data_amp[b];
                volt[b] = data_volt[b];
                temp[b] = data_temp[b];
            }
            Form2 form2 = new Form2();
            form2.ShowingArray(waktu, amp, volt, temp);
            form2.Show();
            _start = DateTime.Now;
            label25.Text = "b";
            int status = 1;
            timer2.Stop();
            button1.Enabled = true;
            button2.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            waktu_berjalan.Text = duration.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string port = comboBox1.Text;
            string angkaBaut = comboBox2.Text;
            int BautRate = int.Parse(angkaBaut);
            string interval = textBox1.Text;
            serialPort1.BaudRate = BautRate;
            int status_port = 1;
            serialPort1.PortName = port;
            serialPort1.Open();
            string nilai_delay = "0xAB" + interval;
            serialPort1.WriteLine(nilai_delay);
            Thread t = new Thread(() => DataElektronik(port, interval, status_port));
            t.Start();
            status1 = 0;
            status2 = 0;
            status3 = 0;
            status4 = 0;
            status5 = 0;
            status6 = 0;
            status7 = 0;
            status8 = 0;
            status9 = 0;
            status10 = 0;
            status11 = 0;
            status12 = 0;
            status13 = 0;
            status14 = 0;
            status15 = 0;
            status16 = 0;
            relay_off1.Visible = true;
            relay_on1.Visible = false;
            status_relay1.Text = "Off";
            relay_off2.Visible = true;
            relay_on2.Visible = false;
            status_relay2.Text = "Off";
            relay_off3.Visible = true;
            relay_on3.Visible = false;
            status_relay3.Text = "Off";
            relay_off4.Visible = true;
            relay_on4.Visible = false;
            status_relay4.Text = "Off";
            relay_off5.Visible = true;
            relay_on5.Visible = false;
            status_relay5.Text = "Off";
            relay_off6.Visible = true;
            relay_on6.Visible = false;
            status_relay6.Text = "Off";
            relay_off7.Visible = true;
            relay_on7.Visible = false;
            status_relay7.Text = "Off";
            relay_off8.Visible = true;
            relay_on8.Visible = false;
            status_relay8.Text = "Off";
            relay_off9.Visible = true;
            relay_on9.Visible = false;
            status_relay9.Text = "Off";
            relay_off10.Visible = true;
            relay_on10.Visible = false;
            status_relay10.Text = "Off";
            relay_off11.Visible = true;
            relay_on11.Visible = false;
            status_relay11.Text = "Off";
            relay_off12.Visible = true;
            relay_on12.Visible = false;
            status_relay12.Text = "Off";
            relay_off13.Visible = true;
            relay_on13.Visible = false;
            status_relay13.Text = "Off";
            relay_off14.Visible = true;
            relay_on14.Visible = false;
            status_relay14.Text = "Off";
            relay_off15.Visible = true;
            relay_on15.Visible = false;
            status_relay15.Text = "Off";
            relay_off16.Visible = true;
            relay_on16.Visible = false;
            status_relay16.Text = "Off";
            string status_relay_mati = "0xAA0000000000000000";
            serialPort1.WriteLine(status_relay_mati);
        }
        // elektronika
        private void WriteTextSafe(string text, int batas)
        {
            if(close_program.Text == "a")
            {
                if (chart1.InvokeRequired)
                {
                    var d = new SafeCallDelegate(WriteTextSafe);
                    chart1.Invoke(d, new object[] { text, batas });
                }
                else
                {
                    int panjang = text.Length;
                    if (panjang < 4)
                    {

                    }
                    else
                    {
                        
                        String data_2 = text.Substring(0, 4);
                        DateTime aDate = DateTime.Now;
                        String waktu = aDate.ToString("HH:mm:ss");
                        if (data_2 == "0xBA")
                        {
                            String data_3 = text.Substring(4);
                            float data_4 = float.Parse(data_3);
                            if (data_4 < 0.6)
                            {
                                data_4 = 0;
                            }
                            if (batas < 12)
                            {
                                chart2.Series["Volt"].Points.AddXY(waktu, data_4);
                            }
                            else
                            {
                                chart2.Series["Volt"].Points.AddXY(waktu, data_4);
                            }
                            label24.Text = data_4.ToString();
                        }
                        else if (data_2 == "0xBB")
                        {
                            String data_3 = text.Substring(4);
                            float data_4 = float.Parse(data_3);
                            if(data_4 < 0.6)
                            {
                                data_4 = 0;
                            }
                            if (batas < 12)
                            {
                                chart1.Series["Arus"].Points.AddXY(waktu, data_4);
                            }
                            else
                            {
                                chart1.Series["Arus"].Points.AddXY(waktu, data_4);
                            }
                            label23.Text = data_4.ToString();
                        }
                        else if (data_2 == "0xBC")
                        {
                            String data_3 = text.Substring(4);
                            float data_4 = float.Parse(data_3);
                            if (batas < 12)
                            {
                                chart3.Series["Temp"].Points.AddXY(waktu, data_4);
                            }
                            else
                            {
                                chart3.Series["Temp"].Points.AddXY(waktu, data_4);
                            }
                            label29.Text = data_4.ToString();
                        }
                        else if (data_2 == "0xBD")
                        {

                        }
                        else if (data_2 == "0xBE")
                        {
                            String data_3 = text.Substring(4);
                            char[] relay = data_3.ToCharArray();
                            if (relay[0] == '1')
                            {
                                status1 = 1;
                                relay_off1.Visible = false;
                                relay_on1.Visible = true;
                                status_relay1.Text = "On";

                            }
                            else
                            {
                                status1 = 0;
                                relay_off1.Visible = true;
                                relay_on1.Visible = false;
                                status_relay1.Text = "Off";
                            }
                            if (relay[1] == '1')
                            {
                                status2 = 1;
                                relay_off2.Visible = false;
                                relay_on2.Visible = true;
                                status_relay2.Text = "On";

                            }
                            else
                            {
                                status2 = 0;
                                relay_off2.Visible = true;
                                relay_on2.Visible = false;
                                status_relay2.Text = "Off";
                            }
                            if (relay[2] == '1')
                            {
                                status3 = 1;
                                relay_off3.Visible = false;
                                relay_on3.Visible = true;
                                status_relay3.Text = "On";

                            }
                            else
                            {
                                status3 = 0;
                                relay_off3.Visible = true;
                                relay_on3.Visible = false;
                                status_relay3.Text = "Off";
                            }
                            if (relay[3] == '1')
                            {
                                status4 = 1;
                                relay_off4.Visible = false;
                                relay_on4.Visible = true;
                                status_relay4.Text = "On";

                            }
                            else
                            {
                                status4 = 0;
                                relay_off4.Visible = true;
                                relay_on4.Visible = false;
                                status_relay4.Text = "Off";
                            }
                            if (relay[4] == '1')
                            {
                                status5 = 1;
                                relay_off5.Visible = false;
                                relay_on5.Visible = true;
                                status_relay5.Text = "On";

                            }
                            else
                            {
                                status5 = 0;
                                relay_off5.Visible = true;
                                relay_on5.Visible = false;
                                status_relay5.Text = "Off";
                            }
                            if (relay[5] == '1')
                            {
                                status6 = 1;
                                relay_off6.Visible = false;
                                relay_on6.Visible = true;
                                status_relay6.Text = "On";

                            }
                            else
                            {
                                status6 = 0;
                                relay_off6.Visible = true;
                                relay_on6.Visible = false;
                                status_relay6.Text = "Off";
                            }
                            if (relay[6] == '1')
                            {
                                status7 = 1;
                                relay_off7.Visible = false;
                                relay_on7.Visible = true;
                                status_relay7.Text = "On";

                            }
                            else
                            {
                                status7 = 0;
                                relay_off7.Visible = true;
                                relay_on7.Visible = false;
                                status_relay7.Text = "Off";
                            }
                            if (relay[7] == '1')
                            {
                                status8 = 1;
                                relay_off8.Visible = false;
                                relay_on8.Visible = true;
                                status_relay8.Text = "On";

                            }
                            else
                            {
                                status8 = 0;
                                relay_off8.Visible = true;
                                relay_on8.Visible = false;
                                status_relay8.Text = "Off";
                            }
                            if (relay[8] == '1')
                            {
                                status9 = 1;
                                relay_off9.Visible = false;
                                relay_on9.Visible = true;
                                status_relay9.Text = "On";

                            }
                            else
                            {
                                status9 = 0;
                                relay_off9.Visible = true;
                                relay_on9.Visible = false;
                                status_relay9.Text = "Off";
                            }
                            if (relay[9] == '1')
                            {
                                status10 = 1;
                                relay_off10.Visible = false;
                                relay_on10.Visible = true;
                                status_relay10.Text = "On";

                            }
                            else
                            {
                                status10 = 0;
                                relay_off10.Visible = true;
                                relay_on10.Visible = false;
                                status_relay10.Text = "Off";
                            }
                            if (relay[10] == '1')
                            {
                                status11 = 1;
                                relay_off11.Visible = false;
                                relay_on11.Visible = true;
                                status_relay11.Text = "On";

                            }
                            else
                            {
                                status11 = 0;
                                relay_off11.Visible = true;
                                relay_on11.Visible = false;
                                status_relay11.Text = "Off";
                            }
                            if (relay[11] == '1')
                            {
                                status12 = 1;
                                relay_off12.Visible = false;
                                relay_on12.Visible = true;
                                status_relay12.Text = "On";

                            }
                            else
                            {
                                status12 = 0;
                                relay_off12.Visible = true;
                                relay_on12.Visible = false;
                                status_relay12.Text = "Off";
                            }
                            if (relay[12] == '1')
                            {
                                status13 = 1;
                                relay_off13.Visible = false;
                                relay_on13.Visible = true;
                                status_relay13.Text = "On";

                            }
                            else
                            {
                                status13 = 0;
                                relay_off13.Visible = true;
                                relay_on13.Visible = false;
                                status_relay13.Text = "Off";
                            }
                            if (relay[13] == '1')
                            {
                                status14 = 1;
                                relay_off14.Visible = false;
                                relay_on14.Visible = true;
                                status_relay14.Text = "On";

                            }
                            else
                            {
                                status14 = 0;
                                relay_off14.Visible = true;
                                relay_on14.Visible = false;
                                status_relay14.Text = "Off";
                            }
                            if (relay[14] == '1')
                            {
                                status15 = 1;
                                relay_off15.Visible = false;
                                relay_on15.Visible = true;
                                status_relay15.Text = "On";

                            }
                            else
                            {
                                status15 = 0;
                                relay_off15.Visible = true;
                                relay_on15.Visible = false;
                                status_relay15.Text = "Off";
                            }
                            if (relay[15] == '1')
                            {
                                status16 = 1;
                                relay_off16.Visible = false;
                                relay_on16.Visible = true;
                                status_relay16.Text = "On";

                            }
                            else
                            {
                                status16 = 0;
                                relay_off16.Visible = true;
                                relay_on16.Visible = false;
                                status_relay16.Text = "Off";
                            }

                        }
                        else
                        {

                        }
                    }
                }
            }
            else
            {

            }
        }
        private void DataElektronik(String port, String interval, int status_port)
        {
            int waktu = int.Parse(interval);
            int waktu1 = waktu / 3;
            int batas = 1;
            while (serialPort1.IsOpen==true)
            {
                string data_1 = serialPort1.ReadLine();
                WriteTextSafe(data_1, batas);
                Thread.Sleep(waktu1);
                batas++;
            }
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            close_program.Text = "b";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            status1 = 0;
            status2 = 0;
            status3 = 0;
            status4 = 0;
            status5 = 0;
            status6 = 0;
            status7 = 0;
            status8 = 0;
            status9 = 0;
            status10 = 0;
            status11 = 0;
            status12 = 0;
            status13 = 0;
            status14 = 0;
            status15 = 0;
            status16 = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            status1 = 0;
            status2 = 0;
            status3 = 0;
            status4 = 0;
            status5 = 0;
            status6 = 0;
            status7 = 0;
            status8 = 0;
            status9 = 0;
            status10 = 0;
            status11 = 0;
            status12 = 0;
            status13 = 0;
            status14 = 0;
            status15 = 0;
            status16 = 0;
            relay_off1.Visible = true;
            relay_on1.Visible = false;
            status_relay1.Text = "Off";
            relay_off2.Visible = true;
            relay_on2.Visible = false;
            status_relay2.Text = "Off";
            relay_off3.Visible = true;
            relay_on3.Visible = false;
            status_relay3.Text = "Off";
            relay_off4.Visible = true;
            relay_on4.Visible = false;
            status_relay4.Text = "Off";
            relay_off5.Visible = true;
            relay_on5.Visible = false;
            status_relay5.Text = "Off";
            relay_off6.Visible = true;
            relay_on6.Visible = false;
            status_relay6.Text = "Off";
            relay_off7.Visible = true;
            relay_on7.Visible = false;
            status_relay7.Text = "Off";
            relay_off8.Visible = true;
            relay_on8.Visible = false;
            status_relay8.Text = "Off";
            relay_off9.Visible = true;
            relay_on9.Visible = false;
            status_relay9.Text = "Off";
            relay_off10.Visible = true;
            relay_on10.Visible = false;
            status_relay10.Text = "Off";
            relay_off11.Visible = true;
            relay_on11.Visible = false;
            status_relay11.Text = "Off";
            relay_off12.Visible = true;
            relay_on12.Visible = false;
            status_relay12.Text = "Off";
            relay_off13.Visible = true;
            relay_on13.Visible = false;
            status_relay13.Text = "Off";
            relay_off14.Visible = true;
            relay_on14.Visible = false;
            status_relay14.Text = "Off";
            relay_off15.Visible = true;
            relay_on15.Visible = false;
            status_relay15.Text = "Off";
            relay_off16.Visible = true;
            relay_on16.Visible = false;
            status_relay16.Text = "Off";
            string status_relay_mati = "0xAA0000000000000000";
            serialPort1.WriteLine(status_relay_mati);
            string port = comboBox1.Text;
            string angkaBaut = comboBox2.Text;
            int BautRate = int.Parse(angkaBaut);
            string interval = textBox1.Text;
            serialPort1.BaudRate = BautRate;
            serialPort1.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string value = "";
            bool isChecked1 = radioButton1.Checked;
            bool isChecked2 = radioButton2.Checked;
            bool isChecked3 = radioButton3.Checked;
            if (isChecked1)
            {
                value = "0xAC12";
                serialPort1.WriteLine(value);
            }
            if (isChecked2)
            {
                value = "0xAC30";
                serialPort1.WriteLine(value);
            }
            if (isChecked3)
            {
                value = "0xAC47";
                serialPort1.WriteLine(value);
            }
            Thread t = new Thread(() => WaktuBerjalan());
            t.Start();
        }

        private void WaktuBerjalan()
        {
            Thread.Sleep(10000);
            string amp = label23.Text;
            float nilai_amp = float.Parse(amp);
            if(nilai_amp > 7)
            {
                label33.Invoke(new MethodInvoker(delegate { label33.Text = "Baterai Bagus"; }));
            }
            else
            {
                label33.Invoke(new MethodInvoker(delegate { label33.Text = "Baterai Tidak Bagus"; }));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            status1 = 0;
            status2 = 0;
            status3 = 0;
            status4 = 0;
            status5 = 0;
            status6 = 0;
            status7 = 0;
            status8 = 0;
            status9 = 0;
            status10 = 0;
            status11 = 0;
            status12 = 0;
            status13 = 0;
            status14 = 0;
            status15 = 0;
            status16 = 0;
            relay_off1.Visible = true;
            relay_on1.Visible = false;
            status_relay1.Text = "Off";
            relay_off2.Visible = true;
            relay_on2.Visible = false;
            status_relay2.Text = "Off";
            relay_off3.Visible = true;
            relay_on3.Visible = false;
            status_relay3.Text = "Off";
            relay_off4.Visible = true;
            relay_on4.Visible = false;
            status_relay4.Text = "Off";
            relay_off5.Visible = true;
            relay_on5.Visible = false;
            status_relay5.Text = "Off";
            relay_off6.Visible = true;
            relay_on6.Visible = false;
            status_relay6.Text = "Off";
            relay_off7.Visible = true;
            relay_on7.Visible = false;
            status_relay7.Text = "Off";
            relay_off8.Visible = true;
            relay_on8.Visible = false;
            status_relay8.Text = "Off";
            relay_off9.Visible = true;
            relay_on9.Visible = false;
            status_relay9.Text = "Off";
            relay_off10.Visible = true;
            relay_on10.Visible = false;
            status_relay10.Text = "Off";
            relay_off11.Visible = true;
            relay_on11.Visible = false;
            status_relay11.Text = "Off";
            relay_off12.Visible = true;
            relay_on12.Visible = false;
            status_relay12.Text = "Off";
            relay_off13.Visible = true;
            relay_on13.Visible = false;
            status_relay13.Text = "Off";
            relay_off14.Visible = true;
            relay_on14.Visible = false;
            status_relay14.Text = "Off";
            relay_off15.Visible = true;
            relay_on15.Visible = false;
            status_relay15.Text = "Off";
            relay_off16.Visible = true;
            relay_on16.Visible = false;
            status_relay16.Text = "Off";
            chart1.Series["Arus"].Points.Clear();
            chart2.Series["Volt"].Points.Clear();
            chart3.Series["Temp"].Points.Clear();
            string status_relay_mati = "0xAA0000000000000000";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ports);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
