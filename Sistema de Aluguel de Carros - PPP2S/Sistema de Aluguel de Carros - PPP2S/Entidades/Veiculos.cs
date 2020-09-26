using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Aluguel_de_Carros___PPP2S.Entidades
{
    public class Veiculo
    {
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public string categoria { get; set; }
        public string placa { get; set; }
        public string combustivel { get; set; }
        public string cor { get; set; }

        public string concessionaria { get; set; }
        public string valorDeCompra { get; set; }

        public string status { get; set; }


    }

}
