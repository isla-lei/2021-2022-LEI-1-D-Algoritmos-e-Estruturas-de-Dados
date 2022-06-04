using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Calculadora
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Código que é executado quando o form abre

            // apagar o texto do controlo labelMensagem
            labelMensagem.Text = "";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            // recuperar os valores dos textboxs

            double op1, op2, resultdo;

            //if (textBoxOp1.Text=="")
            //{
            //    textBoxOp1.Text = "0";
            //}

            //if (textBoxOp2.Text == "")
            //{
            //    textBoxOp2.Text = "0";
            //}

            VerificaValores();

            op1 = double.Parse(textBoxOp1.Text);
            op2 = double.Parse(textBoxOp2.Text);
            resultdo = op1 - op2;

            textBoxResultado.Text = resultdo.ToString();
            labelMensagem.Text = "Subtração";
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            double op1, op2, resultdo;

            VerificaValores();

            op1 = double.Parse(textBoxOp1.Text);
            op2 = double.Parse(textBoxOp2.Text);
            resultdo = op1 + op2;

            textBoxResultado.Text = resultdo.ToString();
            labelMensagem.Text = "Soma";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            double op1, op2, resultdo;

            VerificaValores();

            op1 = double.Parse(textBoxOp1.Text);
            op2 = double.Parse(textBoxOp2.Text);
            resultdo = op1 * op2;

            textBoxResultado.Text = resultdo.ToString();
            labelMensagem.Text = "Multiplicação";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double op1, op2, resultdo;

            VerificaValores();

            op1 = double.Parse(textBoxOp1.Text);
            op2 = double.Parse(textBoxOp2.Text);

            if (op2 == 0)
            {
                MessageBox.Show("Impossivel! Dividendo zero!", "Calculador", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                resultdo = op1 / op2;
                textBoxResultado.Text = resultdo.ToString();
            }

            labelMensagem.Text = "Divisão";
        }

        void VerificaValores()
        {

            if (textBoxOp1.Text == "")
            {
                textBoxOp1.Text = "0";
            }

            if (textBoxOp2.Text == "")
            {
                textBoxOp2.Text = "0";
            }

        }

        private void textBoxOp1_TextChanged(object sender, EventArgs e)
        {
            // Codigo que é executado sempre que o texto neste "objecto" é alterado 
            // ou seja, o utilizador ao digitar.... 

            // verificar se é numero...
            // tecnica: tentar converter para double o que o utilizador vai escrevendo se não conseguir, não é numnero


            if (textBoxOp1.Text != "")
            {
                if (double.TryParse(textBoxOp1.Text, out double numero) == false)
                {
                    MessageBox.Show("Introduza um valor numérico!", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxOp1.Clear();
                }
            }          
        }

        private void textBoxOp2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxOp2.Text != "")
            {
                if (double.TryParse(textBoxOp2.Text, out double numero) == false)
                {
                    MessageBox.Show("Introduza um valor numérico!", "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxOp2.Clear();
                }
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {

            Application.Exit();
            // Close();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxOp1.Clear();
            textBoxOp2.Clear();
            textBoxResultado.Clear();
            labelMensagem.Text = "";
        }

        // variaveis globais
        int numeroForm = 0;
        int X;
        int Y;

        private void buttonNovaCalc_Click(object sender, EventArgs e)
        {
            //Criar um novo form a partir do formCalc, ou seja criar
            //um objeto (ou intancia) da class formCalc

            FormCalc novoForm = new FormCalc();

            numeroForm = numeroForm + 1;

            novoForm.StartPosition = FormStartPosition.Manual;
            novoForm.Text = "Calculdora nº " + numeroForm;
            X = X + 1;
            Y = Y + 10;
            novoForm.Location = new Point(X, Y);
            novoForm.buttonNovaCalc.Enabled = false;

            novoForm.Show();
        }

        private void buttonFormVazio_Click(object sender, EventArgs e)
        {
            Form outroForm = new Form();
            outroForm.Show();
        }

        private void buttonFecharTudo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    } // class
} // namespace
