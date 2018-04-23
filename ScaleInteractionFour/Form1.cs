using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace ScaleInteractionFour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;

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


        }
    }
}
