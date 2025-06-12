using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tboxUsuario.Text;
            string clave = tboxClave.Text;

            BLL.Administrador usuario = new BLL.Administrador();
            BE.Usuario usuarioLogeado =  usuario.Loguearse(nombreUsuario, clave);

            if(usuarioLogeado != null)
            {
                Form formInicio = null;

                switch (usuarioLogeado.Rol)
                {
                    case "admin":
                        formInicio = new Administracion.AdminInicio();
                        break;
                    case "gerente":
                        formInicio = new Gerente.GerenteInicio();
                        break;
                    case "vendedor":
                        formInicio = new Vendedor.VendedorHome();
                        break;
                    case "veterinario":
                        formInicio = new Veterinario.VeterinarioInicio();
                        break;
                    default:
                        MessageBox.Show("Rol de usuario no reconocido");
                        return;
                }

                formInicio.Show();
            }
            else
            {
                MessageBox.Show("El usuario o la clave es incorrecta");
            }
        }
    }
}
