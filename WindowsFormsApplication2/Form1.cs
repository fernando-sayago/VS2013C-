using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Punto3D ponto = new Punto3D();
            Cajas caja = new Cajas();
            Contenedores contenedor = new Contenedores();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            //ponto.x = 0;
            //ponto.y = 0;
            //ponto.z = 0;
            label1.Text = ponto.x.ToString() + ", " + ponto.y.ToString() + ", " + ponto.z.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " || " + textBox1.Text + ", " + textBox2.Text + ", " + textBox3.Text;
        }

     
    }
}
