using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginPetShop_v1.Vendedor;

namespace LoginPetShop_v1
{
    public partial class VendedorInicio : Form
    {
        public VendedorInicio()
        {
            InitializeComponent();
        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
        }

        private void margenTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAtenderReserva_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_RegistrarVenta());
        }
    }
}
