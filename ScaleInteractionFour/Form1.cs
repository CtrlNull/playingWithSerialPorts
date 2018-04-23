using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;

namespace ScaleInteractionFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rdoTwo.Visible = false;
            rdoThree.Visible = false;
            rdoFour.Visible = false;

            getAvaliablePorts(); // Sets ports buttons/ boxes

            #region port Open/Close
            // Open Port
            void openPort()
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                else
                {
                    serialPort1.Close();
                    serialPort1.Open();
                }
            }

            // Close Port
            void closePort()
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    serialPort1.Dispose(); // clears
                }
            }
            #endregion

            #region Port Settings
            void portSettings()
            {
                serialPort1.PortName = Convert.ToString(cboPorts.Text);
                serialPort1.BaudRate = 9600; // Important* set BaudRate from scale
                serialPort1.Parity = Parity.None; // Important* set Parity from scale

            }
            #endregion

            #region Available Ports
            void getAvaliablePorts()
            {
                String[] ports = SerialPort.GetPortNames();
                cboPorts.Items.AddRange(ports);

                int numbPorts = ports.Length;
                txtRand.Text = numbPorts.ToString();
                //TODO: go through ports array and display on radio buttons
                    


                void getPortDetails()
                {
                    // TODO: find a way to list port details
                }


                #endregion
            }
        }
        
    }
}
