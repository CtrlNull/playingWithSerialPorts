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
            rdoOne.Visible = false;
            rdoTwo.Visible = false;
            rdoThree.Visible = false;
            rdoFour.Visible = false;
            lblOne.Visible = false;
            lblTwo.Visible = false;
            lblThree.Visible = false;
            lblFour.Visible = false;
            lblError.Visible = false;

            try
            {
                getAvaliablePorts();
            }
            catch
            {
                lblError.Visible = true;
            }

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
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    lblOne.Text = "Rand Port Name";
                    break;
                case 2:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    lblOne.Text = "Rand Port Name";
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text = ports[1];
                    lblTwo.Text = "Rand Port Name";
                    break;
                case 3:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    lblOne.Text = "Rand Port Name";
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text = ports[1];
                    lblTwo.Text = "Rand Port Name";
                    lblThree.Visible = true;
                    rdoThree.Visible = true;
                    rdoThree.Text = ports[2];
                    lblThree.Text = "Rand Port Name";
                    break;
                case 4:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    lblOne.Text = "Rand Port Name";
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text =  ports[1];
                    lblTwo.Text = "Rand Port Name";
                    lblThree.Visible = true;
                    rdoThree.Visible = true;
                    rdoThree.Text =  ports[2];
                    lblThree.Text = "Rand Port Name";
                    rdoFour.Visible = true;
                    lblFour.Visible = true;
                    rdoFour.Text = ports[3];
                    lblFour.Text = "Rand Port Name";
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
