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

namespace new_oscilloscope_test
{
    public partial class Form1 : Form
    {
        SerialPort Port;
        string PORT_NUMBER = "3";
        private double[] plot_Array = new double[30];
        private string Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Port = new SerialPort("COM" + PORT_NUMBER.ToString());
                Port.BaudRate = 115200;
                Port.DataBits = 8;
                Port.Parity = Parity.None;
                Port.StopBits = StopBits.One;
                Port.Handshake = Handshake.None;
                Port.DtrEnable = true;
                Port.NewLine = Environment.NewLine;
                Port.ReceivedBytesThreshold = 1024;
                Port.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error accessing port." + Environment.NewLine + ex.Message, "Port Error!!!", MessageBoxButtons.OK);
                Port.Dispose();
                Application.Exit();
            }   
        }


        private void ReadEvent() 
        {
            byte[] buffer = new byte[9];  
            Action kickoffRead = null;  
            kickoffRead = (Action)(() => Port.BaseStream.BeginRead(buffer, 0, buffer.Length, delegate(IAsyncResult ar)  
            {  
                try  
                {  
                    int count = Port.BaseStream.EndRead(ar);  
                    byte[] dst = new byte[count];
                    Buffer.BlockCopy(buffer, 0, dst, 0, count);  
                    RaiseAppSerialDataEvent(dst);  
                }  
                catch (Exception exception)  
                {
                     MessageBox.Show(exception.ToString());
                }  
            kickoffRead();  
            }, null)); kickoffRead();  
         }  
        
        //To decode the received data from the port.   
        private void RaiseAppSerialDataEvent(byte[] Data)  
        {
            Result = Encoding.Default.GetString(Data);

            //Result = Encoding.Default.GetString(Data, 0, Data.Length);
            //char[] result = new char[Data.Length / sizeof(char)];
            //Buffer.BlockCopy(Data, 0, result, 0, Data.Length);
            //string res = new string(result);
            //Result = res;
            //char[] characters = Data.Select(b => (char)b).ToArray();
            //string res = new string(characters);
            //string res1 = res.Replace("A", "");
            //string res2 = res1.Replace("B", "");
            //string res3 = res2.Replace(" ", "");
            //foreach (char b in res3)
            //{
            //    if (b > '0' || b < '9')
            //    {
            //        int a = Convert.ToInt32(res3);

            //        textBox1.Invoke((Action)delegate
            //        {

            //            textBox1.AppendText(Result);

            //        });
            //    }
            //}

            //int a = TryParseInt32(res3) ?? default(int);



            try
            {
                this.Invoke(new EventHandler(display_data));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
            
               
           //return Result;
        }

        public static int? TryParseInt32(string text)
        {
            int value;
            if (int.TryParse(text, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        private void display_data(object sender, EventArgs e)
        {
            textBox1.AppendText(Result);
            //textBox1.AppendText(Convert.ToString(Result.Length + "\n"));

            //string[] my_data = Result.Split('B');

            //string val1 = my_data[0].Trim();

            //StringBuilder sb = new StringBuilder();

            //foreach (char b in val1)
            //{

            //    if ((b >= '0' && b <= '9'))
            //    {
            //        sb.Append(b);
            //    }
            //}


            //StringBuilder sb1 = new StringBuilder();

            //foreach (char b in val2)
            //{

            //    if ((b >= '0' && b <= '9'))
            //    {
            //        sb1.Append(b);
            //    }
            //}

            //if (Result.Length == 9)
            //{
            //    string value1 = Result.Substring(1, 3);
            //    string value2 = Result.Substring(5, 3);

            //    int data1 = Convert.ToInt32(value1);
            //    int data2 = Convert.ToInt32(value2);

            //    double plot = data1 - data2;

            //    textBox1.AppendText(Result + " " + value1 + " " + value2);

            //    plot_Array[plot_Array.Length - 1] = plot;

            //    Array.Copy(plot_Array, 1, plot_Array, 0, plot_Array.Length - 1);

            //    if (chart1.IsHandleCreated)
            //    {
            //        this.Invoke((MethodInvoker)delegate { Update_Chart(); });
            //    }
            //    else
            //    {
            //        //.....
            //    }
            //}                                
        }


        private void button1_Click(object sender, EventArgs e)
        {

            ReadEvent();

        }

        private void Update_Chart()
        {
            chart1.Series["serialRead"].Points.Clear();

            for (int i = 0; i < plot_Array.Length - 1; ++i)
            {
                chart1.Series["serialRead"].Points.AddY(plot_Array[i]);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox1.Text = "true";
            }
            else
            {
                checkBox1.Text = " false";
            }
        }
    } 
} 
