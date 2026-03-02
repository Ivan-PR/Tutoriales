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
        }

        private void btnModificacionLibro_Click(object sender, EventArgs e)
        {
        }

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
        }
    }
}