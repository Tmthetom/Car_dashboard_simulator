using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_dashboard_simulator
{
    public partial class FormMain : Form
    {
        #region Initialization

        public FormMain()
        {
            InitializeComponent();
        }

        #endregion Initialization

        #region Control

        Functions.PolynomialRegression polynomialRegression = new Functions.PolynomialRegression();

        /// <summary>
        /// Speed changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBarSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelSpeedValue.Text = trackBarSpeed.Value.ToString();
            mySerial.WriteLine("S" + polynomialRegression.Speed(trackBarSpeed.Value));
        }

        // Revolutions changed
        private void TrackBarRevolutions_ValueChanged(object sender, EventArgs e)
        {
            mySerial.WriteLine("R" + trackBarRevolutions.Value);
        }

        // Fuel changed
        private void TrackBarFuel_ValueChanged(object sender, EventArgs e)
        {
            mySerial.WriteLine("F" + trackBarFuel.Value);
        }

        // Temperature changed
        private void TrackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            mySerial.WriteLine("T" + trackBarTemperature.Value);
        }

        #endregion Control

        #region Connection

        private SerialPort mySerial = new SerialPort();
        private Functions.Functions myFunctions = new Functions.Functions();
        bool wasConnected = false;

        /// <summary>
        /// Connection button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonConnection_Click(object sender, EventArgs e)
        {
            // OPEN
            if (!mySerial.IsOpen) Connect();

            // CLOSE
            else Disconnect();
        }

        /// <summary>
        /// Open serialPort connection
        /// </summary>
        private void Connect()
        {
            try
            {
                // Connects
                mySerial.PortName = comboBoxPorts.Text;
                mySerial.BaudRate = 9600;
                mySerial.Open();
                wasConnected = true;

                // Set button
                buttonConnection.Text = "ODPOJIT";
                buttonConnection.BackColor = Color.Crimson;

                // Set controls
                groupBoxControl.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Chyba připojení");
            }
        }

        /// <summary>
        /// Open serialPort connection
        /// </summary>
        private void Disconnect()
        {
            try
            {
                // Set button
                buttonConnection.Text = "PŘIPOJIT";
                buttonConnection.BackColor = Color.GreenYellow;

                // Set controls
                groupBoxControl.Enabled = false;
                trackBarSpeed.Value = 0;
                trackBarRevolutions.Value = 0;
                trackBarFuel.Value = 0;
                trackBarTemperature.Value = 0;

                // Disconnect
                mySerial.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Chyba odpojení");
            }
        }

        /// <summary>
        /// Called once in period of time to check if device connected and refresh ports
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsConnected_Tick(object sender, EventArgs e)
        {
            CheckConnection();
            RefreshPorts();
        }

        /// <summary>
        /// Lock or unlock form, based on if device is connected
        /// </summary>
        private void CheckConnection()
        {
            // CLOSE if not open but was connected last time
            if (!mySerial.IsOpen && wasConnected)
            {
                Disconnect();
            }
        }

        /// <summary>
        /// Refresh ports if their are not same
        /// </summary>
        private void RefreshPorts()
        {
            // Return if serial is open
            if (mySerial.IsOpen) return;

            // Get ports
            string[] ports = SerialPort.GetPortNames();

            // Show new ports if their are not same
            if (ports.Length != comboBoxPorts.Items.Count)
            {
                comboBoxPorts.Items.Clear();  // Cear list of ports
                comboBoxPorts.Text = "";  // Clear selected port name
                textBoxDeviceName.Text = "";  // Clear selected port name
                foreach (string port in ports) comboBoxPorts.Items.Add(port);  // Add all ports
                if (ports.Length > 0) comboBoxPorts.SelectedIndex = 0;  // Select first port
                return;
            }
        }
        
        /// <summary>
        /// Show name of selected port
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDeviceName.Text = myFunctions.GetSerialDeviceName(comboBoxPorts.Text);
        }

        #endregion Connection
    }
}
