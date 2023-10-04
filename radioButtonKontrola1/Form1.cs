using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radioButtonKontrola1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (radBtnAvion.Checked)
            {

                textBox1.Text = "Odabrali ste prijevoz avionom.";

            }
            if (radBtnAutobus.Checked)
            {

                textBox1.Text = "Odabrali ste prijevoz autobusom.";

            }
            if (radBtnVlastitiPrijevoz.Checked)
            {

                textBox1.Text = "Odabrali ste vlastiti prijevoz.";

            }
        }
    }
}
