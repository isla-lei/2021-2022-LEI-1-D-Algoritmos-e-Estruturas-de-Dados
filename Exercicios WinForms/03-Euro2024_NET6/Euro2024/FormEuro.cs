using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euro2024
{
    public partial class FormEuro : Form
    {
        public FormEuro()
        {
            InitializeComponent();
        }

        private void FormEuro_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

            bool sucesso = int.TryParse(textBoxNumero.Text, out int numero);
            if (sucesso == false)
            {
                MessageBox.Show("Número incorreto!", "Euro2020", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sucesso = int.TryParse(textBoxCapacidade.Text, out numero);
            if (sucesso == false)
            {
                MessageBox.Show("Capacidade incorreta!", "Euro2020", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            // 1. criar um novoregisto do tipo da struct RegistoEstadios
            ClassFuncoesGlobais.RegistoEstadios RegistoEstadio;

            // preencher os campos
            RegistoEstadio.NumeroEstadio = int.Parse(textBoxNumero.Text);
            RegistoEstadio.NomeEstadio = textBoxNome.Text;
            RegistoEstadio.Capacidade = int.Parse(textBoxCapacidade.Text);

            // 2. redimensionar o array
            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            Array.Resize(ref ClassFuncoesGlobais.ArrayEstadios, tam + 1);

            // Array.Resize<ClassFuncoesGlobais.RegistoEstadios>(ref ClassFuncoesGlobais.arrayEstadios, tam + 1);

            // 3. adicionar o registo ao arrayEstadios
            ClassFuncoesGlobais.ArrayEstadios[tam] = RegistoEstadio;


            //dataGridViewDados.DataSource = ClassFuncoesGlobais.arrayEstadios;
            ListaGrid();

            Limpar();
            textBoxNumero.Focus();
        }

        private void textBoxNumero_Leave(object sender, EventArgs e)
        {
            bool sucesso = int.TryParse(textBoxNumero.Text, out int numero);

            if (sucesso == false)
            {
                return; // Termina
            }

            // Procurar numero de estadio no ArrayEstadios
            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            for (int i = 0; i < tam; i++)
            {
                if (ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio == numero)
                {
                    textBoxNome.Text = ClassFuncoesGlobais.ArrayEstadios[i].NomeEstadio;
                    textBoxCapacidade.Text = ClassFuncoesGlobais.ArrayEstadios[i].Capacidade.ToString();
                    break; // Termina pesquisa
                }
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            bool sucesso = int.TryParse(textBoxNumero.Text, out int numero);
            if (sucesso == false)
            {
                return; // Termina
            }

            // Procurar numero de estadio no ArrayEstadios para alterar
            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            for (int i = 0; i < tam; i++)
            {
                if (ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio == numero)
                {
                    // Alterar
                    ClassFuncoesGlobais.ArrayEstadios[i].NomeEstadio = textBoxNome.Text;
                    ClassFuncoesGlobais.ArrayEstadios[i].Capacidade = int.Parse(textBoxCapacidade.Text);
                }
            }


            ListaGrid();
            Limpar();
            textBoxNumero.Focus();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            bool sucesso = int.TryParse(textBoxNumero.Text, out int numero);
            if (sucesso == false)
            {
                return;// Termina
            }

            // Procurar numero de estadio no ArrayEstadios para eliminar
            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            for (int i = 0; i < tam; i++)
            {
                if (ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio == numero)
                {
                    // Encontrou, Eliminar
                    // A parir desta posicao (i) até ao final do array, reoordenar o array, a posicao j = posicao j + 1
                    for (int j = i; j < tam - 1; j++)
                    {
                        ClassFuncoesGlobais.ArrayEstadios[j] = ClassFuncoesGlobais.ArrayEstadios[j + 1];
                    }

                    // Redimensionar o array, para ter menos uma celula
                    Array.Resize(ref ClassFuncoesGlobais.ArrayEstadios, tam - 1);

                    break; // finaliza pesquisa
                }
            }


            ListaGrid();

            Limpar();
            textBoxNumero.Focus();

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string FileName = "DadosEstadios.lei";
            StreamWriter FicheiroEscrita = new StreamWriter(FileName);

            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            FicheiroEscrita.WriteLine("Nº Estádio, Nome Estadio, Capacidade");
            for (int i = 0; i < tam; i++)
            {

                FicheiroEscrita.WriteLine(ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio + ", " +
                                          ClassFuncoesGlobais.ArrayEstadios[i].NomeEstadio + ", " +
                                          ClassFuncoesGlobais.ArrayEstadios[i].Capacidade);
            }
            FicheiroEscrita.Close();

        }

        private void buttonGuardarComo_Click(object sender, EventArgs e)
        {
            SaveFileDialog janelaGuardar = new SaveFileDialog();
            janelaGuardar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            janelaGuardar.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (janelaGuardar.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = janelaGuardar.FileName;
                StreamWriter FicheiroEscrita = new StreamWriter(FileName);

                int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
                FicheiroEscrita.WriteLine("Nº Estádio, Nome Estadio, Capacidade");
                for (int i = 0; i < tam; i++)
                {
                    FicheiroEscrita.WriteLine(ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio + ", " +
                                                ClassFuncoesGlobais.ArrayEstadios[i].NomeEstadio + ", " +
                                                ClassFuncoesGlobais.ArrayEstadios[i].Capacidade);
                }
                FicheiroEscrita.Close();
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Close();
        }


        //
        // FUNÇÕES
        void CarregaDados()
        {
            // Apagar todos os dados do ArrayEstadios
            Array.Resize(ref ClassFuncoesGlobais.ArrayEstadios, 0);

            string fileName = "DadosEstadios.lei";
            if (File.Exists(fileName)) // Verifica se existe ficheiro
            {
                StreamReader FicheiroLeitura = new StreamReader(fileName);

                // Como a primeira linha é titulo, ignorar
                FicheiroLeitura.ReadLine(); //avança a 1º linha

                string linha;
                // ler ate ao final do ficheiro (e tratar cada linha)
                while (!FicheiroLeitura.EndOfStream)
                {
                    linha = FicheiroLeitura.ReadLine();
                    // separar a linha atraves da virgula e colocar cada campo num vetor
                    string[] campos = linha.Split(',');

                    // 1. criar um novoregisto do tipo da struct RegistoEstadios
                    ClassFuncoesGlobais.RegistoEstadios registoEstadio;

                    // preencher os campos
                    registoEstadio.NumeroEstadio = int.Parse(campos[0]);
                    registoEstadio.NomeEstadio = campos[1]; ;
                    registoEstadio.Capacidade = int.Parse(campos[2]);

                    // 2. redimensionar o array
                    int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
                    Array.Resize(ref ClassFuncoesGlobais.ArrayEstadios, tam + 1);

                    // 3. adicionar o registo ao arrayEstadios
                    ClassFuncoesGlobais.ArrayEstadios[tam] = registoEstadio;
                }

                FicheiroLeitura.Close();
                ListaGrid();
            }
            textBoxNumero.Focus();
        }

        void ListaGrid()
        {
            dataGridViewDados.Rows.Clear();

            int tam = ClassFuncoesGlobais.ArrayEstadios.Length;
            for (int i = 0; i < tam; i++)
            {
                dataGridViewDados.Rows.Add();
                dataGridViewDados.Rows[i].Cells[0].Value = ClassFuncoesGlobais.ArrayEstadios[i].NumeroEstadio;
                dataGridViewDados.Rows[i].Cells[1].Value = ClassFuncoesGlobais.ArrayEstadios[i].NomeEstadio;
                dataGridViewDados.Rows[i].Cells[2].Value = ClassFuncoesGlobais.ArrayEstadios[i].Capacidade;
            }
        }

        void Limpar()
        {
            textBoxNumero.Clear();
            textBoxNome.Clear();
            textBoxCapacidade.Clear();
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
