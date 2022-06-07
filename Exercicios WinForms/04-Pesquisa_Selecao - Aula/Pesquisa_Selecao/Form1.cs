using System;
using System.Windows.Forms;

namespace Pesquisa_Selecao
{
    public partial class Form1 : Form
    {

        // objetos (variavies) globais
        // estrutura de dados para os numeros -> array de inteiros
        private int[] arrayNumeros; // array sem dimensão, será dimensionado no botao

        private DateTime TempoI, TempoF;
        private TimeSpan Tempo;
        private string newLine = Environment.NewLine; // quebra de linha nos textboxs 


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCriarArray_Click(object sender, EventArgs e)
        {

            LimpaDados();

            labelSegundosCriar.Text = "Aguarde...";
            labelSegundosMostra.Text = "Aguarde...";

            int tamanho = int.Parse(numericUpDownQtd.Value.ToString());

            // Dimensionar o array
            arrayNumeros = new int[tamanho];

            TempoI = DateTime.Now;

            if (radioButtonAleatorio.Checked) // aleatorio
            {
                Random random = new Random();

                for (int i = 0; i < tamanho; i++)
                {
                    int valor = random.Next(1, tamanho + 1); // valores entre 1 e tamanho

                    arrayNumeros[i] = valor;
                }

            }
            else if (radioButtonOrdemCrescente.Checked) // ordem crescente
            {
                for (int i = 0; i < tamanho; i++)
                {
                    arrayNumeros[i] = i + 1;
                }

            }
            else // ordem descrescente
            {
                for (int i = 0; i < tamanho; i++)
                {
                    arrayNumeros[i] = tamanho - i;
                }
            }

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);
            labelSegundosCriar.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
            this.Refresh();


            // mostrar o array na listbox
            TempoI = DateTime.Now;

            listBoxNumeros.DataSource = arrayNumeros;

            TempoF = DateTime.Now;
            Tempo = TempoF.Subtract(TempoI);
            labelSegundosMostra.Text = Tempo.TotalSeconds.ToString("0.0000") + " segundos";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPesqSeq_Click(object sender, EventArgs e)
        {
            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            // int valor = int.Parse(textBoxValor.Text);
            int valor;

            bool sucesso = int.TryParse(textBoxValor.Text, out valor);

            if (sucesso == false)
            {
                MessageBox.Show("Valor a procurar inválido", "Pesquisa e Seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // aborta 
            }
            else
            {
                int pos = ClassPesquisaSelecao.PesquisaSequencial(arrayNumeros, valor);

                if (pos == -1)
                {
                    textBoxResultadoPesquisa.Text = $"O Número {valor} não existe no array{newLine}";
                }
                else
                {
                    textBoxResultadoPesquisa.Text = $"O Número {valor} está na posição {pos}{newLine}";
                }
            }

        }

        private void buttonPesqBin_Click(object sender, EventArgs e)
        {

            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            if (radioButtonOrdemCrescente.Checked == false)
            {
                MessageBox.Show("O Array deve estar ordenado crescentemente", "Pesquisa e Seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // aborta 
            }

            int valor;

            bool sucesso = int.TryParse(textBoxValor.Text, out valor);

            if (sucesso == false)
            {
                MessageBox.Show("Valor a procurar inválido", "Pesquisa e Seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int pos = ClassPesquisaSelecao.PesquisaBinaria(arrayNumeros, valor);

                if (pos == -1)
                {
                    textBoxResultadoPesquisa.Text = $"O Número {valor} não existe no array{newLine}";
                }
                else
                {
                    textBoxResultadoPesquisa.Text = $"O Número {valor} está na posição {pos}{newLine}";
                }
            }

        }

        private void buttonMax_Click(object sender, EventArgs e)
        {

            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            int max = ClassPesquisaSelecao.MaxSelect(arrayNumeros);
                     
            textBoxResultadoSelecao.Text += $"O Número maior é: {max} {newLine}";
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            int min = ClassPesquisaSelecao.MinSelect(arrayNumeros);

            textBoxResultadoSelecao.Text += $"O Número menor é: {min} {newLine}";
        }

        private void buttonMaxMin_Click(object sender, EventArgs e)
        {
            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            int posMax, posMin;
            ClassPesquisaSelecao.PosMaxMinSelect(arrayNumeros, out posMax, out posMin);

            textBoxResultadoSelecao.Text += $"O Número maior é: {arrayNumeros[posMax]} e o menor é: {arrayNumeros[posMin]} {newLine}";
        }

        private void buttonKesimoMaior_Click(object sender, EventArgs e)
        {
            if (VerificaArray() == false)
            {
                return; // aborta 
            }

            int[] arrayNumerosCopia = (int[])arrayNumeros.Clone();

            int k = int.Parse(numericUpDownK.Value.ToString());

            int kmaior = ClassPesquisaSelecao.KMaxSelect(arrayNumerosCopia, k);

            textBoxResultadoSelecao.Text += $"O {k}º número maior é: {kmaior} {newLine}";

            // listBoxNumeros.DataSource = arrayNumerosCopia;

        }

      
       
        private void radioButtonAleatorio_CheckedChanged(object sender, EventArgs e)
        {
            LimpaDados();
        }

        private void radioButtonOrdemCrescente_CheckedChanged(object sender, EventArgs e)
        {
            LimpaDados();
        }

        private void radioButtonOrdemDescrescente_CheckedChanged(object sender, EventArgs e)
        {
            LimpaDados();
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {

            LimpaDados();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LimpaDados()
        {
            arrayNumeros = null;
            listBoxNumeros.DataSource = null;
            textBoxResultadoPesquisa.Text = "";
            textBoxResultadoSelecao.Text = "";
            textBoxValor.Text = "";
            textBoxValorContar.Text = "";
        }

      
        bool VerificaArray()
        {

            if (arrayNumeros == null)
            {
                MessageBox.Show("Array sem dados!", "Pesquisa e Seleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;

        }
    }
}
