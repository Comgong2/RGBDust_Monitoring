using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace RGBDust_Monitoring
{
    public partial class RGBDust : Form
    {
        public RGBDust()
        {
            InitializeComponent();
        }

        private void RGBDust_Load(object sender, EventArgs e)
        {
            // Get Port List
            Port_Box.DataSource = SerialPort.GetPortNames();
        }

        private SerialPort _Port;

        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM1";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.DataReceived += Port_DataReceived;
                }
                return _Port;
            }
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (!Port.IsOpen)
            {
                // New Connecting
                Port.PortName = Port_Box.SelectedItem.ToString();
                Port.BaudRate = 9600;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.Handshake = Handshake.None;
                Port.StopBits = StopBits.One;

                try
                {
                    // Connect
                    Port.Open();
                }
                catch (Exception ex) { MessageBox.Show(String.Format("[ERR] {0}", ex.Message)); }
            }
            else
            {
                // Disconnect
                Port.Close();
            }

            // Status
            IsOpen = Port.IsOpen;
        }

        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                    MessageBox.Show("Connecting Success");
                    Connect_Button.Text = "Disconnect";

                    Port_Box.Enabled = false;
                    Sensor_Monitor.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Disconnected");
                    Connect_Button.Text = "Connecting";

                    Port_Box.Enabled = true;
                    Sensor_Monitor.Enabled = false;
                }
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            String msg = Port.ReadExisting();
        }
    }
}
