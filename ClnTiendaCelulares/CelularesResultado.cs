using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class CelularesResultado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public int Stock { get; set; }
        public decimal precio { get; set; }
        public string color { get; set; }
        public string categoria { get; set; }
    }
}
