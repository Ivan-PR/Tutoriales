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
    public partial class CustomUserControl : UserControl
    {
        public string LabelTitle
        {
            get => label1.Text; set => label1.Text=value;
        }

        public CustomUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();

            if (result==DialogResult.OK)
            {
                textBox1.Text=openFileDialog1.FileName;
            }
        }
    }
}