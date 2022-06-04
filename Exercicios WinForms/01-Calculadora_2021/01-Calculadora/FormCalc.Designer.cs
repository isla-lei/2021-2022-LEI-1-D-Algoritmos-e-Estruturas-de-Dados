
namespace _01_Calculadora
{
    partial class FormCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.buttonSub = new System.Windows.Forms.Button();
            this.buttonSoma = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResultado = new System.Windows.Forms.TextBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonNovaCalc = new System.Windows.Forms.Button();
            this.buttonFormVazio = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFecharTudo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Chartreuse;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operador 1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Chartreuse;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(375, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Operador 2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Location = new System.Drawing.Point(194, 146);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(150, 29);
            this.textBoxOp1.TabIndex = 2;
            this.textBoxOp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOp1.TextChanged += new System.EventHandler(this.textBoxOp1_TextChanged);
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Location = new System.Drawing.Point(375, 146);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(150, 29);
            this.textBoxOp2.TabIndex = 3;
            this.textBoxOp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOp2.TextChanged += new System.EventHandler(this.textBoxOp2_TextChanged);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(54, 193);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(122, 48);
            this.buttonSub.TabIndex = 4;
            this.buttonSub.Text = "Subtração";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // buttonSoma
            // 
            this.buttonSoma.Location = new System.Drawing.Point(218, 193);
            this.buttonSoma.Name = "buttonSoma";
            this.buttonSoma.Size = new System.Drawing.Size(122, 48);
            this.buttonSoma.TabIndex = 4;
            this.buttonSoma.Text = "Soma";
            this.buttonSoma.UseVisualStyleBackColor = true;
            this.buttonSoma.Click += new System.EventHandler(this.buttonSoma_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.Location = new System.Drawing.Point(382, 193);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(122, 48);
            this.buttonMult.TabIndex = 4;
            this.buttonMult.Text = "Multiplicação";
            this.buttonMult.UseVisualStyleBackColor = true;
            this.buttonMult.Click += new System.EventHandler(this.buttonMult_Click);
            // 
            // buttonDiv
            // 
            this.buttonDiv.Location = new System.Drawing.Point(546, 193);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(122, 48);
            this.buttonDiv.TabIndex = 4;
            this.buttonDiv.Text = "Divisão";
            this.buttonDiv.UseVisualStyleBackColor = true;
            this.buttonDiv.Click += new System.EventHandler(this.buttonDiv_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Chartreuse;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(284, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "Resultado";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxResultado
            // 
            this.textBoxResultado.Location = new System.Drawing.Point(284, 307);
            this.textBoxResultado.Name = "textBoxResultado";
            this.textBoxResultado.ReadOnly = true;
            this.textBoxResultado.Size = new System.Drawing.Size(150, 29);
            this.textBoxResultado.TabIndex = 6;
            this.textBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMensagem
            // 
            this.labelMensagem.Location = new System.Drawing.Point(230, 339);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(255, 21);
            this.labelMensagem.TabIndex = 7;
            this.labelMensagem.Text = "Mensagem";
            this.labelMensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(593, 391);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(122, 33);
            this.buttonFechar.TabIndex = 8;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(465, 391);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(122, 33);
            this.buttonLimpar.TabIndex = 8;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonNovaCalc
            // 
            this.buttonNovaCalc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNovaCalc.Location = new System.Drawing.Point(14, 27);
            this.buttonNovaCalc.Name = "buttonNovaCalc";
            this.buttonNovaCalc.Size = new System.Drawing.Size(135, 25);
            this.buttonNovaCalc.TabIndex = 8;
            this.buttonNovaCalc.Text = "Nova calculadora";
            this.buttonNovaCalc.UseVisualStyleBackColor = true;
            this.buttonNovaCalc.Click += new System.EventHandler(this.buttonNovaCalc_Click);
            // 
            // buttonFormVazio
            // 
            this.buttonFormVazio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFormVazio.Location = new System.Drawing.Point(14, 55);
            this.buttonFormVazio.Name = "buttonFormVazio";
            this.buttonFormVazio.Size = new System.Drawing.Size(135, 25);
            this.buttonFormVazio.TabIndex = 8;
            this.buttonFormVazio.Text = "Form vazio";
            this.buttonFormVazio.UseVisualStyleBackColor = true;
            this.buttonFormVazio.Click += new System.EventHandler(this.buttonFormVazio_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonFecharTudo);
            this.groupBox1.Controls.Add(this.buttonFormVazio);
            this.groupBox1.Controls.Add(this.buttonNovaCalc);
            this.groupBox1.Location = new System.Drawing.Point(8, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cações com Forms";
            // 
            // buttonFecharTudo
            // 
            this.buttonFecharTudo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFecharTudo.Location = new System.Drawing.Point(14, 83);
            this.buttonFecharTudo.Name = "buttonFecharTudo";
            this.buttonFecharTudo.Size = new System.Drawing.Size(135, 25);
            this.buttonFecharTudo.TabIndex = 8;
            this.buttonFecharTudo.Text = "Fechar tudo";
            this.buttonFecharTudo.UseVisualStyleBackColor = true;
            this.buttonFecharTudo.Click += new System.EventHandler(this.buttonFecharTudo_Click);
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(727, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.textBoxResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.buttonSoma);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.textBoxOp2);
            this.Controls.Add(this.textBoxOp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.Button buttonSoma;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultado;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.Button buttonFechar;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonNovaCalc;
        private System.Windows.Forms.Button buttonFormVazio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonFecharTudo;
    }
}

