
namespace Pesquisa_Selecao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSegundosCriar = new System.Windows.Forms.Label();
            this.buttonCriarArray = new System.Windows.Forms.Button();
            this.numericUpDownQtd = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonOrdemDescrescente = new System.Windows.Forms.RadioButton();
            this.radioButtonOrdemCrescente = new System.Windows.Forms.RadioButton();
            this.radioButtonAleatorio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxNumeros = new System.Windows.Forms.ListBox();
            this.labelSegundosMostra = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKesimoMaior = new System.Windows.Forms.Button();
            this.buttonContar = new System.Windows.Forms.Button();
            this.buttonKesimoMenor = new System.Windows.Forms.Button();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.buttonMaxMin = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResultadoSelecao = new System.Windows.Forms.TextBox();
            this.textBoxResultadoPesquisa = new System.Windows.Forms.TextBox();
            this.buttonPesqBin = new System.Windows.Forms.Button();
            this.buttonPesqSeq = new System.Windows.Forms.Button();
            this.textBoxValorContar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxValor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSegundosCriar);
            this.groupBox1.Controls.Add(this.buttonCriarArray);
            this.groupBox1.Controls.Add(this.numericUpDownQtd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.radioButtonOrdemDescrescente);
            this.groupBox1.Controls.Add(this.radioButtonOrdemCrescente);
            this.groupBox1.Controls.Add(this.radioButtonAleatorio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // labelSegundosCriar
            // 
            this.labelSegundosCriar.Location = new System.Drawing.Point(25, 183);
            this.labelSegundosCriar.Name = "labelSegundosCriar";
            this.labelSegundosCriar.Size = new System.Drawing.Size(328, 22);
            this.labelSegundosCriar.TabIndex = 7;
            this.labelSegundosCriar.Text = "segundos";
            this.labelSegundosCriar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCriarArray
            // 
            this.buttonCriarArray.Location = new System.Drawing.Point(25, 151);
            this.buttonCriarArray.Name = "buttonCriarArray";
            this.buttonCriarArray.Size = new System.Drawing.Size(328, 33);
            this.buttonCriarArray.TabIndex = 6;
            this.buttonCriarArray.Text = "Criar Array de  Números";
            this.buttonCriarArray.UseVisualStyleBackColor = true;
            this.buttonCriarArray.Click += new System.EventHandler(this.buttonCriarArray_Click);
            // 
            // numericUpDownQtd
            // 
            this.numericUpDownQtd.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownQtd.Location = new System.Drawing.Point(233, 99);
            this.numericUpDownQtd.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numericUpDownQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQtd.Name = "numericUpDownQtd";
            this.numericUpDownQtd.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownQtd.TabIndex = 5;
            this.numericUpDownQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQtd.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantidade de números";
            // 
            // radioButtonOrdemDescrescente
            // 
            this.radioButtonOrdemDescrescente.AutoSize = true;
            this.radioButtonOrdemDescrescente.Location = new System.Drawing.Point(25, 124);
            this.radioButtonOrdemDescrescente.Name = "radioButtonOrdemDescrescente";
            this.radioButtonOrdemDescrescente.Size = new System.Drawing.Size(177, 19);
            this.radioButtonOrdemDescrescente.TabIndex = 3;
            this.radioButtonOrdemDescrescente.Text = "Ordenada decrescentemente";
            this.radioButtonOrdemDescrescente.UseVisualStyleBackColor = true;
            this.radioButtonOrdemDescrescente.CheckedChanged += new System.EventHandler(this.radioButtonOrdemDescrescente_CheckedChanged);
            // 
            // radioButtonOrdemCrescente
            // 
            this.radioButtonOrdemCrescente.AutoSize = true;
            this.radioButtonOrdemCrescente.Location = new System.Drawing.Point(25, 93);
            this.radioButtonOrdemCrescente.Name = "radioButtonOrdemCrescente";
            this.radioButtonOrdemCrescente.Size = new System.Drawing.Size(164, 19);
            this.radioButtonOrdemCrescente.TabIndex = 2;
            this.radioButtonOrdemCrescente.Text = "Ordenada crescentemente";
            this.radioButtonOrdemCrescente.UseVisualStyleBackColor = true;
            this.radioButtonOrdemCrescente.CheckedChanged += new System.EventHandler(this.radioButtonOrdemCrescente_CheckedChanged);
            // 
            // radioButtonAleatorio
            // 
            this.radioButtonAleatorio.AutoSize = true;
            this.radioButtonAleatorio.Checked = true;
            this.radioButtonAleatorio.Location = new System.Drawing.Point(25, 62);
            this.radioButtonAleatorio.Name = "radioButtonAleatorio";
            this.radioButtonAleatorio.Size = new System.Drawing.Size(72, 19);
            this.radioButtonAleatorio.TabIndex = 1;
            this.radioButtonAleatorio.TabStop = true;
            this.radioButtonAleatorio.Text = "Aleatória";
            this.radioButtonAleatorio.UseVisualStyleBackColor = true;
            this.radioButtonAleatorio.CheckedChanged += new System.EventHandler(this.radioButtonAleatorio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(127, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar lista de números";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxNumeros);
            this.groupBox2.Controls.Add(this.labelSegundosMostra);
            this.groupBox2.Location = new System.Drawing.Point(13, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array";
            // 
            // listBoxNumeros
            // 
            this.listBoxNumeros.FormattingEnabled = true;
            this.listBoxNumeros.ItemHeight = 15;
            this.listBoxNumeros.Location = new System.Drawing.Point(120, 27);
            this.listBoxNumeros.Name = "listBoxNumeros";
            this.listBoxNumeros.Size = new System.Drawing.Size(133, 229);
            this.listBoxNumeros.TabIndex = 0;
            // 
            // labelSegundosMostra
            // 
            this.labelSegundosMostra.Location = new System.Drawing.Point(24, 254);
            this.labelSegundosMostra.Name = "labelSegundosMostra";
            this.labelSegundosMostra.Size = new System.Drawing.Size(328, 22);
            this.labelSegundosMostra.TabIndex = 8;
            this.labelSegundosMostra.Text = "segundos";
            this.labelSegundosMostra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKesimoMaior);
            this.groupBox3.Controls.Add(this.buttonContar);
            this.groupBox3.Controls.Add(this.buttonKesimoMenor);
            this.groupBox3.Controls.Add(this.numericUpDownK);
            this.groupBox3.Controls.Add(this.buttonMaxMin);
            this.groupBox3.Controls.Add(this.buttonMin);
            this.groupBox3.Controls.Add(this.buttonMax);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxResultadoSelecao);
            this.groupBox3.Controls.Add(this.textBoxResultadoPesquisa);
            this.groupBox3.Controls.Add(this.buttonPesqBin);
            this.groupBox3.Controls.Add(this.buttonPesqSeq);
            this.groupBox3.Controls.Add(this.textBoxValorContar);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxValor);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(469, 508);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operações de pesquisa e selecção";
            // 
            // buttonKesimoMaior
            // 
            this.buttonKesimoMaior.Location = new System.Drawing.Point(185, 290);
            this.buttonKesimoMaior.Name = "buttonKesimoMaior";
            this.buttonKesimoMaior.Size = new System.Drawing.Size(114, 23);
            this.buttonKesimoMaior.TabIndex = 9;
            this.buttonKesimoMaior.Text = "K-ésimo Maior";
            this.buttonKesimoMaior.UseVisualStyleBackColor = true;
            this.buttonKesimoMaior.Click += new System.EventHandler(this.buttonKesimoMaior_Click);
            // 
            // buttonContar
            // 
            this.buttonContar.Location = new System.Drawing.Point(362, 317);
            this.buttonContar.Name = "buttonContar";
            this.buttonContar.Size = new System.Drawing.Size(90, 23);
            this.buttonContar.TabIndex = 9;
            this.buttonContar.Text = "Conta";
            this.buttonContar.UseVisualStyleBackColor = true;
            // 
            // buttonKesimoMenor
            // 
            this.buttonKesimoMenor.Location = new System.Drawing.Point(185, 317);
            this.buttonKesimoMenor.Name = "buttonKesimoMenor";
            this.buttonKesimoMenor.Size = new System.Drawing.Size(114, 23);
            this.buttonKesimoMenor.TabIndex = 9;
            this.buttonKesimoMenor.Text = "K-ésimo Menor";
            this.buttonKesimoMenor.UseVisualStyleBackColor = true;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(186, 261);
            this.numericUpDownK.Maximum = new decimal(new int[] {
            900000000,
            0,
            0,
            0});
            this.numericUpDownK.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(113, 23);
            this.numericUpDownK.TabIndex = 5;
            this.numericUpDownK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownK.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonMaxMin
            // 
            this.buttonMaxMin.Location = new System.Drawing.Point(25, 317);
            this.buttonMaxMin.Name = "buttonMaxMin";
            this.buttonMaxMin.Size = new System.Drawing.Size(90, 23);
            this.buttonMaxMin.TabIndex = 9;
            this.buttonMaxMin.Text = "Max e Min";
            this.buttonMaxMin.UseVisualStyleBackColor = true;
            this.buttonMaxMin.Click += new System.EventHandler(this.buttonMaxMin_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(25, 290);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(90, 23);
            this.buttonMin.TabIndex = 8;
            this.buttonMin.Text = "Min";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(25, 263);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(90, 23);
            this.buttonMax.TabIndex = 7;
            this.buttonMax.Text = "Max";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(209, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Seleção";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(204, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Procura\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Resultado da seleção:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Resultado da pesquisa:";
            // 
            // textBoxResultadoSelecao
            // 
            this.textBoxResultadoSelecao.Location = new System.Drawing.Point(25, 379);
            this.textBoxResultadoSelecao.Multiline = true;
            this.textBoxResultadoSelecao.Name = "textBoxResultadoSelecao";
            this.textBoxResultadoSelecao.ReadOnly = true;
            this.textBoxResultadoSelecao.Size = new System.Drawing.Size(427, 107);
            this.textBoxResultadoSelecao.TabIndex = 3;
            this.textBoxResultadoSelecao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResultadoPesquisa
            // 
            this.textBoxResultadoPesquisa.Location = new System.Drawing.Point(25, 162);
            this.textBoxResultadoPesquisa.Name = "textBoxResultadoPesquisa";
            this.textBoxResultadoPesquisa.ReadOnly = true;
            this.textBoxResultadoPesquisa.Size = new System.Drawing.Size(427, 23);
            this.textBoxResultadoPesquisa.TabIndex = 3;
            this.textBoxResultadoPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonPesqBin
            // 
            this.buttonPesqBin.Location = new System.Drawing.Point(252, 97);
            this.buttonPesqBin.Name = "buttonPesqBin";
            this.buttonPesqBin.Size = new System.Drawing.Size(200, 23);
            this.buttonPesqBin.TabIndex = 2;
            this.buttonPesqBin.Text = "Pesquisa binária";
            this.buttonPesqBin.UseVisualStyleBackColor = true;
            this.buttonPesqBin.Click += new System.EventHandler(this.buttonPesqBin_Click);
            // 
            // buttonPesqSeq
            // 
            this.buttonPesqSeq.Location = new System.Drawing.Point(25, 97);
            this.buttonPesqSeq.Name = "buttonPesqSeq";
            this.buttonPesqSeq.Size = new System.Drawing.Size(200, 23);
            this.buttonPesqSeq.TabIndex = 2;
            this.buttonPesqSeq.Text = "Pesquisa sequencial";
            this.buttonPesqSeq.UseVisualStyleBackColor = true;
            this.buttonPesqSeq.Click += new System.EventHandler(this.buttonPesqSeq_Click);
            // 
            // textBoxValorContar
            // 
            this.textBoxValorContar.Location = new System.Drawing.Point(362, 290);
            this.textBoxValorContar.Name = "textBoxValorContar";
            this.textBoxValorContar.Size = new System.Drawing.Size(90, 23);
            this.textBoxValorContar.TabIndex = 1;
            this.textBoxValorContar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor a contar:";
            // 
            // textBoxValor
            // 
            this.textBoxValor.Location = new System.Drawing.Point(192, 58);
            this.textBoxValor.Name = "textBoxValor";
            this.textBoxValor.Size = new System.Drawing.Size(100, 23);
            this.textBoxValor.TabIndex = 1;
            this.textBoxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor a procurar:";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLimpar.Location = new System.Drawing.Point(737, 535);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 17;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSair.Location = new System.Drawing.Point(818, 535);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(75, 23);
            this.buttonSair.TabIndex = 18;
            this.buttonSair.Text = "Saír";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 570);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisa e Seleção";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQtd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCriarArray;
        private System.Windows.Forms.NumericUpDown numericUpDownQtd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonOrdemDescrescente;
        private System.Windows.Forms.RadioButton radioButtonOrdemCrescente;
        private System.Windows.Forms.RadioButton radioButtonAleatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxNumeros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonPesqBin;
        private System.Windows.Forms.Button buttonPesqSeq;
        private System.Windows.Forms.TextBox textBoxValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultadoPesquisa;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Label labelSegundosCriar;
        private System.Windows.Forms.Label labelSegundosMostra;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxResultadoSelecao;
        private System.Windows.Forms.Button buttonKesimoMaior;
        private System.Windows.Forms.Button buttonContar;
        private System.Windows.Forms.Button buttonKesimoMenor;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Button buttonMaxMin;
        private System.Windows.Forms.TextBox textBoxValorContar;
        private System.Windows.Forms.Label label8;
    }
}

