using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Vendedor
{
    public partial class VendedorHome : Form
    {
        public VendedorHome()
        {
            InitializeComponent();
        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            CargarUserControl( new UC_RegistrarVenta() );
        }
    }
}
