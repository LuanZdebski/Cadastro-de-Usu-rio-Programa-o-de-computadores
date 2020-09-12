using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_usuário___Programação_de_Computadores
{
    public partial class Cadastro : Form
    {
        private List<Usuario> listaUsuarios;
        private Form1 form;
        public Cadastro(Form1 form, List<Usuario> listaUsuarios)
        {
           

            
            InitializeComponent();
            this.form = form;
            this.listaUsuarios = listaUsuarios;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            bool valid;
             
            if (tBoxNome.Text != "" && tBoxNacimento.MaskCompleted && tBoxTelefone.MaskCompleted && tBoxRg.MaskCompleted && tBoxAltura.MaskCompleted && tBoxPeso.MaskCompleted)
            {
                form.Cadastrar(tBoxNome.Text, tBoxNacimento.Text, tBoxTelefone.Text, tBoxRg.Text, Convert.ToSingle(tBoxAltura.Text), Convert.ToSingle(tBoxPeso.Text));

                
                this.Close();
            }
            else 
            { MessageBox.Show("Algum campo esta vazio ou invalido, obs: preecher casas vazias com zero"); }

           
   
            
        }
    
        private void tBoxAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
