using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class ComprasResultado
    {
        public int id { get; set; }
        public string nombreCelular { get; set; }
        public string direccionEnvio { get; set;}
        public decimal total { get; set;}
        public string nombreUsuario { get; set;}

    }
}
