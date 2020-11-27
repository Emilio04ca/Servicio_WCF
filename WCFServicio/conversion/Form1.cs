using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client Metodo2 = new ServiceReference1.Service1Client();
            textBox2.Text = Metodo2.Conversion(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
