using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculadora
{
    

    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Results.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Results.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Results.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Results.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Results.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Results.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Results.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Results.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Results.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Results.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Results.Text += ".";
        }

        private void button10_Click(object sender, EventArgs e) // Igual
        {
            valor2 = decimal.Parse(Results.Text, CultureInfo.InvariantCulture);

            switch (operation)
            {
                case "Adição":
                    Results.Text = Convert.ToString(valor1 + valor2);
                    break;
                case "Subtração":
                    Results.Text = Convert.ToString(valor1 - valor2);
                    break;
                case "Multiplicação":
                    Results.Text = Convert.ToString(valor1 * valor2);
                    break;
                case "Divisão":
                    if (valor2 == 0)
                    {
                        MessageBox.Show("Erro: Divisão por zero!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Results.Text = Convert.ToString(valor1 / valor2);
                    }
                    break;
                default:
                    MessageBox.Show("Operação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

        }

        private void button14_Click(object sender, EventArgs e) //Subtração
        {
            if (Results.Text != "")
            {
            valor1 = decimal.Parse(Results.Text, CultureInfo.InvariantCulture);
            Results.Text = "";
            operation = "Subtração";
         //   OperationType.Text = "-";
        }
            else
            {
                MessageBox.Show("Coloque um valor antes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void button15_Click(object sender, EventArgs e) //Multiplicação
        {
            if (Results.Text != "")
            {
                valor1 = decimal.Parse(Results.Text, CultureInfo.InvariantCulture);
            Results.Text = "";
            operation = "Multiplicação";
          //  OperationType.Text = "X";
            }
            else
            {
                MessageBox.Show("Coloque um valor antes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e) //Divisão
        {
            if (Results.Text != "")
            {
                valor1 = decimal.Parse(Results.Text, CultureInfo.InvariantCulture);
                Results.Text = "";
                operation = "Divisão";
              //  OperationType.Text = "/";

            }
            else
            {
                MessageBox.Show("Coloque um valor antes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e) //Limpar campo CE
        {
            Results.Text = "";
          //  OperationType.Text = ""; //experimental
        }

        private void button17_Click(object sender, EventArgs e) //Limpar campo C
        {
                Results.Text = "";
          //      OperationType.Text = "";
                valor1 = 0;
                valor2 = 0;
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e) // Adição
        {
            if (Results.Text != "")
            {
                valor1 = decimal.Parse(Results.Text, CultureInfo.InvariantCulture);
                Results.Text = "";
                operation = "Adição";
          //      OperationType.Text = "+";
            } else
            {
                MessageBox.Show("Coloque um valor antes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}