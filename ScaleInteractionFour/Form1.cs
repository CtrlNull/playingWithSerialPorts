using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Management;
using System.Linq;

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

        }
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
        void grpBox_Validated(object sender, EventArgs e)
        {
            GroupBox g = sender as GroupBox;
            var a = from RadioButton r in g.Controls
                    where r.Checked == true
                    select r.Name;
            var strChecked = a.First();
            txtRand.Text = strChecked;
        }

        void portSettings()
        {
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                  .FirstOrDefault(r => r.Checked);
            txtRand.Text = checkedButton.Text;

            //serialPort1.PortName = Convert.ToString(cboPorts.Text); // find selected radio button

            serialPort1.BaudRate = 9600; // Important* set BaudRate from scale
            serialPort1.Parity = Parity.None; // Important* set Parity from scale

        }
        #endregion

        #region Available Ports
        void getAvaliablePorts()
        {
            String[] ports = SerialPort.GetPortNames();

            int numbPorts = ports.Length;

            switch (numbPorts)
            {
                case 1:
                    rdoOne.Text = "Rand Port Name, " + ports[0];
                    break;
                case 2:
                    rdoTwo.Visible = true;
                    rdoOne.Text = "Rand Port Name, " + ports[0];
                    rdoTwo.Text = "Rand Port Name, " + ports[1];
                    break;
                case 3:
                    rdoTwo.Visible = true;
                    rdoThree.Visible = true;
                    rdoOne.Text = "Rand Port Name, " + ports[0];
                    rdoTwo.Text = "Rand Port Name, " + ports[1];
                    rdoThree.Text = "Rand Port Name, " + ports[2];

                    break;
                case 4:
                    rdoTwo.Visible = true;
                    rdoThree.Visible = true;
                    rdoFour.Visible = true;
                    rdoOne.Text = "Rand Port Name, " + ports[0];
                    rdoTwo.Text = "Rand Port Name, " + ports[1];
                    rdoThree.Text = "Rand Port Name, " + ports[2];
                    rdoFour.Text = "Rand Port Name, " + ports[3];
                    break;
            }


            void getPortDetails()
            {
                // TODO: find a way to list port details
            }


            #endregion
        }


        private void button1_Click(object sender, EventArgs e)
        {
            portSettings();
        }
    }
}
