using Newtonsoft.Json;
using Sistema_de_Aluguel_de_Carros___PPP2S.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Aluguel_de_Carros___PPP2S
{
    public partial class ControleFrota : Form
    {
        String banco = @"C:\Users\luanm\source\repos\Sistema de Aluguel de Carros - PPP2S\Sistema de Aluguel de Carros - PPP2S\BancoDeDados\banco.json";
        
        Inicio TelaInicial = new Inicio();

        List<Veiculo> ListVeiculos = new List<Veiculo>();
        

        public ControleFrota(Inicio TelaInicial)
        {
            InitializeComponent();         
            AtualizarTabela();


            this.TelaInicial = TelaInicial;
            
        }

        private void btnAbaInicio_Click(object sender, EventArgs e)
        {
            
            TelaInicial.TrocarTelas(this, TelaInicial);
        }

        private void btnAdcionarVeiculo_Click(object sender, EventArgs e)
        {
            CadastroDeVeiculo cadastro = new CadastroDeVeiculo(this, ListVeiculos);
            cadastro.Show();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SalvarAoFechar();
            TelaInicial.FecharAplicativo();
        }

        //metodo de salvamendo em Json
        static private void SalvarListaVeiculos(String arquivo, List<Veiculo> lista)
        {
            StreamWriter file = new StreamWriter(arquivo);
            lista.ForEach(v =>
            {
                string output = JsonConvert.SerializeObject(v);
                file.WriteLine(output);

            });


            file.Close();
        }
        public void SalvarAoFechar()
        {
            SalvarListaVeiculos(banco, ListVeiculos);
        }
        static private List<Veiculo> CarregarBanco(String banco)
        {
            string line;
            List<Veiculo> ListVeiculos = new List<Veiculo>();

            StreamReader file = new StreamReader(banco);

            while ((line = file.ReadLine()) != null)
            {
                Veiculo veiculo = JsonConvert.DeserializeObject<Veiculo>(line);
                ListVeiculos.Add(veiculo);
            }
            file.Close();
            return ListVeiculos;
        }


        public void AtualizarTabela()
        {
           
            try
            { ListVeiculos = CarregarBanco(banco); }
            catch
            { }

            TabelaFrota.Rows.Clear();
            for (int i = 0; i < ListVeiculos.Count; i++)
            {
                
                string[] linha = new string[5];
                linha[0] = ListVeiculos[i].fabricante + " " + ListVeiculos[i].modelo;
                linha[1] = ListVeiculos[i].placa;
                linha[2] = ListVeiculos[i].cor;
                linha[3] = ListVeiculos[i].categoria;
                linha[4] = ListVeiculos[i].status;

                TabelaFrota.Rows.Add(linha);
                

            }
            

        }

        private void ControleFrota_Load(object sender, EventArgs e)
        {
            
        }
    }
}
