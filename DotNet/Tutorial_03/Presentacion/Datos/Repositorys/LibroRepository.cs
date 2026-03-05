using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;

namespace Datos.Repositorys
{
    public class LibroRepository
    {
        public List<Libro> ObtenerLibros()
        {
            List<Libro> listadoRetorno = new List<Libro>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listadoRetorno = contexto.Libros.ToList();
                }

                return listadoRetorno;
            }
            catch
            {
                return listadoRetorno;
            }
        }

        public List<ObetenerLibrosConUnidades_Result> ObtenerLibrosConUnidades()
        {
            List<ObetenerLibrosConUnidades_Result> listadoRetorno = new List<ObetenerLibrosConUnidades_Result>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listadoRetorno = contexto.ObetenerLibrosConUnidades().ToList();
                }

                return listadoRetorno;
            }
            catch
            {
                return listadoRetorno;
            }
        }

        public List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listadoRetorno = new List<Categoria>();

            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    listadoRetorno = contexto.Categorias.ToList();
                }

                return listadoRetorno;
            }
            catch
            {
                return listadoRetorno;
            }
        }

        public void AltaLibro(Libro libroAlta)
        {
            using (var contexto = new BibliotecaEntities1())
            {
                contexto.Libros.Add(libroAlta);
                contexto.SaveChanges();
            }
        }

        public void ModificarLibro(Libro nuevoLibro)
        {
            try
            {
                using (var contexto = new BibliotecaEntities1())
                {
                    Libro librOriginal = contexto.Libros.Where(b => b.idLibro == nuevoLibro.idLibro).First();
                    librOriginal.Nombre = nuevoLibro.Nombre;
                    librOriginal.Autor = nuevoLibro.Autor;
                    librOriginal.idCategoria = nuevoLibro.idCategoria;

                    contexto.Entry(librOriginal).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarLibro(Int32 idLibro)
        {
            using (var contexto = new BibliotecaEntities1())
            {
                List<LibrosUnidade> libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
                Libro libroEliminar = contexto.Libros.Where(b => b.idLibro == idLibro).First();

                if (libroConUnidades.Count > 0)
                {
                    contexto.LibrosUnidades.RemoveRange(libroConUnidades);
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
                else
                {
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }
            }
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            List<LibrosUnidade> libroConUnidades = new List<LibrosUnidade>();
            using (var contexto = new BibliotecaEntities1())
            {
                libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
            }

            if (libroConUnidades.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}