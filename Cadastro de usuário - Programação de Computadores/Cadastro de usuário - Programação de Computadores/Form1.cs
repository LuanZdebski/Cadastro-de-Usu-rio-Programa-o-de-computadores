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
 

    public partial class Form1 : Form
    {
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(this , listaUsuarios);
            cadastro.Show();
        }

        public void AtualizarUsuarios()
        {
            
            txtNumeroDeCadastros.Text = "Numero de cadastros: " + listaUsuarios.Count;

            rTextBoxNome.Clear();          
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxNome.AppendText((usu.nome) + Environment.NewLine);
            }
            rTextBoxNascimento.Clear();
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxNascimento.AppendText((usu.nascimento) + Environment.NewLine);
            }
            rTextBoxTelefone.Clear();
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxTelefone.AppendText((usu.telefone) + Environment.NewLine);
            }
            rTextBoxRg.Clear();
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxRg.AppendText((usu.rg) + Environment.NewLine);
            }
            rTextBoxAltura.Clear();
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxAltura.AppendText((usu.altura)+ "m" + Environment.NewLine);
            }
            rTextBoxPeso.Clear();
            foreach (Usuario usu in listaUsuarios)
            {
                rTextBoxPeso.AppendText((usu.peso)+ "kg" + Environment.NewLine);
            }



            
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir(this, listaUsuarios);
            excluir.Show();
        }
        public void Cadastrar(string nome, string nascimento, string telefone, string rg, float altura, float peso)
        {
            Usuario novoUsuario = new Usuario();


            novoUsuario.nome = nome;
            novoUsuario.nascimento = nascimento;
            novoUsuario.telefone = telefone;
            novoUsuario.rg = rg;
            novoUsuario.altura = altura;
            novoUsuario.peso = peso;

            listaUsuarios.Add(novoUsuario);
            AtualizarUsuarios();

        }
        public void RemoverUsuario(string nome)
        {

            listaUsuarios.Remove(listaUsuarios.FirstOrDefault(u => u.nome == nome));
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            
            AlterarDados dados = new AlterarDados(this , listaUsuarios);
            dados.Show();
        }
    }
    public class Usuario
    {
        public string nome;
        public string nascimento;
        public string telefone;
        public string rg;

        public float altura;
        public float peso;
    }
    
  
}
