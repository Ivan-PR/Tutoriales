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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            buttonExtended1.Click+=ButtonExtend1Click;
        }

        private void ButtonExtend1Click(object sender, EventArgs e)
        {
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            buttonExtended1.Click-=ButtonExtend1Click;
        }
    }
}