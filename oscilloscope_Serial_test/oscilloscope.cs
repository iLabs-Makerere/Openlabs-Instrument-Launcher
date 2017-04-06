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
using rtChart;
using System.Windows.Forms.DataVisualization.Charting;
using System.Text.RegularExpressions;
using System.Threading;

namespace oscilloscope_Serial_test
{
    public partial class Oscilloscope : Form
    {
        private SerialPort port = new SerialPort();
        private string my_data;
        private double[] plot_Array = new double[30];
        private double[] plot_Array1 = new double[30];

       
        public Oscilloscope()
        {
            InitializeComponent();
            get_available_ports();
            port.BaudRate = 115200;
            data_text.ReadOnly = true;
            check_channel0.Checked = true;
            check_channel1.Checked = false;

            if (check_channel0.Checked == true)
            {
                check_channel0.Text = "Enabled";
                
            }
            else
            {
                check_channel0.Text = "Disabled";
            }

            if (check_channel1.Checked == true)
            {
                check_channel1.Text = "Enabled";
            }
            else
            {
                check_channel1.Text = "Disabled";
            }

        }

        void get_available_ports()
        {
            string[] ports = SerialPort.GetPortNames();
            serial_port.Items.AddRange(ports);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen)
                {
                    port.Close();
                }
                
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }

        }

        private void open_port_Click(object sender, EventArgs e)
        {
            try
            {
                port.PortName = serial_port.Text;
               
                port.Open();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void recieve_data_Click(object sender, EventArgs e)
        {
            port.Parity = Parity.None;
            port.DataBits = 8;
            port.StopBits = StopBits.One;

            port.DataReceived += port_DataReceived;
               
            try
            {

            }
            catch(Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }

            
        }
         
        void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                my_data = port.ReadLine();
               
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            try
            {
                this.Invoke(new EventHandler(display_data));
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message);
            }
            
           
        }

        private void display_data(object sender, EventArgs e)
        {

           if (my_data.Length == 13)
           {
               string val1 = my_data.Substring(1, 3);
               string val2 = my_data.Substring(5, 3);
               string val3 = my_data.Substring(9, 3);
               int data1 = Convert.ToInt32(val1);
               int data2 = Convert.ToInt32(val2);
               int data3 = Convert.ToInt32(val3);

               double plot = Math.Round((data1 - data3) * (5.0/1023.0), 10);
               double plot1 = Math.Round((data2 - data3) * (5.0/1023.0), 0);
               //data_text.AppendText(Convert.ToString(my_data.Length + "\n"));
               data_text.AppendText(my_data + "  " + val1 + "   " + val2 + " " + val3 + "\n");

               plot_Array[plot_Array.Length - 1] = 2 * plot;
               plot_Array1[plot_Array1.Length - 1] = 2 * plot1;

               //data_text.AppendText(plot1 + "\n");
               Array.Copy(plot_Array, 1, plot_Array, 0, plot_Array.Length - 1);
               Array.Copy(plot_Array1, 1, plot_Array1, 0, plot_Array1.Length - 1);

               if (chart1.IsHandleCreated)
               {
                   this.Invoke((MethodInvoker)delegate { Update_Chart(); });
               }
               else
               {
                   //.....
               }
           }
           else
           {
               //.....
           }
        }

        private void Update_Chart()
        {
            chart1.Series["channel_0"].Points.Clear();
            chart1.Series["channel_1"].Points.Clear();
            
            for (int i = 0; i < plot_Array.Length - 1; ++i)
            {
                if (check_channel0.Checked == true)
                {
                    chart1.Series["channel_0"].Points.AddY(plot_Array[i]);
                }
                else
                {
                    //...
                }
            }

            for (int i = 0; i < plot_Array1.Length - 1; ++i)
            {
                if (check_channel1.Checked == true)
                {
                    chart1.Series["channel_1"].Points.AddY(plot_Array1[i]);                   
                }
                else
                {
                    //...
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void check_channel0_CheckedChanged(object sender, EventArgs e)
        {
            if (check_channel0.Checked == true)
            {
                check_channel0.Text = "Enabled";
            }
            else
            {
                check_channel0.Text = "Disabled";
            }
        }

        private void check_channel1_CheckedChanged(object sender, EventArgs e)
        {
            if (check_channel1.Checked == true)
            {
                check_channel1.Text = "Enabled";
            }
            else
            {
                check_channel1.Text = "Disabled";
            }
        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click_2(object sender, EventArgs e)
        {

        }

       
    }
}
