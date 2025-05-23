using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Administracion
{
    public partial class AdminInicio : Form
    {
        public AdminInicio()
        {
            InitializeComponent();
        }

        private void CargarUserControl(UserControl control)
        {
            panelContenedorAdmin.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedorAdmin.Controls.Add(control);      // Agrega el nuevo
        }

        private void btnAdminstrarRoles_Click(object sender, EventArgs e)
        {
            CargarUserControl(new AdministracionDeRol()); 
        }

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_VerEstadisticas());
        }

        private void panelContenedorAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConfigurarAlertas_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_ConfigurarAlertas());
        }

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_AdministrarUsuarios());
        }
    }
}
