using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.EntitiesDTO;
using Negocio.Management;

namespace Presentacion.Views
{
    public partial class AltaLibro : Form
    {
        public LibrosDTO libroMod;

        public AltaLibro(LibrosDTO libro)
        {
            libroMod = libro;
            InitializeComponent();
        }

        public AltaLibro()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (libroMod is null != true)
            {
                libroMod.Nombre = txtNombre.Text;
                libroMod.Autor = txtAutor.Text;
                libroMod.idCategoria = new LibroManagement().ObtenerCategorias().Where(b => b.Nombre == cmbCategoria.Text).First().idCategoria;
                libroMod.FechaPublicacion = DateTime.Now;

                new LibroManagement().ModificarLibro(libroMod);
            }
            else
            {
                LibrosDTO libro = new LibrosDTO();
                libro.Nombre = txtNombre.Text;
                libro.Autor = txtAutor.Text;
                libro.idCategoria = new LibroManagement().ObtenerCategorias().Where(b => b.Nombre == cmbCategoria.Text).First().idCategoria;
                libro.FechaPublicacion = DateTime.Now;

                new LibroManagement().AltaLibro(libro);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = new LibroManagement().ObtenerCategorias().Select(b => b.Nombre).ToList();

            if (libroMod is null != true)
            {
                txtNombre.Text = libroMod.Nombre;
                txtAutor.Text = libroMod.Autor;
                cmbCategoria.Text = new LibroManagement().ObtenerCategorias().Where(b => b.idCategoria == libroMod.idCategoria).First().Nombre;
            }
        }
    }
}