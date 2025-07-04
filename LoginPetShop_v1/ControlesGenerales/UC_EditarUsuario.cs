using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginPetShop_v1.Administracion;
using LoginPetShop_v1.Gerente;
using LoginPetShop_v1.Vendedor;
using LoginPetShop_v1.Veterinario;
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.ControlesGenerales
{
    public partial class UC_EditarUsuario : UserControl
    {
        private BE.Usuario usuarioActual;
        public UC_EditarUsuario()
        {
            InitializeComponent();
            usuarioActual = SesionActual.UsuarioLogueado;
            CargarDatosUsuario();
        }

        private void CargarDatosUsuario()
        {
            tboxNombre.Text = usuarioActual.Nombre;
            tboxApellido.Text = usuarioActual.Apellido;
            tboxNombreUsuario.Text = usuarioActual.NombreUsuario;
            tboxDNI.Text = usuarioActual.DNI.ToString();
            tboxContraseña.Text = usuarioActual.Contraseña;

        }

        private void chBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxMostrarContraseña.Checked)
            {
                // Mostrar contraseña
                tboxContraseña.PasswordChar = '\0'; // \0 no oculta nada
            }
            else
            {
                tboxContraseña.PasswordChar = '*';
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            usuarioActual.Nombre = tboxNombre.Text;
            usuarioActual.Apellido = tboxApellido.Text;
            usuarioActual.NombreUsuario = tboxNombreUsuario.Text;
            usuarioActual.DNI = Convert.ToInt32(tboxDNI.Text);
            usuarioActual.Contraseña = tboxContraseña.Text;

            BLL.Usuario unUsuarioBLL = new BLL.Usuario();
            unUsuarioBLL.EditarPerfil(usuarioActual);
            MessageBox.Show("Se actualizaron los cambios correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var formPadre = this.FindForm();
            //dependiendo de quien lo contenga vuelve a su respectiva pantallaPrincipal
            if (formPadre is VendedorHome vendedor)
            {
                this.Parent.Controls.Remove(this);
                vendedor.VolverAPantallaPrincipal();
            }
            else if (formPadre is VeterinarioInicio veterinario)
            {
                this.Parent.Controls.Remove(this);
                veterinario.VolverAPantallaPrincipal();

            }
            else if (formPadre is GerenteInicio gerente)
            {
                this.Parent.Controls.Remove(this);
                //gerente.VolverAPantallaPrincipal(); se debe agregar a GerenteInicio
            }
            else if (formPadre is AdminInicio admin)
            {
                this.Parent.Controls.Remove(this);
                //admin.VolverAPantallaPrincipal(); se debe agregar a AdminInicio
            }
            else
            {
                MessageBox.Show("No se encontró el formulario contenedor.");
            }
        }
    }
}
