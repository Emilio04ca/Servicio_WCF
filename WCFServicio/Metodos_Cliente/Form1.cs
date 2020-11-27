using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metodos_Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //_____________________________________________________Metodos________________________________________________________________________________
        private void Resta_Click(object sender, EventArgs e)
        {
            Service_Metodos.Service1Client Metodo = new Service_Metodos.Service1Client();
            textBox3.Text = Metodo.RestaDeDosNumeros(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }
        private void Elevar_Click(object sender, EventArgs e)
        {
            Service_Metodos.Service1Client Metodo2 = new Service_Metodos.Service1Client();
            textBox3.Text = Metodo2.ElvarNumeroAlCuadrado(Convert.ToInt32(textBox1.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Buscar Registro en Sevice
            var numero = textBox1.Text;

            using (Service_Metodos.Service1Client Metodo3 = new Service_Metodos.Service1Client())
            {
                var persona = Metodo3.Obtenercalificacion(numero);
                var nombre = persona.Nombre;

                var Carrera = persona.Carrera;
                var No_control = persona.Numerode_control;

                listBox1.Items.Add("Nombre:     " + nombre);
                listBox1.Items.Add("Carrera:     " + Carrera);
                listBox1.Items.Add("No_Ctrl:     " + No_control);
            }

            //listBox1.Items.Add(persona.Nombre);
        }



        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //____________________________________________________Limpieza de Textbox_______________________________________________
        //____________________________________________________Limpieza de Textbox_______________________________________________
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Clear();
        }

        //________________________________________Visulizaciones_____________________________________________________________________
        //________________________________________Visulizaciones_____________________________________________________________________

        private void Metodo_2_Click(object sender, EventArgs e)
        {
            //Boton metodo 2 
            textBox1.Visible = true;
            textBox2.Visible =false;
            textBox3.Visible = true;
            
            Resta.Visible = false;
            Elevar.Visible = true;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;

            label1.Visible = true;
            label2.Visible = false;
            label3.Visible = true;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;

            listBox1.Visible = false;
            
            Metod_1.Visible = false;
            Metodo_2.Visible = false;
            Metodo_3.Visible = false;
        }

        private void Metod_1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            
            Resta.Visible = true;
            button1.Visible = true;
            Elevar.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible =false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            listBox1.Visible = false;

            Metod_1.Visible = false;
            Metodo_2.Visible = false;
            Metodo_3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Metodo regresar 
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
           
            Resta.Visible = false;
            button1.Visible = false;
            Elevar.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            listBox1.Visible = false;


            Metod_1.Visible = true;
            Metodo_2.Visible = true;
            Metodo_3.Visible = true;
        } 

        private void Metodo_3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = false;
            textBox3.Visible = false;

            Resta.Visible = false;
            button1.Visible = false;
            Elevar.Visible = false;
            button3.Visible = true;
            button4.Visible = true;


            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            listBox1.Visible = true;

            
            Metod_1.Visible = false;
            Metodo_2.Visible = false;
            Metodo_3.Visible = false;
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
