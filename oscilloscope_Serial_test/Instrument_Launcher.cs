using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oscilloscope_Serial_test
{
    public partial class instrument_Launcher : Form
    {
        public instrument_Launcher()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Oscilloscope scope = new Oscilloscope();
            scope.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            F_Gen fgen = new F_Gen();
            fgen.Show();
        }
    }
}
