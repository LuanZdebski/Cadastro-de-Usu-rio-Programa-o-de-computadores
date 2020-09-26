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
    public partial class Inicio : Form
    {
        public ControleFrota controleFrota;
        
        public Inicio()
        {        
            InitializeComponent();
            
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            controleFrota = new ControleFrota(this);
            
        }


        private void btnAbaControleFrota_Click(object sender, EventArgs e)
        {
            TrocarTelas(this, controleFrota);
        }
        //metodo de troca de telas
        public void TrocarTelas(Form pedido, Form nova)
        {
            
            pedido.Hide();
            nova.Show();
            
        }
        //metodo fechar o aplicativo
        public void FecharAplicativo()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleFrota.SalvarAoFechar();
            FecharAplicativo();
        }

       
    }
}
