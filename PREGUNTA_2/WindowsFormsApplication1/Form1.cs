using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double aux1;
        double aux2;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }
        Clases.suma objsuma = new Clases.suma();
        Clases.resta objresta = new Clases.resta();
        Clases.multiplicacion objmulti = new Clases.multiplicacion();
        Clases.division objdiv = new Clases.division();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void sumar_Click(object sender, EventArgs e)
        {
            operador = "+";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void resultado_Click(object sender, EventArgs e)
        {
            aux2 = double.Parse(textBox1.Text);
            double OPSuma, OPResta, OPMulti,OPDiv;
            switch(operador){
                case "+":
                    OPSuma=objsuma.sumas((aux1),(aux2));
                    textBox1.Text = OPSuma.ToString();
                    break;
                case "-":
                    OPResta = objresta.restas((aux1), (aux2));
                    textBox1.Text = OPResta.ToString();
                    break;
                case "*":
                    OPMulti = objmulti.multiplicar((aux1), (aux2));
                    textBox1.Text = OPMulti.ToString();
                    break;
                case "/":
                    OPDiv = objdiv.dividir((aux1), (aux2));
                    textBox1.Text = OPDiv.ToString();
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        private void dos_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void tres_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void seis_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void siete_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void ocho_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void nueve_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void cero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void restar_Click(object sender, EventArgs e)
        {
            operador = "-";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operador = "/";
            aux1 = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
    }
}
