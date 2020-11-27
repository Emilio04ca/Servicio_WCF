using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numero = textBox1.Text;

            using (Service.Service1Client Metodo3 = new Service.Service1Client())
            {
                var persona = Metodo3.
            }
        }
    }
}
