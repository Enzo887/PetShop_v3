using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Veterinario
{
    public partial class VeterinarioStock : UserControl
    {
        public VeterinarioStock()
        {
            InitializeComponent();
        }

        private void lblProductos_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            VeterinarioInicio main = new VeterinarioInicio();
            main.Show();
            Form esteform = this.FindForm();
            esteform.Close();
        }
    }
}
