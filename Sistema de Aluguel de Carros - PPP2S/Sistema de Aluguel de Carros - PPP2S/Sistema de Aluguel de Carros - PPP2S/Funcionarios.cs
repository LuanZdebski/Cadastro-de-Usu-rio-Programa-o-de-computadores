using Sistema_de_Aluguel_de_Carros___PPP2S.Entidades;
using System;
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
    public partial class Funcionarios : Form
    {
        Inicio TelaInicial;
        ControleFrota TelaControleFrota;
        Funcionarios TelaFuncionarios;

        List<Funcionario> ListFuncionarios = new List<Funcionario>();
        public Funcionarios(Inicio TelaInicial, ControleFrota controleFrota, Funcionarios funcionarios)
        {
            InitializeComponent();
            btnControleFuncionarios.BackColor = Color.DarkOrange;
           
            this.TelaInicial = TelaInicial;
            this.TelaControleFrota = controleFrota;
            this.TelaFuncionarios = funcionarios;
        }

        private void btnAbaInicio_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaInicial);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            TelaInicial.FecharAplicativo();
        }

        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            TelaInicial.TrocarTelas(this, TelaControleFrota);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            RegistroDeFuncionario registro = new RegistroDeFuncionario(this, ListFuncionarios);
            registro.Show();
        }
        public void AtualizarTabela()
        {

            TabelaFuncionarios.Rows.Clear();
            for (int i = 0; i < ListFuncionarios.Count; i++)
            {

                string[] linha = new string[4];
                linha[0] = ListFuncionarios[i].nome;
                linha[1] = ListFuncionarios[i].cargo;
                linha[2] = ListFuncionarios[i].setor;
               

                TabelaFuncionarios.Rows.Add(linha);


            }


        }
    }
}
