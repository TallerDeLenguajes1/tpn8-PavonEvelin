using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP8
{
    public partial class Form1 : Form
    {
        Calculadora miCalculadora;
        List<string> historial;
        float numero1f, numero2f;
        char operador;
        public Form1()
        {
            InitializeComponent();
            miCalculadora = new Calculadora();
            historial = new List<string>();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "+";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "-";
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "*";
        }

        private void btnCociente_Click(object sender, EventArgs e)
        {
            TBPantalla.Text += "/";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            TBPantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string pantalla = TBPantalla.Text;
            for (int i = 0; i < pantalla.Length; i++)
            {
                if(pantalla.Substring(i,1) == "+" || pantalla.Substring(i,1) == "-" || 
                   pantalla.Substring(i,1) == "*" || pantalla.Substring(i,1) == "/")
                {
                    operador = char.Parse(pantalla.Substring(i,1));
                    //TBPantalla.Text = operador.ToString();
                }
            }
            //TBPantalla.Text += operador.ToString();
            string[] numeros = pantalla.Split(operador);
            numero1f = float.Parse(numeros[0]);
            numero2f = float.Parse(numeros[1]);

            string resultado;
            miCalculadora = new Calculadora(numero1f, numero2f);
            switch (operador)
            {
                case '+':
                    //resultado = miCalculadora.Suma().ToString();
                    //TBPantalla.Text += " = ";
                    TBPantalla.Clear();
                    TBPantalla.Text = miCalculadora.Suma().ToString();
                    break;

                case '-':
                    TBPantalla.Clear();
                    TBPantalla.Text = miCalculadora.Resta().ToString();
                    break;

                case '*':
                    TBPantalla.Clear();
                    TBPantalla.Text = miCalculadora.Multiplicacion().ToString();
                    break;

                case '/':
                    if(numero2f != 0)
                    {
                        TBPantalla.Clear();
                        TBPantalla.Text = miCalculadora.Division().ToString();
                    }
                    else
                    {
                        TBPantalla.Text = "Error. No existe la division entre cero"; 
                    }
                    
                    break;
            }
            string elementoHistorial = miCalculadora.Fecha + " --> " + pantalla + " = " + TBPantalla.Text;
            historial.Add(elementoHistorial);
            Historial.DataSource = null;
            Historial.DataSource = historial;
        }

        private void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Historial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            historial.Clear();
            Historial.DataSource = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
