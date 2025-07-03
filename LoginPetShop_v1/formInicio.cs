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
        public static class SesionActual
        {
            private static BE.Usuario _usuarioLogueado;

            public static BE.Usuario UsuarioLogueado
            {
                get { return _usuarioLogueado; }
                set { _usuarioLogueado = value; }
            }
        }
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

            BLL.Usuario usuario = new BLL.Usuario();
            BE.Usuario usuarioLogeado =  usuario.Loguearse(nombreUsuario, clave);

            if (usuarioLogeado != null)
            {
                // Asigno el Usuario en el tipo que debe ser
                BE.Usuario usuarioEspecifico = null;

                switch (usuarioLogeado.Rol)
                {
                    case "admin":
                        usuarioEspecifico = new BE.Administrador
                        {
                            UsuarioID = usuarioLogeado.UsuarioID,
                            Nombre = usuarioLogeado.Nombre,
                            Apellido = usuarioLogeado.Apellido,
                            NombreUsuario = usuarioLogeado.NombreUsuario,
                            Contraseña = usuarioLogeado.Contraseña,
                            DNI = usuarioLogeado.DNI,
                            Rol = usuarioLogeado.Rol
                        };
                        break;

                    case "gerente":
                        usuarioEspecifico = new BE.Gerente
                        {
                            UsuarioID = usuarioLogeado.UsuarioID,
                            Nombre = usuarioLogeado.Nombre,
                            Apellido = usuarioLogeado.Apellido,
                            NombreUsuario = usuarioLogeado.NombreUsuario,
                            Contraseña = usuarioLogeado.Contraseña,
                            DNI = usuarioLogeado.DNI,
                            Rol = usuarioLogeado.Rol
                        };
                        break;

                    case "vendedor":
                        usuarioEspecifico = new BE.Vendedor
                        {
                            UsuarioID = usuarioLogeado.UsuarioID,
                            Nombre = usuarioLogeado.Nombre,
                            Apellido = usuarioLogeado.Apellido,
                            NombreUsuario = usuarioLogeado.NombreUsuario,
                            Contraseña = usuarioLogeado.Contraseña,
                            DNI = usuarioLogeado.DNI,
                            Rol = usuarioLogeado.Rol
                        };
                        break;

                    case "veterinario":
                        usuarioEspecifico = new BE.Veterinario
                        {
                            UsuarioID = usuarioLogeado.UsuarioID,
                            Nombre = usuarioLogeado.Nombre,
                            Apellido = usuarioLogeado.Apellido,
                            NombreUsuario = usuarioLogeado.NombreUsuario,
                            Contraseña = usuarioLogeado.Contraseña,
                            DNI = usuarioLogeado.DNI,
                            Rol = usuarioLogeado.Rol
                        };
                        break;

                    default:
                        MessageBox.Show("Rol de usuario no reconocido");
                        return;
                }

                // Se guarda la sesion con el tipo correcto
                SesionActual.UsuarioLogueado = usuarioEspecifico;

                //Muestro pantallas segun Rol
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

        private void chBoxMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxMostrarContraseña.Checked)
            {
                // Mostrar contraseña
                tboxClave.PasswordChar = '\0'; // \0 no oculta nada
            }
            else
            {
                tboxClave.PasswordChar = '*';
            }
        }
    }
}
