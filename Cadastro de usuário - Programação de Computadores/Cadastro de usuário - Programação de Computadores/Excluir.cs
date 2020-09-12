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
    public partial class Excluir : Form
    {
        private List<Usuario> listaUsuarios;
        private Form1 form;
        public Excluir(Form1 form, List<Usuario> listaUsuarios)
        {
            InitializeComponent();
            this.listaUsuarios = listaUsuarios;
            this.form = form;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Exists(u => u.nome == tBoxDeletarUsuario.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Tem certeza que quer excluir o usuario: " + tBoxDeletarUsuario.Text + "?", "Excluir", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    form.RemoverUsuario(tBoxDeletarUsuario.Text);
                    form.AtualizarUsuarios();
                    this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
               


            }
            else { MessageBox.Show("Usuario não encontrado"); }
            
        }
    }
}
