using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenWebinarsForms
{
    public partial class FormAdvancedControls : Form
    {
        private List<Car> cars = new List<Car>();

        public FormAdvancedControls()
        {
            InitializeComponent();
        }

        private void FormAdvancedControls_Load(object sender, EventArgs e)
        {
            cars.Add(new Car() { Name="Focus", Maker="Ford" });

            listBox1.Items.Add("Ford");
            comboBox1.Items.Add("Red");
            listBox1.DataSource=cars;
            listBox1.DisplayMember="Name";

            for (int i = 0; i<10; i++)
            {
                progressBar1.PerformStep();
            }
        }
    }
}