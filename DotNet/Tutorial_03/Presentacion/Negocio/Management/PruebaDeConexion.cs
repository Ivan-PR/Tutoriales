using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Management
{
    public class PruebaDeConexion
    {
        public Boolean pruebaDeConexion()
        {
            return new Datos.Repositorys.PruebaDeConexion().ProbarConexion();
        }
    }
}