using CadTiendaCelulares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class CompraCln
    {
        public static int insertar(compras compra)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                context.compras.Add(compra);
                context.SaveChanges();
                return compra.id;
            }
        }

        public static List<ComprasResultado> listar()
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                string sql = "SELECT c.id,cel.nombre as nombreCelular, " +
                    "c.direccion_envio as direccionEnvio, " +
                    "c.total, " +
                    "u.nombre as nombreUsuario" +
                    " FROM compras c" +
                    " JOIN celulares cel on cel.id = c.idCelular" +
                    " JOIN usuarios u on u.id = c.id_usuario";

                return context.Database.SqlQuery<ComprasResultado>(sql).ToList();
            }
        }
    }
}
