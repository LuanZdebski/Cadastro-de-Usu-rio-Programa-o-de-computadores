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
    
    public partial class CadastroDeVeiculo : Form
    {
        ControleFrota controle;
        List<Veiculo> ListVeiculos = new List<Veiculo>();
        public CadastroDeVeiculo(ControleFrota controle, List<Veiculo> ListVeiculos)
        {
            InitializeComponent();

            this.ListVeiculos = ListVeiculos;
            this.controle = controle;
            
        }

        void CaseFabricante()
        {

            string Marca = boxMarca.SelectedItem.ToString();
            boxModelo.Items.Clear();
            switch (Marca)
            {
                case "Audi":
                    boxModelo.Items.Add("A4");
                    boxModelo.Items.Add("A3");
                    boxModelo.Items.Add("A6");
                    boxModelo.Items.Add("Q3");
                    boxModelo.Items.Add("Q5");
                    boxModelo.Items.Add("R8");
                    boxModelo.Items.Add("Q7");
                    break;
                case "BMW":
                    boxModelo.Items.Add("I8");
                    boxModelo.Items.Add("Série 1");
                    boxModelo.Items.Add("Série 3");
                    boxModelo.Items.Add("Série 5");
                    boxModelo.Items.Add("X3");
                    boxModelo.Items.Add("X6");
                    boxModelo.Items.Add("I3");
                    boxModelo.Items.Add("Z4");
                    break;
                case "Chevrolet":
                    boxModelo.Items.Add("Blazer");
                    boxModelo.Items.Add("Camaro");
                    boxModelo.Items.Add("Captiva");
                    boxModelo.Items.Add("Cobalt");
                    boxModelo.Items.Add("Cruze");
                    boxModelo.Items.Add("Onix");
                    boxModelo.Items.Add("Prisma");
                    boxModelo.Items.Add("Corsa");
                    boxModelo.Items.Add("Celta");
                    boxModelo.Items.Add("Classic");
                    boxModelo.Items.Add("S10");
                    boxModelo.Items.Add("Vectra");
                   


                    break;
                case "Citroen":
                    boxModelo.Items.Add("C3");
                    boxModelo.Items.Add("C4");
                    boxModelo.Items.Add("C5");
                    boxModelo.Items.Add("DS3");
                    boxModelo.Items.Add("DS5");
                    boxModelo.Items.Add("Picasso");
                    break;
                case "Ferrari":
                    boxModelo.Items.Add("California");
                    break;
                case "Fiat":
                    boxModelo.Items.Add("Bravo");
                    boxModelo.Items.Add("Siena");
                    boxModelo.Items.Add("Idea");
                    boxModelo.Items.Add("Palio");
                    boxModelo.Items.Add("Punto");
                    boxModelo.Items.Add("Strada");
                    boxModelo.Items.Add("Uno");
                    boxModelo.Items.Add("Toro");
                    boxModelo.Items.Add("Mobi");
                    boxModelo.Items.Add("Argo");
                    boxModelo.Items.Add("Fiorino");
              



                    break;
                case "Ford":
                    boxModelo.Items.Add("Focus");
                    boxModelo.Items.Add("EcoSport");
                    boxModelo.Items.Add("Ranger");
                    boxModelo.Items.Add("Fusion");
                    boxModelo.Items.Add("Fiesta");
                    boxModelo.Items.Add("Edge");
                    boxModelo.Items.Add("Ka");
               

                    break;
                case "Honda":
                    boxModelo.Items.Add("Civic");
                    boxModelo.Items.Add("City");
                    boxModelo.Items.Add("Fit");
                    boxModelo.Items.Add("CR-V");
                    boxModelo.Items.Add("WR-V");
                    break;
                case "Hyundai":
                    boxModelo.Items.Add("HB20");
                    boxModelo.Items.Add("HB20S");
                    boxModelo.Items.Add("Tucson");
                    boxModelo.Items.Add("Veloster");
                    boxModelo.Items.Add("i30");
                    break;
                case "Jac":
                    boxModelo.Items.Add("J3");
                    boxModelo.Items.Add("J3 Turin");
                    boxModelo.Items.Add("J4");
                    boxModelo.Items.Add("J5");
                    boxModelo.Items.Add("T6");
                    break;
                case "Jeep":
                    boxModelo.Items.Add("Cherokee");
                    boxModelo.Items.Add("Renegade");
                    boxModelo.Items.Add("Wrangler");
                    break;
                case "Land Rover":
                    boxModelo.Items.Add("Defender");
                    boxModelo.Items.Add("Rover Evoque");
                    boxModelo.Items.Add("Rover Sport");
                    break;
                case "Mercedes-Benz":
                    boxModelo.Items.Add("Classe A");
                    boxModelo.Items.Add("Classe B");
                    boxModelo.Items.Add("Classe C");
                    boxModelo.Items.Add("Classe A");
                    boxModelo.Items.Add("Classe S");
                    break;
                case "Mitsubishi":
                    boxModelo.Items.Add("Lancer Evolution X");
                    boxModelo.Items.Add("Outlander");
                    boxModelo.Items.Add("Pajero TR4");
                    break;
                case "Nissan":
                    boxModelo.Items.Add("Frontier");
                    boxModelo.Items.Add("March");
                    boxModelo.Items.Add("Sentra");
                    boxModelo.Items.Add("Versa");
                    break;
                case "Renault":
                    boxModelo.Items.Add("Clio");
                    boxModelo.Items.Add("Fluence");
                    boxModelo.Items.Add("Sandero");
                    boxModelo.Items.Add("Symbol");
                    boxModelo.Items.Add("Duster");
                    boxModelo.Items.Add("Kwid");
                    boxModelo.Items.Add("Logan");
                    boxModelo.Items.Add("Stepway");
                    boxModelo.Items.Add("Kangoo");
                    boxModelo.Items.Add("Oroch");
                    boxModelo.Items.Add("Captur");

                    break;
                case "Toyota":
                    boxModelo.Items.Add("Corolla");
                    boxModelo.Items.Add("Etios");
                    boxModelo.Items.Add("Hilux");
                    break;
                case "Volkswagen":
                    boxModelo.Items.Add("Amarok");
                    boxModelo.Items.Add("Fox");
                    boxModelo.Items.Add("Golf");
                    boxModelo.Items.Add("Jetta");
                    boxModelo.Items.Add("Polo");
                    boxModelo.Items.Add("Tiguan");
                    boxModelo.Items.Add("Up");
                    boxModelo.Items.Add("Gol");
                    boxModelo.Items.Add("Virtus");
                    boxModelo.Items.Add("Voyage");
                 

                    break;
            }

        }
        //tratamento dos dados de cadastro
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
          

            if (boxModelo.Text != "" && boxMarca.Text != "" && boxAno.Text != "" && boxCategoria.Text != "" && boxCombustivel.Text != "" && tBoxConcessionaria.Text != "" && tBoxValor.Text != "")
            {
                
                if (checkPlaca.Checked && tBoxPlacaNov.MaskCompleted)
                {
                    if (!ListVeiculos.Exists(v => v.placa == tBoxPlacaNov.Text.ToUpper()))
                    {
                        Cadastrar(boxMarca.Text, boxModelo.Text, boxAno.Text, boxCategoria.Text, boxCor.Text, tBoxPlacaNov.Text, boxCombustivel.Text, tBoxConcessionaria.Text, Convert.ToSingle(tBoxValor.Text));

                    }
                    else { MessageBox.Show("placa ja existente no banco de dados"); }

                }
                else if (!checkPlaca.Checked && tBoxPlacaAnt.MaskCompleted)
                {
                    if (!ListVeiculos.Exists(v => v.placa == tBoxPlacaAnt.Text.ToUpper()))
                    {
                        Cadastrar(boxMarca.Text, boxModelo.Text, boxAno.Text, boxCategoria.Text, boxCor.Text, tBoxPlacaAnt.Text, boxCombustivel.Text, tBoxConcessionaria.Text, Convert.ToSingle(tBoxValor.Text));
                    }
                    else { MessageBox.Show("placa ja existente no banco de dados"); }
                    
                }
                else { MessageBox.Show("por favor,preencha todos os dados"); }
            }
            else { MessageBox.Show("por favor,preencha todos os dados"); }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        
        }
        private void Cadastrar(string fabricante, string modelo, string ano, string categoria, string cor, string placa, string combustivel, string conc, float valor)
        {
            Veiculo novoVeiculo = new Veiculo();

            novoVeiculo.fabricante = fabricante;
            novoVeiculo.modelo = modelo;
            novoVeiculo.ano = ano;
            novoVeiculo.categoria = categoria;
            novoVeiculo.cor = cor;
            novoVeiculo.placa = placa.ToUpper();
            novoVeiculo.combustivel = combustivel;     
            novoVeiculo.concessionaria = conc;
            novoVeiculo.valorDeCompra = Convert.ToSingle(valor);

            novoVeiculo.arCondicionado = checkAC.Checked;
            novoVeiculo.direcaoHidraulica = checkDirecao.Checked;
            novoVeiculo.vidroEletrico = checkVidro.Checked;
            novoVeiculo.travaEletrica = checkTravas.Checked;
            novoVeiculo.tetoSolar = checkTetoSolar.Checked;
            novoVeiculo.cameraRe = checkCameraRe.Checked;
            novoVeiculo.bancosCouro = checkBancosCouro.Checked;
            novoVeiculo.cambioAutomatico = checkCambioAuto.Checked;

            novoVeiculo.status = "Disponivel";

            ListVeiculos.Add(novoVeiculo);

            controle.AtualizarTabela();
            this.Close();
        }

        private void boxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            boxModelo.Text = "";
            CaseFabricante();
            
        }

        private void checkPlaca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPlaca.Checked == true) { tBoxPlacaAnt.Visible = false; tBoxPlacaNov.Visible = true; }
            else { tBoxPlacaAnt.Visible = true; tBoxPlacaNov.Visible = false; }
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
