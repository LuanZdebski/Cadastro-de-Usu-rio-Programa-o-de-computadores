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
        String banco = @"..\..\BancoDeDados\banco.json";
        
        Inicio TelaInicial;
        ControleFrota TelaControleFrota;
        Funcionarios TelaFuncionarios;

        List<Veiculo> ListVeiculos = new List<Veiculo>();
        

        public ControleFrota(Inicio TelaInicial,ControleFrota controleFrota, Funcionarios funcionarios)
        {
            InitializeComponent();
            btnAbaControleFrota.BackColor = Color.DarkOrange;
            try
            { ListVeiculos = CarregarBanco(banco); }
            catch
            { }
            AtualizarTabela();


            this.TelaInicial = TelaInicial;
            this.TelaControleFrota = controleFrota;
            this.TelaFuncionarios = funcionarios;
        }

        private void btnAbaInicio_Click(object sender, EventArgs e)
        {
            SalvarAoFechar();
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
        //metodo para outras paginas acionarem externamente o salvamento da lista de veiculos quando fecharem o app
        public void SalvarAoFechar()
        {
            SalvarListaVeiculos(banco, ListVeiculos);
        }
        //esse metodo carrega do banco de dados assim que o programa se inicia
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
                  
            TabelaFrota.Rows.Clear();
            for (int i = 0; i < ListVeiculos.Count; i++)
            {
                
                string[] linha = new string[6];
                linha[0] = ListVeiculos[i].fabricante + " " + ListVeiculos[i].modelo;
                linha[1] = ListVeiculos[i].placa;
                linha[2] = ListVeiculos[i].ano;
                linha[3] = ListVeiculos[i].cor;
                linha[4] = ListVeiculos[i].categoria;
                linha[5] = ListVeiculos[i].status;

                TabelaFrota.Rows.Add(linha);
                

            }
            

        }


        //Exclusão de veiculos
        private void btnRemoverVeiculo_Click(object sender, EventArgs e)
        {
            string placa = PlacaSelect();

            if (ListVeiculos.Exists(v => v.placa == placa))
            {
                DialogResult dialogResult = MessageBox.Show("O veiculo sera removido da frota,tem certeza?", "Remover Veiculo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ListVeiculos.Remove(ListVeiculos.Find(v => v.placa == PlacaSelect()));
                    MessageBox.Show("O veiculo de placa: " + placa + " foi removido");
                    AtualizarTabela();
                    SalvarListaVeiculos(banco, ListVeiculos);
                }
            }
            else { MessageBox.Show("Selecione a linha do veiculo que deseja excluir"); }
           
        }
        //metodo para pegar a placa do carro da lista selecionada
        private string PlacaSelect()
        {

            string placa = "";
            foreach (DataGridViewRow row in TabelaFrota.SelectedRows)
            {

                placa = row.Cells[1].Value.ToString();


            }
            return placa;

        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            string placa = PlacaSelect();
            if (ListVeiculos.Exists(v => v.placa == placa))
            {
                Veiculo veiculo = new Veiculo();
                veiculo = ListVeiculos.Find(v => v.placa == placa);
                string[] adcionais = new string[8] { "Ar condicionado", "Direção hidraulica", "Trava elétrica", "teto solar", "Vidro elétrico", "Bancos de couro", "Camera de ré", "Cambio automatico" };
                StringWriter adcionaisLinha = new StringWriter();

                if (veiculo.arCondicionado) { adcionaisLinha.Write(adcionais[0] + Environment.NewLine); }
                if (veiculo.direcaoHidraulica) { adcionaisLinha.Write(adcionais[1] + Environment.NewLine); }
                if (veiculo.travaEletrica) { adcionaisLinha.Write(adcionais[2] + Environment.NewLine); }
                if (veiculo.tetoSolar) { adcionaisLinha.Write(adcionais[3] + Environment.NewLine); }
                if (veiculo.vidroEletrico) { adcionaisLinha.Write(adcionais[4] + Environment.NewLine); }
                if (veiculo.bancosCouro) { adcionaisLinha.Write(adcionais[5] + Environment.NewLine); }
                if (veiculo.cameraRe) { adcionaisLinha.Write(adcionais[6] + Environment.NewLine); }
                if (veiculo.cambioAutomatico) { adcionaisLinha.Write(adcionais[7] + Environment.NewLine); }


                MessageBox.Show
                    ("Nome: " + veiculo.fabricante + " " + veiculo.modelo + Environment.NewLine +
                     "ano: " + veiculo.ano + Environment.NewLine +
                     "categoria: " + veiculo.categoria + Environment.NewLine +
                     "cor: " + veiculo.cor + Environment.NewLine +
                     "placa: " + veiculo.placa + Environment.NewLine +                    
                     "tipo de combustivel: " + veiculo.combustivel + Environment.NewLine +
                     Environment.NewLine +
                     "\t" + "adicionais: " +  Environment.NewLine + adcionaisLinha
                    );
            }
            else { MessageBox.Show("Selecione a linha do veiculo para ver mais detalhes"); }
            
        }

        private void btnControleFuncionarios_Click(object sender, EventArgs e)
        {
            SalvarAoFechar();
            TelaInicial.TrocarTelas(this, TelaFuncionarios);
        }
    }
}
