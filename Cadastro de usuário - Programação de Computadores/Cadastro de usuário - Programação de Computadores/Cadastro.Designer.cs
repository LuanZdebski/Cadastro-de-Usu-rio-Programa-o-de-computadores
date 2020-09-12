namespace Cadastro_de_usuário___Programação_de_Computadores
{
    partial class Cadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxNacimento = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.tBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome completo";
            // 
            // tBoxNome
            // 
            this.tBoxNome.Location = new System.Drawing.Point(16, 35);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(335, 20);
            this.tBoxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de nascimento";
            // 
            // tBoxNacimento
            // 
            this.tBoxNacimento.Location = new System.Drawing.Point(15, 91);
            this.tBoxNacimento.Mask = "00/00/0000";
            this.tBoxNacimento.Name = "tBoxNacimento";
            this.tBoxNacimento.Size = new System.Drawing.Size(100, 20);
            this.tBoxNacimento.TabIndex = 3;
            this.tBoxNacimento.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero de telefone";
            // 
            // tBoxTelefone
            // 
            this.tBoxTelefone.Location = new System.Drawing.Point(15, 162);
            this.tBoxTelefone.Mask = "(00)00000-0000";
            this.tBoxTelefone.Name = "tBoxTelefone";
            this.tBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.tBoxTelefone.TabIndex = 5;
            this.tBoxTelefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rg";
            // 
            // tBoxRg
            // 
            this.tBoxRg.Location = new System.Drawing.Point(15, 222);
            this.tBoxRg.Mask = "00.000.000-0";
            this.tBoxRg.Name = "tBoxRg";
            this.tBoxRg.Size = new System.Drawing.Size(100, 20);
            this.tBoxRg.TabIndex = 7;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(276, 356);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Peso";
            // 
            // tBoxAltura
            // 
            this.tBoxAltura.Location = new System.Drawing.Point(219, 162);
            this.tBoxAltura.Mask = "0.00";
            this.tBoxAltura.Name = "tBoxAltura";
            this.tBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.tBoxAltura.TabIndex = 11;
            this.tBoxAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.tBoxAltura_MaskInputRejected);
            // 
            // tBoxPeso
            // 
            this.tBoxPeso.Location = new System.Drawing.Point(219, 222);
            this.tBoxPeso.Mask = "000.0";
            this.tBoxPeso.Name = "tBoxPeso";
            this.tBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.tBoxPeso.TabIndex = 12;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 391);
            this.Controls.Add(this.tBoxPeso);
            this.Controls.Add(this.tBoxAltura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tBoxRg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxNacimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tBoxNacimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tBoxTelefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tBoxRg;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox tBoxAltura;
        private System.Windows.Forms.MaskedTextBox tBoxPeso;
    }
}