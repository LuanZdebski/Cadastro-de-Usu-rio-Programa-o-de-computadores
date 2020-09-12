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
    public partial class AlterarDados : Form
    {
        
        Usuario usuario;
        private List<Usuario> listaUsuarios;
        private Form1 form;

        public AlterarDados(Form1 form , List<Usuario> listaUsuarios)
        {
            InitializeComponent();

            
            this.form = form;
           
            this.listaUsuarios = listaUsuarios;

           
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (tBoxNome.Text != "") {  usuario.nome = tBoxNome.Text; }
            else { usuario.nome = txtNomeAntigo.Text; }

            if (tBoxNacimento.MaskCompleted) { usuario.nascimento = tBoxNacimento.Text; }
            else { usuario.nascimento = txtNascimentoAntigo.Text; }

            if (tBoxTelefone.MaskCompleted) { usuario.telefone = tBoxTelefone.Text; }
            else { usuario.telefone = txtNumeroAntigo.Text;  }

            if (tBoxRg.MaskCompleted) { usuario.rg = tBoxRg.Text; }
            else { usuario.rg = txtRgAntigo.Text;  }

            if (tBoxAltura.MaskCompleted) { usuario.altura = Convert.ToSingle(tBoxAltura.Text); }
            else { usuario.altura = Convert.ToSingle(txtAlturaAntiga.Text);  }

            if (tBoxPeso.MaskCompleted) { usuario.peso = Convert.ToSingle(tBoxPeso.Text);  }
            else { usuario.peso = Convert.ToSingle(txtPesoAntigo.Text); }

            form.RemoverUsuario(usuario.nome);
            
            form.Cadastrar(usuario.nome, usuario.nascimento, usuario.telefone, usuario.rg, usuario.altura, usuario.peso);
            this.Close();

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Exists(u => u.rg == tBoxRgAlterar.Text))
            {

                
                usuario = listaUsuarios.First(u => u.rg == tBoxRgAlterar.Text);

                txtNomeAntigo.Text = usuario.nome;
                txtNascimentoAntigo.Text = usuario.nascimento;
                txtNumeroAntigo.Text = usuario.telefone;
                txtRgAntigo.Text = usuario.rg;
                txtAlturaAntiga.Text = usuario.altura.ToString();
                txtPesoAntigo.Text = usuario.peso.ToString();

                btnCarregar.Enabled = false;
                tBoxRgAlterar.Enabled = false;

                tBoxNome.Enabled = true;
                tBoxNacimento.Enabled = true;
                tBoxTelefone.Enabled = true;
                tBoxRg.Enabled = true;
                tBoxAltura.Enabled = true;
                tBoxPeso.Enabled = true;

                btnCadastrar.Enabled = true;

            }
            else { MessageBox.Show("Usuario não encontrado"); }

            
        }
    }
}
