using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0;
        decimal valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = 0;
            valor2 = 0;
            operacao = "";
            labelOperacao4.Text = "";
            txtResultado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor2 = 0;
            txtResultado.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                // limpando  o txt
                txtResultado.Text = "";

                operacao = "DIVISAO";
                labelOperacao4.Text = "/";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
           txtResultado.Text = txtResultado.Text + "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                // limpando  o txt
                txtResultado.Text = "";

                operacao = "SOMA";
                labelOperacao4.Text = "+";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor2 = decimal.Parse(txtResultado.Text, System.Globalization.CultureInfo.InvariantCulture);
                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                if (operacao == "SUBTRACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                if (operacao == "MULTIPLICACAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                if (operacao == "DIVISAO")
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
           
            if (txtResultado.Text !="")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                // limpando  o txt
                txtResultado.Text = "";

                operacao = "SUBTRACAO";
                labelOperacao4.Text = "-";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                // limpando  o txt
                txtResultado.Text = "";

                operacao = "MUTIPLICACAO";
                labelOperacao4.Text = "X";
            }
        }
    }
}
