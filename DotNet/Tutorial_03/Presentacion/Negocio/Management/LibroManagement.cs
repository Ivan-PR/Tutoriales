using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositorys;
using Datos.Infrastructure;
using Negocio.EntitiesDTO;

namespace Negocio.Management
{
    public class LibroManagement
    {
        public List<LibrosDTO> ObtenerLibros()
        {
            List<Libro> LibrosDatos = new LibroRepository().ObtenerLibros();
            List<LibrosDTO> ListadoRetorno = new List<LibrosDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibrosDTO();
                Utils.parse(item, ref dto);

                // dto.idLibro = item.idLibro; dto.Nombre = item.Nombre; dto.Autor = item.Autor;
                // dto.FechaPublicacion = item.FechaPublicacion; dto.idCategoria = item.idCategoria;
                ListadoRetorno.Add(dto);
            }

            return ListadoRetorno;
        }

        public List<CategoriaDTO> ObtenerCategorias()
        {
            List<Categoria> CategoriaDatos = new LibroRepository().ObtenerCategorias();
            List<CategoriaDTO> ListadoRetorno = new List<CategoriaDTO>();
            foreach (var item in CategoriaDatos)
            {
                var dto = new CategoriaDTO();
                Utils.parse(item, ref dto);
                // dto.Nombre = item.Nombre;
                // dto.idCategoria = item.idCategoria;
                ListadoRetorno.Add(dto);
            }

            return ListadoRetorno;
        }

        public void AltaLibro(LibrosDTO libroAlta)
        {
            Libro LibroBaseDatos = new Libro();
            Utils.parse(libroAlta, ref LibroBaseDatos);

            //LibroBaseDatos.Nombre = libroAlta.Nombre;
            //LibroBaseDatos.Autor = libroAlta.Autor;
            //LibroBaseDatos.FechaPublicacion = libroAlta.FechaPublicacion;
            //LibroBaseDatos.idCategoria = libroAlta.idCategoria;

            new LibroRepository().AltaLibro(LibroBaseDatos);
        }

        public void ModificarLibro(LibrosDTO libroModificado)
        {
            Libro LibroBaseDatos = new Libro();
            Utils.parse(libroModificado, ref LibroBaseDatos);

            //LibroBaseDatos.idLibro = libroModificado.idLibro;
            //LibroBaseDatos.Nombre = libroModificado.Nombre;
            //LibroBaseDatos.Autor = libroModificado.Autor;
            //LibroBaseDatos.FechaPublicacion = libroModificado.FechaPublicacion;
            //LibroBaseDatos.idCategoria = libroModificado.idCategoria;

            new LibroRepository().ModificarLibro(LibroBaseDatos);
        }

        public void EliminarLibro(LibrosDTO libroEliminar)
        {
            new LibroRepository().EliminarLibro(libroEliminar.idLibro);
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new LibroRepository().VerificarUnidades(idLibro);
        }

        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {
            List<ObetenerLibrosConUnidades_Result> LibrosDatos = new LibroRepository().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibroConUnidadesDTO();
                Utils.parse(item, ref dto);

                //dto.AutorDelLibro = item.AutorDelLibro;
                //dto.NombreDelLibro = item.NombreDelLibro;
                //dto.Unidades = item.Unidades;
                ListadoRetorno.Add(dto);
            }

            return ListadoRetorno;
        }
    }
}