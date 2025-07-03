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
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.Gerente
{
    public partial class GerenteInicio : Form
    {
        private UC_CrearDescuento crearDescuento;
        private UC_Descuentos descuentos;
        private UC_EditarDescuento editarDescuento;
        public GerenteInicio()
        {
            InitializeComponent();
            crearDescuento = new UC_CrearDescuento();
            descuentos = new UC_Descuentos();
            editarDescuento = new UC_EditarDescuento();
        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedor.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedor.Controls.Add(control);      // Agrega el nuevo
        }
        public void CargarPantalla()
        {
            InitializeComponent();
            crearDescuento = new UC_CrearDescuento();
            descuentos = new UC_Descuentos();
            editarDescuento = new UC_EditarDescuento();
        }
        public void MostrarPrincipal()
        {
            this.Opacity = 0;
            this.Controls.Clear();
            CargarPantalla();
            this.Opacity = 1;
        }
        
        private void btnDescuentos_Click(object sender, EventArgs e)
        {
            CargarUserControl(descuentos);
            descuentos.CargarDescuentos();

        }

        public void CargarDescuentos()
        {
            CargarUserControl(descuentos);
            descuentos.CargarDescuentos();
        }
        private void btnTarjetaPuntos_Click(object sender, EventArgs e)
        {
            
        }
        public void MostrarCrearDescuento()
        {
            CargarUserControl(crearDescuento);
        }
        public void MostrarEditarDescuento(BE.Descuento unDescuento)
        {
            CargarUserControl(editarDescuento);
            editarDescuento.CargarDescuento(unDescuento);
        }

        private void btnCerrarSesionGerente_Click(object sender, EventArgs e)
        {
            // Limpiar la sesión
            SesionActual.UsuarioLogueado = null;


            // Cerrar el formulario actual
            this.Close();
        }

        private void btnEditarPerfilGerente_Click(object sender, EventArgs e)
        {
            CargarUserControl(new UC_EditarUsuario());
        }
    }
}
