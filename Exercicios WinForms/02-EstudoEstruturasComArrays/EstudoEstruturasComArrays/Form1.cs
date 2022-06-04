using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEstruturasComArrays
{
    public partial class Form1 : Form
    {

        // definir estrutura de camopos
        struct Registo
        {
            public int numero;
            public string nome;
            public double nota;
        }


        // definir uma array do tipo da estrutura
        Registo[] arrayRegistos = new Registo[10];

        int numeroRegistos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // preencher o 1ª celula do array 
            arrayRegistos[0].numero = 100;
            arrayRegistos[0].nome = "ISLA";
            arrayRegistos[0].nota = 20;
            numeroRegistos = 1;

            MostraNaLista();
        }

      

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            bool sucessoNumero = int.TryParse(textBoxNumero.Text, out int numero);
            bool sucessoNota = double.TryParse(textBoxNumero.Text, out double nota);

            if (sucessoNumero == false || sucessoNota == false)
            {
                MessageBox.Show("Dados invalidos!", "Estruturas com arrays", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numeroRegistos == 9)
            {
                MessageBox.Show("Limite do array alcançado!", "Estruturas com arrays", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int indice = numeroRegistos + 1;

            arrayRegistos[indice].numero = numero;
            arrayRegistos[indice].nome = textBoxNome.Text;
            arrayRegistos[indice].nota = nota;

            numeroRegistos++;

            textBoxNumero.Clear();
            textBoxNome.Clear();
            textBoxNota.Clear();
            textBoxNumero.Focus();

            MostraNaLista();

        }
        void MostraNaLista()
        {
            listBoxDados.Items.Clear();

            for (int i = 0; i < arrayRegistos.Length; i++)
            {
                if (arrayRegistos[i].numero != 0)
                {
                    listBoxDados.Items.Add(arrayRegistos[i].numero +
                                           "-" + arrayRegistos[i].nome +
                                           "-" + arrayRegistos[i].nota);
                }
            }

        }

    }
}
