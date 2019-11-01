using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_Visor.ReadOnly = true;
            txt_Visor2.ReadOnly = true;
        }

        double v1, v2, resultado;
        char op;

        private void Btn_1_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("1");
            txt_Visor2.Text += ("1");
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("2");
            txt_Visor2.Text += ("2");
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("3");
            txt_Visor2.Text += ("3");
        }

        private void Btn_4_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("4");
            txt_Visor2.Text += ("4");
        }

        private void Btn_5_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("5");
            txt_Visor2.Text += ("5");
        }

        private void Btn_6_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("6");
            txt_Visor2.Text += ("6");
        }

        private void Btn_7_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("7");
            txt_Visor2.Text += ("7");
        }

        private void Btn_8_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("8");
            txt_Visor2.Text += ("8");
        }

        private void Btn_9_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("9");
            txt_Visor2.Text += ("9");
        }

        private void Btn_soma_Click(object sender, EventArgs e)
        {
            if (txt_Visor.Text == "")
            {
                MessageBox.Show("Primeiro digite um valor");
            }
            else
            {
                v1 = double.Parse(txt_Visor.Text);
                op = '+';
                txt_Visor.Clear();
                txt_Visor2.Text += " + ";
            }
        }
        private void Btn_subtracao_Click(object sender, EventArgs e)
        {
            if (txt_Visor.Text == "")
            {
                MessageBox.Show("Primeiro digite um valor");
            }
            else
            {
                v1 += double.Parse(txt_Visor.Text);
                op = '-';
                txt_Visor.Clear();
                txt_Visor2.Text += " - ";
            }
        }

        private void Btn_multiplicacao_Click(object sender, EventArgs e)
        {
            if (txt_Visor.Text == "")
            {
                MessageBox.Show("Primeiro digite um valor");
            }
            else
            {
                v1 = double.Parse(txt_Visor.Text);
                op = '*';
                txt_Visor.Clear();
                txt_Visor2.Text += " * ";
            }
        }

        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            if (txt_Visor.Text == "")
            {
                MessageBox.Show("Primeiro digite um valor");
            }
            else
            {
                v1 = double.Parse(txt_Visor.Text);
                op = '/';
                txt_Visor.Clear();
                txt_Visor2.Text += " / ";
            }
        }

        private void Btn_igual_Click(object sender, EventArgs e)
        {
            v2 = double.Parse(txt_Visor.Text);
            switch (op)
            {
                case '+':
                    resultado = v1 + v2;
                    break;
                case '-':
                    resultado = v1 - v2;
                    break;
                case '*':
                    resultado = v1 * v2;
                    break;
                case '/':
                    if (v2 == 0)
                    {
                        MessageBox.Show("Divisão por 0 não existe");
                    }
                    else
                    {
                        resultado = v1 / v2;
                    }
                    break;
            }
                txt_Visor2.Text += " = " + resultado;
                txt_Visor.Text = resultado.ToString();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            txt_Visor.Clear();
            txt_Visor2.Clear();
        }

        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            try
            {
                txt_Visor.Text = txt_Visor.Text.Substring(0, txt_Visor.Text.Length - 1);
            }
            catch
            {

            }
            try
            {
                txt_Visor2.Text = txt_Visor2.Text.Substring(0, txt_Visor2.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void Btn_0_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += ("0");
            txt_Visor2.Text += ("0");
        }

        private void Bnt_Virgula_Click(object sender, EventArgs e)
        {
            txt_Visor.Text += (",");
            txt_Visor2.Text += (",");
        }
    }
}
