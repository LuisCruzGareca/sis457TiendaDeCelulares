using CadTiendaCelulares;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class CelularCln
    {

        public static List<CelularesResultado> listar()
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                string sql = "SELECT c.*, col.nombre AS color,cat.nombre AS categoria" +
                    " FROM celulares c" +
                    " JOIN colores col on col.id = c.idColor" +
                    " JOIN categorias cat on cat.id = c.idCategoria";
                return context.Database.SqlQuery<CelularesResultado>(sql).ToList();
            }
        }

        public static celulares obtenerUno(int id)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                return context.celulares.Find(id);
            }
        }

        public static int insertar(celulares celular)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                context.celulares.Add(celular);
                context.SaveChanges();
                return celular.id;
            }
        }

        public static int actualizar(celulares celular)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                var existente = context.celulares.Find(celular.id);
                existente.nombre = celular.nombre;
                existente.descripcion = celular.descripcion;
                existente.marca = celular.marca;
                existente.modelo = celular.modelo;
                existente.precio = celular.precio;
                existente.idColor = celular.idColor;
                existente.idCategoria = celular.idCategoria;

                return context.SaveChanges();
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                var celular = context.celulares.Find(id);
                var producto = context.celulares.Remove(celular);

                return context.SaveChanges();
            }
        }

    }
}
