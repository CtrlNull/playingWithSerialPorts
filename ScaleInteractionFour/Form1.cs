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
            #region ~~Main~~
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
            catch (Exception ex)
            {
                lblError.Visible = true;
                txtRand.Text = ex.ToString();
            }
            #endregion
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
            // Checks if radio button is checked
            var checkedButton = groupBox1.Controls.OfType<RadioButton>()
                                  .FirstOrDefault(r => r.Checked);
            txtRand.Text = checkedButton.Text;

            serialPort1.PortName = Convert.ToString(checkedButton.Text); // Attached radio button text
            serialPort1.BaudRate = 9600; // Important* set BaudRate from scale
            serialPort1.Parity = Parity.None; // Important* set Parity from scale
        }
        #endregion

        #region Available Ports and Details
        
        void getAvaliablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            getPortDetails();

            int numbPorts = ports.Length;

            switch (numbPorts)
            {
                case 1:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    break;
                case 2:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text = ports[1];
                    break;
                case 3:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text = ports[1];
                    lblThree.Visible = true;
                    rdoThree.Visible = true;
                    rdoThree.Text = ports[2];
                    break;
                case 4:
                    rdoOne.Visible = true;
                    lblOne.Visible = true;
                    rdoOne.Text = ports[0];
                    rdoTwo.Visible = true;
                    lblTwo.Visible = true;
                    rdoTwo.Text =  ports[1];
                    lblThree.Visible = true;
                    rdoThree.Visible = true;
                    rdoThree.Text =  ports[2];
                    rdoFour.Visible = true;
                    lblFour.Visible = true;
                    rdoFour.Text = ports[3];
                    break;
            }
        }

        void getPortDetails()
        {
            using (var searcher = new ManagementObjectSearcher
                 ("SELECT * FROM WIN32_SerialPort"))
            {
                string[] portnames = SerialPort.GetPortNames();
                var ports = searcher.Get().Cast<ManagementBaseObject>().ToList();
                var tList = (from n in portnames
                             join p in ports on n equals p["DeviceID"].ToString()
                             select n + " - " + p["Caption"]).ToList();
                int list = tList.ToArray().Length;

                switch (list)
                {
                    case 1:
                        lblOne.Text = tList[0].ToString();
                        break;
                    case 2:
                        lblOne.Text = tList[0].ToString();
                        lblTwo.Text = tList[1].ToString();
                        break;
                    case 3:
                        lblOne.Text = tList[0].ToString();
                        lblTwo.Text = tList[1].ToString();
                        lblThree.Text = tList[2].ToString();
                        break;
                    case 4:
                        lblOne.Text = tList[0].ToString();
                        lblTwo.Text = tList[1].ToString();
                        lblThree.Text = tList[2].ToString();
                        lblFour.Text = tList[3].ToString();
                        break;
                }
            }
        }
        #endregion

        #region Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            portSettings();
        }
        #endregion
    }
}
