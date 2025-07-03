using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginPetShop_v1.ControlesGenerales;
using LoginPetShop_v1.Veterinario;
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.Vendedor
{
    public partial class VendedorHome : Form
    {
        private UC_RegistrarVenta RegistrarVenta;

        public VendedorHome()
        {
            InitializeComponent();
            CargarUserControl(RegistrarVenta = new UC_RegistrarVenta());
        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            CargarUserControl(RegistrarVenta = new UC_RegistrarVenta() );
        }

        private void btnGestionarStock_Click(object sender, EventArgs e)
        {
            CargarUserControl ( new UC_GestionarStock() );
        }
        public void MostrarPrincipal()
        {
            //RegistrarVenta.Visible = false;
            this.Close();
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_RegistrarCliente());
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_EditarUsuario());
        }
        public void VolverAPantallaPrincipal()
        {
            CargarUserControl(RegistrarVenta);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Limpiar la sesión
            SesionActual.UsuarioLogueado = null;

            // Mostrar el login de nuevo
            //formInicio loginForm = new formInicio();
            //loginForm.Show();

            // Cerrar el formulario actual
            this.Close();
        }
    }
}
