namespace Euro2024
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChamaFormEuro();
        }

        private void euroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChamaFormEuro();
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAboutBox formAboutBox = new FormAboutBox();
            formAboutBox.ShowDialog();

        }

        private void saírToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //
        // FUNÇÕES
        void ChamaFormEuro()
        {
            FormEuro formEuro = new FormEuro(); // Cria uma estância (objeto) da classe FormEuro
            formEuro.MdiParent = this; // Contexto atual -> FormMenu
            formEuro.Show();

        }

    }
}