﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    public partial class Inicio : Form
    {
        ControleFrota TelaControleFrota;
        Funcionarios TelaFuncionarios;

        public Inicio()
        {        
            InitializeComponent();
            btnAbaInicio.BackColor = Color.DarkOrange;
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
           TelaControleFrota = new ControleFrota(this,TelaControleFrota,TelaFuncionarios);
           TelaFuncionarios = new Funcionarios(this, TelaControleFrota, TelaFuncionarios);

        }


        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaControleFrota);
        }
        //metodo de troca de telas
        public void TrocarTelas(Form pedido, Form nova)
        {
            if (pedido == this) { pedido.Hide(); }
            else { pedido.Close(); }
            if (nova == TelaControleFrota) { TelaControleFrota = new ControleFrota(this, TelaControleFrota, TelaFuncionarios); nova = TelaControleFrota; nova.Show(); }
            else if (nova == TelaFuncionarios) { TelaFuncionarios = new Funcionarios(this, TelaControleFrota, TelaFuncionarios); nova = TelaFuncionarios; nova.Show(); }
            else { nova.Show(); }
            
            
        }
        //metodo fechar o aplicativo
        public void FecharAplicativo()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaControleFrota.SalvarAoFechar();
            FecharAplicativo();
        }

        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, TelaFuncionarios);
        }

     
    }
}
