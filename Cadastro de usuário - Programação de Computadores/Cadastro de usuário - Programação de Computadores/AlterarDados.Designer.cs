namespace Cadastro_de_usuário___Programação_de_Computadores
{
    partial class AlterarDados
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
            this.tBoxPeso = new System.Windows.Forms.MaskedTextBox();
            this.tBoxAltura = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoAntigo = new System.Windows.Forms.Label();
            this.txtAlturaAntiga = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.tBoxRg = new System.Windows.Forms.MaskedTextBox();
            this.txtRgAntigo = new System.Windows.Forms.Label();
            this.tBoxTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNumeroAntigo = new System.Windows.Forms.Label();
            this.tBoxNacimento = new System.Windows.Forms.MaskedTextBox();
            this.txtNascimentoAntigo = new System.Windows.Forms.Label();
            this.tBoxNome = new System.Windows.Forms.TextBox();
            this.txtNomeAntigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxRgAlterar = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxPeso
            // 
            this.tBoxPeso.Enabled = false;
            this.tBoxPeso.Location = new System.Drawing.Point(227, 359);
            this.tBoxPeso.Mask = "000.0";
            this.tBoxPeso.Name = "tBoxPeso";
            this.tBoxPeso.Size = new System.Drawing.Size(100, 20);
            this.tBoxPeso.TabIndex = 25;
            // 
            // tBoxAltura
            // 
            this.tBoxAltura.Enabled = false;
            this.tBoxAltura.Location = new System.Drawing.Point(227, 299);
            this.tBoxAltura.Mask = "0.00";
            this.tBoxAltura.Name = "tBoxAltura";
            this.tBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.tBoxAltura.TabIndex = 24;
            // 
            // txtPesoAntigo
            // 
            this.txtPesoAntigo.AutoSize = true;
            this.txtPesoAntigo.Location = new System.Drawing.Point(224, 343);
            this.txtPesoAntigo.Name = "txtPesoAntigo";
            this.txtPesoAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtPesoAntigo.TabIndex = 23;
            // 
            // txtAlturaAntiga
            // 
            this.txtAlturaAntiga.AutoSize = true;
            this.txtAlturaAntiga.Location = new System.Drawing.Point(224, 283);
            this.txtAlturaAntiga.Name = "txtAlturaAntiga";
            this.txtAlturaAntiga.Size = new System.Drawing.Size(0, 13);
            this.txtAlturaAntiga.TabIndex = 22;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Enabled = false;
            this.btnCadastrar.Location = new System.Drawing.Point(284, 460);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Alterar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // tBoxRg
            // 
            this.tBoxRg.Enabled = false;
            this.tBoxRg.Location = new System.Drawing.Point(23, 359);
            this.tBoxRg.Mask = "00.000.000-0";
            this.tBoxRg.Name = "tBoxRg";
            this.tBoxRg.Size = new System.Drawing.Size(100, 20);
            this.tBoxRg.TabIndex = 20;
            // 
            // txtRgAntigo
            // 
            this.txtRgAntigo.AutoSize = true;
            this.txtRgAntigo.Location = new System.Drawing.Point(23, 343);
            this.txtRgAntigo.Name = "txtRgAntigo";
            this.txtRgAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtRgAntigo.TabIndex = 19;
            // 
            // tBoxTelefone
            // 
            this.tBoxTelefone.Enabled = false;
            this.tBoxTelefone.Location = new System.Drawing.Point(23, 299);
            this.tBoxTelefone.Mask = "(00)00000-0000";
            this.tBoxTelefone.Name = "tBoxTelefone";
            this.tBoxTelefone.Size = new System.Drawing.Size(100, 20);
            this.tBoxTelefone.TabIndex = 18;
            // 
            // txtNumeroAntigo
            // 
            this.txtNumeroAntigo.AutoSize = true;
            this.txtNumeroAntigo.Location = new System.Drawing.Point(23, 283);
            this.txtNumeroAntigo.Name = "txtNumeroAntigo";
            this.txtNumeroAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtNumeroAntigo.TabIndex = 17;
            // 
            // tBoxNacimento
            // 
            this.tBoxNacimento.Enabled = false;
            this.tBoxNacimento.Location = new System.Drawing.Point(23, 228);
            this.tBoxNacimento.Mask = "00/00/0000";
            this.tBoxNacimento.Name = "tBoxNacimento";
            this.tBoxNacimento.Size = new System.Drawing.Size(100, 20);
            this.tBoxNacimento.TabIndex = 16;
            this.tBoxNacimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtNascimentoAntigo
            // 
            this.txtNascimentoAntigo.AutoSize = true;
            this.txtNascimentoAntigo.Location = new System.Drawing.Point(21, 212);
            this.txtNascimentoAntigo.Name = "txtNascimentoAntigo";
            this.txtNascimentoAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtNascimentoAntigo.TabIndex = 15;
            // 
            // tBoxNome
            // 
            this.tBoxNome.Enabled = false;
            this.tBoxNome.Location = new System.Drawing.Point(24, 172);
            this.tBoxNome.Name = "tBoxNome";
            this.tBoxNome.Size = new System.Drawing.Size(335, 20);
            this.tBoxNome.TabIndex = 14;
            // 
            // txtNomeAntigo
            // 
            this.txtNomeAntigo.AutoSize = true;
            this.txtNomeAntigo.Location = new System.Drawing.Point(21, 155);
            this.txtNomeAntigo.Name = "txtNomeAntigo";
            this.txtNomeAntigo.Size = new System.Drawing.Size(0, 13);
            this.txtNomeAntigo.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Insira os novos dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 397);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "os campos em branco nao serao alterados";
            // 
            // tBoxRgAlterar
            // 
            this.tBoxRgAlterar.Location = new System.Drawing.Point(23, 25);
            this.tBoxRgAlterar.Mask = "00.000.000-0";
            this.tBoxRgAlterar.Name = "tBoxRgAlterar";
            this.tBoxRgAlterar.Size = new System.Drawing.Size(100, 20);
            this.tBoxRgAlterar.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Insira o RG do usuario a ser alterado";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(210, 25);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(149, 23);
            this.btnCarregar.TabIndex = 28;
            this.btnCarregar.Text = "Carregar dados";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // AlterarDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 503);
            this.Controls.Add(this.tBoxRgAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxPeso);
            this.Controls.Add(this.tBoxAltura);
            this.Controls.Add(this.txtPesoAntigo);
            this.Controls.Add(this.txtAlturaAntiga);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tBoxRg);
            this.Controls.Add(this.txtRgAntigo);
            this.Controls.Add(this.tBoxTelefone);
            this.Controls.Add(this.txtNumeroAntigo);
            this.Controls.Add(this.tBoxNacimento);
            this.Controls.Add(this.txtNascimentoAntigo);
            this.Controls.Add(this.tBoxNome);
            this.Controls.Add(this.txtNomeAntigo);
            this.Name = "AlterarDados";
            this.Text = "AlterarDados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tBoxPeso;
        private System.Windows.Forms.MaskedTextBox tBoxAltura;
        private System.Windows.Forms.Label txtPesoAntigo;
        private System.Windows.Forms.Label txtAlturaAntiga;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox tBoxRg;
        private System.Windows.Forms.Label txtRgAntigo;
        private System.Windows.Forms.MaskedTextBox tBoxTelefone;
        private System.Windows.Forms.Label txtNumeroAntigo;
        private System.Windows.Forms.MaskedTextBox tBoxNacimento;
        private System.Windows.Forms.Label txtNascimentoAntigo;
        private System.Windows.Forms.TextBox tBoxNome;
        private System.Windows.Forms.Label txtNomeAntigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox tBoxRgAlterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCarregar;
    }
}