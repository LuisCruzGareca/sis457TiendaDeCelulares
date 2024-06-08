using CadTiendaCelulares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class ColoresCln
    {
        public static colores obtenerUno(int id)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                return context.colores.Find(id);
            }
        }
    }
}
