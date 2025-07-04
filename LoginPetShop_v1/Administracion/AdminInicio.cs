using LoginPetShop_v1.ControlesGenerales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.Administracion
{
    public partial class AdminInicio : Form
    {
        private UC_AdministrarUsuarios AdministrarUsuarios;
        private UC_EditarUsuarios EditarUsuarios;
        int idUsuario;
        
        public AdminInicio()
        {
            InitializeComponent();
            
            AdministrarUsuarios = new UC_AdministrarUsuarios();
            EditarUsuarios = new UC_EditarUsuarios(AdministrarUsuarios,idUsuario);
        }

        private void CargarUserControl(UserControl control)
        {
            panelContenedorAdmin.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedorAdmin.Controls.Add(control);      // Agrega el nuevo
        }

        

        private void btnVerEstadisticas_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_VerEstadisticas());
        }

        private void panelContenedorAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnGestionarUsuarios_Click(object sender, EventArgs e)
        {
            MostrarAdministracionUsuarios();
        }

        public void MostrarAdministracionUsuarios() 
        {
            CargarUserControl(AdministrarUsuarios);
        }
        public void MostrarEditarUsuario (int idUsuario)
        {
            UC_EditarUsuarios EditarUsuarios = new UC_EditarUsuarios(AdministrarUsuarios, idUsuario);
            CargarUserControl (EditarUsuarios);
            EditarUsuarios.CargarUsuario(idUsuario);
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_EditarUsuario());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.UsuarioLogueado = null;
            this.Close();
        }
    }
}
