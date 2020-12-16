using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblResultado.Text += "9";
        }

        int valor = 0;

        private void btnSuma_Click(object sender, EventArgs e)
        {
            valor = int.Parse(lblResultado.Text);
            lblResultado.Text = "";
        }



        private void lblIgual_Click(object sender, EventArgs e)
        {
            int a = valor;
            int b = int.Parse(lblResultado.Text);

            Calculadora operacion = new Calculadora();
            lblResultado.Text = operacion.Sumar(a, b) + "";

            
            CalculadoraBinaria operacionesBinarias = new CalculadoraBinaria();
            lblResultado.Text = operacionesBinarias.Sumar(a, b);
            {

            }
        }

        private void btbBinario_Click(object sender, EventArgs e)
        {
            int a = valor;
            int b = int.Parse(lblResultado.Text);

            Calculadora operacion = new Calculadora();
            lblResultado.Text = operacion.Sumar(a, b) + "";

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

    }
}
