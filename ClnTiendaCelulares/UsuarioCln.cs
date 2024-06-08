using CadTiendaCelulares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnTiendaCelulares
{
    public class UsuarioCln
    {

        public static usuarios validar(string email, string password)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                return context.usuarios
                    .Where(x => x.email == email && x.password == password)
                    .FirstOrDefault();
            }
        }

        public static int insertar(usuarios usuario)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                context.usuarios.Add(usuario);
                context.SaveChanges();
                return usuario.id;
            }
        }

        public static int actualizar(usuarios usuario)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                var existente = context.usuarios.Find(usuario.id);
                existente.email = usuario.email;
                existente.password = usuario.password;
                existente.nombre = usuario.nombre;
              
                return context.SaveChanges();
            }
        }
        public static usuarios obtenerUno(int id)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                return context.usuarios.Find(id);
            }
        }

        public static List<usuarios> listar()
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                return context.usuarios.ToList();
            }
        }

        public static int eliminar(int id)
        {
            using (var context = new LabTiendaCelularesEntities1())
            {
                var usuario = context.usuarios.Find(id);
                var producto = context.usuarios.Remove(usuario);

                return context.SaveChanges();
            }
        }

    }
}
