using LoginPetShop_v1.Veterinario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Administracion
{
    public partial class UC_EditarUsuarios : UserControl
    {
        BLL.Administrador unAdminBLL = new BLL.Administrador();
        int UsuarioID;
        private UC_AdministrarUsuarios AdministrarUsuarios;
        public UC_EditarUsuarios(UC_AdministrarUsuarios AdministrarUsuariosExistente, int idUsuario)
        {
            AdministrarUsuarios = AdministrarUsuariosExistente;
            UsuarioID = idUsuario;
            InitializeComponent();

        }

        public void CargarUsuario(int idUsuario)
        {

            //llena los campos con la info del producto ya sea vacuna o medicamento


            BE.Usuario usuario = unAdminBLL.ObtenerUsuarioPorID(idUsuario);

            if (usuario != null)
            {

                tboxNombre.Text = usuario.Nombre;
                tboxApellido.Text = usuario.Apellido;
                tboxContraseña.Text = usuario.Contraseña;
                tboxDni.Text = usuario.DNI.ToString();
                tboxNUsuario.Text = usuario.NombreUsuario;
                cboxSeleccionRol.Text = usuario.Rol;


            }
            else
            {
                MessageBox.Show("No se encontró el usuario.");
            }

        }

 
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Al eliminar un usuario este no se podra repurar, esta seguro de eliminar este usuario?", "Confirmar Eliminacion", MessageBoxButtons.OKCancel);
            if (resultado == DialogResult.OK)
            {

                unAdminBLL.EliminarUsuario(UsuarioID);
            }

            var adminInicio = this.FindForm() as AdminInicio;


            if (adminInicio != null)
            {
                adminInicio.MostrarAdministracionUsuarios();
                AdministrarUsuarios.ActualizarTablaUsuarios();
              
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            BE.Usuario usuario = unAdminBLL.ObtenerUsuarioPorID(UsuarioID);

            usuario.Nombre = tboxNombre.Text;
            usuario.Apellido = tboxApellido.Text;
            usuario.NombreUsuario = tboxNUsuario.Text;
            usuario.Contraseña = tboxContraseña.Text;
            usuario.DNI = int.Parse(tboxDni.Text);
            usuario.Rol = cboxSeleccionRol.Text;


            unAdminBLL.EditarUsuario(usuario);



            MessageBox.Show("Cambios guardados correctamente");

            var adminInicio = this.FindForm() as AdminInicio;


            if (adminInicio != null)
            {
                adminInicio.MostrarAdministracionUsuarios();
                AdministrarUsuarios.ActualizarTablaUsuarios();

            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var adminInicio = this.FindForm() as AdminInicio;


            if (adminInicio != null)
            {
                adminInicio.MostrarAdministracionUsuarios();
                AdministrarUsuarios.ActualizarTablaUsuarios();

            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }
    }
}
