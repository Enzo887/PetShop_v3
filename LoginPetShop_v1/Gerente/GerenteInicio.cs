using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Gerente
{
    public partial class GerenteInicio : Form
    {
        public GerenteInicio()
        {
            InitializeComponent();
        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
        }
        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_Descuentos());
        }

        private void btnTarjetaPuntos_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_CrearTarjeta());
        }
    }
}
