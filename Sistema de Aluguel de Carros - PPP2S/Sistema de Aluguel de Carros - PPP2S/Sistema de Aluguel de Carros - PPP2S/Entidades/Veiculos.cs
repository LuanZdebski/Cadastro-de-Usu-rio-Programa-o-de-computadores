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
        public float valorDeCompra { get; set; }

        public string status { get; set; }
       
        
        public bool arCondicionado { get; set; }
        public bool vidroEletrico { get; set; }
        public bool cambioAutomatico { get; set; }
        public bool tetoSolar { get; set; }
        public bool travaEletrica { get; set; }
        public bool direcaoHidraulica { get; set; }
        public bool cameraRe { get; set; }

        public bool bancosCouro { get; set; }
    }

}
