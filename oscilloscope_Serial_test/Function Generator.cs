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

namespace oscilloscope_Serial_test
{
    public partial class F_Gen : Form
    {

        private SerialPort Port = new SerialPort();
        
        public F_Gen()
        {
            InitializeComponent();
        }

        private void F_Gen_Load(object sender, EventArgs e)
        {
            try
            {
                Port = new SerialPort("COM3");
                Port.BaudRate = 115200;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.StopBits = StopBits.One;
                Port.Handshake = Handshake.None;
                Port.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void run_fgen_Click(object sender, EventArgs e)
        {
            if (wave_Type.Text == "SINE WAVE")
            {
                if (frequency.Text == "")
                {
                    Port.WriteLine("SIN100");
                }
                else
                {
                    Port.WriteLine("SIN" + frequency.Text);
                }
            }
            else if (wave_Type.Text == "SQUARE WAVE")
            {
                if (frequency.Text == "")
                {
                    Port.WriteLine("SQU100");
                }
                else
                {
                    Port.WriteLine("SQU" + frequency.Text);
                }
            }
        }
    }
}
