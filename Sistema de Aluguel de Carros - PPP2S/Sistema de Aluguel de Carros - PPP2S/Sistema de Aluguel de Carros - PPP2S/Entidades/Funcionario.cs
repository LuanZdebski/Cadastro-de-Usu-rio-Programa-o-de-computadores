using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Aluguel_de_Carros___PPP2S.Entidades
{
    public class Funcionario
    {
        public string nome { get; set; }
        public string cargo { get; set; }
        public string setor { get; set; }
        public string nivelAcesso { get; set; }
        public string email { get; set; }

        public string telefone { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string dataAdmssao { get; set; }

        public float salario { get; set; }

        public string login { get; set; }
        public string senha { get; set; }
    }
}
