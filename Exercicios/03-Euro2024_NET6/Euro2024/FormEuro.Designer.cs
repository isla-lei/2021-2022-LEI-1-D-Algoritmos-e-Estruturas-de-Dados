namespace Euro2024
{
    partial class FormEuro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGuardarComo = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.capacidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroEstadio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.textBoxCapacidade = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuardarComo
            // 
            this.buttonGuardarComo.Location = new System.Drawing.Point(610, 177);
            this.buttonGuardarComo.Name = "buttonGuardarComo";
            this.buttonGuardarComo.Size = new System.Drawing.Size(164, 30);
            this.buttonGuardarComo.TabIndex = 23;
            this.buttonGuardarComo.Text = "Guardar como...";
            this.buttonGuardarComo.UseVisualStyleBackColor = true;
            this.buttonGuardarComo.Click += new System.EventHandler(this.buttonGuardarComo_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(425, 402);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 30);
            this.buttonLimpar.TabIndex = 21;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(699, 402);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 30);
            this.buttonSair.TabIndex = 20;
            this.buttonSair.Text = "Saír";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // capacidade
            // 
            this.capacidade.HeaderText = "Capacidade";
            this.capacidade.Name = "capacidade";
            this.capacidade.ReadOnly = true;
            // 
            // nomeEstadio
            // 
            this.nomeEstadio.HeaderText = "Nome Estadio";
            this.nomeEstadio.Name = "nomeEstadio";
            this.nomeEstadio.ReadOnly = true;
            this.nomeEstadio.Width = 500;
            // 
            // numeroEstadio
            // 
            this.numeroEstadio.HeaderText = "Numero";
            this.numeroEstadio.Name = "numeroEstadio";
            this.numeroEstadio.ReadOnly = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(529, 402);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(164, 30);
            this.buttonGuardar.TabIndex = 22;
            this.buttonGuardar.Text = "Guardar em ficheiro";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.AllowUserToAddRows = false;
            this.dataGridViewDados.AllowUserToDeleteRows = false;
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroEstadio,
            this.nomeEstadio,
            this.capacidade});
            this.dataGridViewDados.Location = new System.Drawing.Point(27, 19);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.ReadOnly = true;
            this.dataGridViewDados.RowTemplate.Height = 25;
            this.dataGridViewDados.Size = new System.Drawing.Size(747, 128);
            this.dataGridViewDados.TabIndex = 16;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.Red;
            this.buttonEliminar.Location = new System.Drawing.Point(249, 392);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(100, 40);
            this.buttonEliminar.TabIndex = 19;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAlterar.Location = new System.Drawing.Point(138, 392);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(100, 40);
            this.buttonAlterar.TabIndex = 18;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonInserir
            // 
            this.buttonInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInserir.Location = new System.Drawing.Point(27, 392);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(100, 40);
            this.buttonInserir.TabIndex = 17;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = false;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // textBoxCapacidade
            // 
            this.textBoxCapacidade.Location = new System.Drawing.Point(27, 310);
            this.textBoxCapacidade.Name = "textBoxCapacidade";
            this.textBoxCapacidade.Size = new System.Drawing.Size(123, 23);
            this.textBoxCapacidade.TabIndex = 15;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(27, 247);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(362, 23);
            this.textBoxNome.TabIndex = 14;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(27, 184);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(100, 23);
            this.textBoxNumero.TabIndex = 10;
            this.textBoxNumero.TextChanged += new System.EventHandler(this.textBoxNumero_TextChanged);
            this.textBoxNumero.Leave += new System.EventHandler(this.textBoxNumero_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Capacidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nº estádio:";
            // 
            // FormEuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGuardarComo);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.dataGridViewDados);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.textBoxCapacidade);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEuro";
            this.Text = "FormEuro";
            this.Load += new System.EventHandler(this.FormEuro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGuardarComo;
        private Button buttonLimpar;
        private Button buttonSair;
        private DataGridViewTextBoxColumn capacidade;
        private DataGridViewTextBoxColumn nomeEstadio;
        private DataGridViewTextBoxColumn numeroEstadio;
        private Button buttonGuardar;
        private DataGridView dataGridViewDados;
        private Button buttonEliminar;
        private Button buttonAlterar;
        private Button buttonInserir;
        private TextBox textBoxCapacidade;
        private TextBox textBoxNome;
        private TextBox textBoxNumero;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}