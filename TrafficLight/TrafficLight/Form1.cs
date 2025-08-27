using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Using Serial Ports
using System.IO;
using System.IO.Ports;
using System.Xml;
// Using Thread
using System.Threading;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        //SerialPort Port = new SerialPort(); // SerialPort Selected
        string InputData = String.Empty;
        public Form1()
        {
            InitializeComponent();
            // Serial Port Connection Configurations
            tmrPort1.Interval = 1000;
            tmrPort1.Enabled = true;
            Port1.ReadTimeout = 1000;
            //Port1.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            // BaudRate Settings
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbBaudRate.Items.AddRange(BaudRate);

            // DataBits Settings
            string[] Databits = { "6", "7", "8" };
            cbDataBits.Items.AddRange(Databits);

            // Parity Settings
            string[] Parity = { "None", "Odd", "Even" };
            cbParity.Items.AddRange(Parity);

            // Stop bit Settings
            string[] stopbit = { "1", "1.5", "2" };
            cbStopBit.Items.AddRange(stopbit);
        }
        
        string[] ports = SerialPort.GetPortNames();
        int intlen = 0;

        private void tmrPort1_Tick(object sender, EventArgs e)
        {
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                cbb_COMPort.Items.Clear();
                for (int i = 0; i < intlen; i++)
                {
                    cbb_COMPort.Items.Add(ports[i]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Connection Default 
            cbBaudRate.SelectedIndex = 3;
            cbDataBits.SelectedIndex = 2;
            cbParity.SelectedIndex = 0;
            cbStopBit.SelectedIndex = 0;
            Port1.Close();
            Control.CheckForIllegalCrossThreadCalls = false;
            
        }

        private void cbb_COMPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            Port1.PortName = cbb_COMPort.Text;
        }

        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            Port1.BaudRate = Convert.ToInt32(cbBaudRate.Text);
        }

        private void cbDataBits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            Port1.DataBits = Convert.ToInt16(cbDataBits.Text);
        }

        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            switch (cbParity.SelectedIndex.ToString())
            {
                case "Odd":
                    Port1.Parity = Parity.Odd;
                    break;
                case "Even":
                    Port1.Parity = Parity.Even;
                    break;
                default:
                    Port1.Parity = Parity.None;
                    break;
            }
        }

        private void cbStopBit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Port1.IsOpen)
            {
                Port1.Close();
            }
            switch (cbStopBit.SelectedIndex.ToString())
            {
                case "1":
                    Port1.StopBits = StopBits.One;
                    break;
                case "1.5":
                    Port1.StopBits = StopBits.OnePointFive;
                    break;
                default:
                    Port1.StopBits = StopBits.Two;
                    break;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string data = tbStep1.Text.Trim() + tbStep2.Text.Trim() + tbStep3.Text.Trim() + tbStep4.Text.Trim() + "~";
            if (btnConnect.Text == "Connect")
            {
                btnConnect.Text = "Disconnect";
                try
                {
                    Port1.Open();
                    // statusStrip Display
                    statusLabel.Text = "Connecting to " + cbb_COMPort.SelectedItem.ToString();
                    Port1.Write(data);
                }
                catch (Exception ex)
                {
                    statusLabel.Text = "Connection FAILED";
                }
            }
            else
            {
                btnConnect.Text = "Connect";
                Port1.Close();
                // statusStrip Display
                statusLabel.Text = "Disconnection Complete";   
            }
        }

        private void Port1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                InputData = Port1.ReadLine();
                Port1.Close(); // Reset UART
                LightDisplay();
                Port1.Open(); // Restart UART
            }
            catch (System.TimeoutException) { }
        }

        private void LightDisplay()
        {
            if (InputData == "RedA_GreenB")
            {
                RedA.BackColor = Color.Red;
                GreenA.BackColor = Color.Gray;
                YellowA.BackColor = Color.Gray;
                RedB.BackColor = Color.Gray;
                GreenB.BackColor = Color.Green;
                YellowB.BackColor = Color.Gray;
            }
            if (InputData == "RedA_YellowB")
            {
                RedA.BackColor = Color.Red;
                GreenA.BackColor = Color.Gray;
                YellowA.BackColor = Color.Gray;
                RedB.BackColor = Color.Gray;
                GreenB.BackColor = Color.Gray;
                YellowB.BackColor = Color.Yellow;
            }
            if (InputData == "GreenA_RedB")
            {
                RedA.BackColor = Color.Gray;
                GreenA.BackColor = Color.Green;
                YellowA.BackColor = Color.Gray;
                RedB.BackColor = Color.Red;
                GreenB.BackColor = Color.Gray;
                YellowB.BackColor = Color.Gray;
            }
            if (InputData == "YellowA_RedB")
            {
                RedA.BackColor = Color.Gray;
                GreenA.BackColor = Color.Gray;
                YellowA.BackColor = Color.Yellow;
                RedB.BackColor = Color.Red;
                GreenB.BackColor = Color.Gray;
                YellowB.BackColor = Color.Gray;
            }
        }

    }
}
