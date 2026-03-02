using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;

namespace Datos.Repositorys
{
    public class PruebaDeConexion
    {
        public Boolean ProbarConexion()
        {
            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    List<Libro> librosRetorno = contexto.Libros.ToList();
                }

                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}