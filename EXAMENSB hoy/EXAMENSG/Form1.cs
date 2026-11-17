using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENSG
{
    
    public partial class Form1 : Form
    {
        Matriz x1, x2, x3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = new Matriz();
            x2 = new Matriz();
            x3 = new Matriz();
        }

        //CARGAR X1

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.CargarRandom(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
            textBox5.Text = x1.Descargar();
        }

        //DESCARGAR X1
        private void descargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox6.Text = x1.Descargar();
        }

    
      

        //DESCARGAR X3
        private void descargarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
        }

        //EXAMEN LLAMADAS

        //LLAMADA PREGUNTA 1 

        private void pregunta1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x1.ejercicio1();
        }

        //LLAMADA PREGUNTA 2
        private void pregunta2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //x1.SegmentarTriangular();
        }



        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {


        }


        private void descargarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
