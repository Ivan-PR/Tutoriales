using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.EntitiesDTO;
using Negocio.Management;
using Presentacion.Views;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            if (new Negocio.Management.PruebaDeConexion().pruebaDeConexion())
            {
                lblResultado.Text = "La conexión es correcta";
            }
            else
            {
                lblResultado.Text = "La conexión es Fallida";
            }

            lblResultado.Visible = true;
        }

        private void btnAltaLibro_Click(object sender, EventArgs e)
        {
            AltaLibro pantallaAlta = new AltaLibro();
            pantallaAlta.ShowDialog();
            dataGridView1.DataSource = new LibroManagement().ObtenerLibros();
        }

        private void btnModificacionLibro_Click(object sender, EventArgs e)
        {
            LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as LibrosDTO;
            AltaLibro pantallaAlta = new AltaLibro(LibroSeleccionado);
            pantallaAlta.ShowDialog();
            dataGridView1.DataSource = new LibroManagement().ObtenerLibros();
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as LibrosDTO;

                if (new LibroManagement().VerificarUnidades(LibroSeleccionado.idLibro))
                {
                    DialogResult Respuesta = MessageBox.Show("Este Libro contiene Unidades" + System.Environment.NewLine + "¿Estas seguro de querer Eliminarlo?", "Validación", MessageBoxButtons.YesNo);

                    if (Respuesta == DialogResult.Yes)
                    {
                        new LibroManagement().EliminarLibro(LibroSeleccionado);
                    }
                }
                else
                {
                    new LibroManagement().EliminarLibro(LibroSeleccionado);
                }
                dataGridView1.DataSource = new LibroManagement().ObtenerLibros();
            }
        }

        private void btnConsultaLibros_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LibroManagement().ObtenerLibros();
        }

        private void btnConsultaConUnidades_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new LibroManagement().ObtenerLibrosUnidades();
        }
    }
}