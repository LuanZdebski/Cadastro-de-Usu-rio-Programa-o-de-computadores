namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    partial class ControleFrota
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
            this.btnAbaControleFrota = new System.Windows.Forms.Button();
            this.btnAbaInicio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdcionarVeiculo = new System.Windows.Forms.Button();
            this.btnLocarVeiculo = new System.Windows.Forms.Button();
            this.TabelaFrota = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFrota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbaControleFrota
            // 
            this.btnAbaControleFrota.Location = new System.Drawing.Point(123, 12);
            this.btnAbaControleFrota.Name = "btnAbaControleFrota";
            this.btnAbaControleFrota.Size = new System.Drawing.Size(105, 65);
            this.btnAbaControleFrota.TabIndex = 3;
            this.btnAbaControleFrota.Text = "Controle de Frota";
            this.btnAbaControleFrota.UseVisualStyleBackColor = true;
            // 
            // btnAbaInicio
            // 
            this.btnAbaInicio.Location = new System.Drawing.Point(12, 12);
            this.btnAbaInicio.Name = "btnAbaInicio";
            this.btnAbaInicio.Size = new System.Drawing.Size(105, 65);
            this.btnAbaInicio.TabIndex = 2;
            this.btnAbaInicio.Text = "Inicio";
            this.btnAbaInicio.UseVisualStyleBackColor = true;
            this.btnAbaInicio.Click += new System.EventHandler(this.btnAbaInicio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(764, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(12, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 10);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdcionarVeiculo
            // 
            this.btnAdcionarVeiculo.Location = new System.Drawing.Point(681, 100);
            this.btnAdcionarVeiculo.Name = "btnAdcionarVeiculo";
            this.btnAdcionarVeiculo.Size = new System.Drawing.Size(107, 23);
            this.btnAdcionarVeiculo.TabIndex = 9;
            this.btnAdcionarVeiculo.Text = "Adcionar veiculo";
            this.btnAdcionarVeiculo.UseVisualStyleBackColor = true;
            this.btnAdcionarVeiculo.Click += new System.EventHandler(this.btnAdcionarVeiculo_Click);
            // 
            // btnLocarVeiculo
            // 
            this.btnLocarVeiculo.Location = new System.Drawing.Point(681, 129);
            this.btnLocarVeiculo.Name = "btnLocarVeiculo";
            this.btnLocarVeiculo.Size = new System.Drawing.Size(107, 23);
            this.btnLocarVeiculo.TabIndex = 10;
            this.btnLocarVeiculo.Text = "Locar veiculo";
            this.btnLocarVeiculo.UseVisualStyleBackColor = true;
            // 
            // TabelaFrota
            // 
            this.TabelaFrota.AllowUserToOrderColumns = true;
            this.TabelaFrota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Placa,
            this.Cor,
            this.Categoria,
            this.Status});
            this.TabelaFrota.Location = new System.Drawing.Point(12, 158);
            this.TabelaFrota.Name = "TabelaFrota";
            this.TabelaFrota.ReadOnly = true;
            this.TabelaFrota.Size = new System.Drawing.Size(776, 256);
            this.TabelaFrota.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            this.Placa.Width = 70;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            this.Cor.Width = 70;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 80;
            // 
            // ControleFrota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabelaFrota);
            this.Controls.Add(this.btnLocarVeiculo);
            this.Controls.Add(this.btnAdcionarVeiculo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAbaControleFrota);
            this.Controls.Add(this.btnAbaInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControleFrota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControleFrota";
            this.Load += new System.EventHandler(this.ControleFrota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFrota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbaControleFrota;
        private System.Windows.Forms.Button btnAbaInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdcionarVeiculo;
        private System.Windows.Forms.Button btnLocarVeiculo;
        private System.Windows.Forms.DataGridView TabelaFrota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}