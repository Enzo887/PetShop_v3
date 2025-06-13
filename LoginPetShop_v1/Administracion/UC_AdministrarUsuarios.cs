using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;

namespace LoginPetShop_v1.Administracion
{
    public partial class UC_AdministrarUsuarios : UserControl
    {
        public UC_AdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //creo una instancia de admnistrador de BLL que es la que opera con los metodos
            BLL.Administrador unAdmin = new BLL.Administrador();
            string tipoUsuario = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
            //validaciones
            string nombre = tboxNombreUsuarioCrear.Text;
            string apellido = tboxApellidoUsuarioCrear.Text;
            string nombreUsuario = tboxNUsuarioCrear.Text;
            int dni = int.Parse(tboxDniUsuario.Text);

            // Validaciones generales
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre para el usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor, ingrese un apellido para el usuario.");
                return;
            }
            if (string.IsNullOrWhiteSpace(nombreUsuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.");
                return;
            }
            if (nombreUsuario.Length < 8)
            {
                MessageBox.Show("El nombre de usuario debe tener al menos 8 caracteres.");
                return;
            }

            BE.Usuario unUsuario;
            //dependiendo de que tipo se elija en el combo box se va a instanciar una entidad ya sea admin, gerente, vendedor, veterinario
            switch (tipoUsuario)
            {
                case "Administrador":
                    unUsuario = new BE.Administrador();
                    {
                        unUsuario.Nombre = nombre;
                        unUsuario.Apellido = apellido;
                        unUsuario.NombreUsuario = nombreUsuario;
                        unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                        unUsuario.DNI = dni;
                        //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                        unUsuario.Rol = "1";
                        //llamo al metodo registrar usuario de adminBLL
                        unAdmin.RegistrarUsuario(unUsuario);
                        MessageBox.Show("Se registro el usuario correctamente");
                    };
                    break;
                case "Gerente":
                    unUsuario = new BE.Administrador();
                    {
                        unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                        unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                        unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                        unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                        unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                        //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                        unUsuario.Rol = "2";
                        unAdmin.RegistrarUsuario(unUsuario);
                        MessageBox.Show("Se registro el usuario correctamente");
                    };
                    break;
                case "Vendedor":
                    unUsuario = new BE.Administrador();
                    {
                        unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                        unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                        unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                        unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                        unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                        //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                        unUsuario.Rol = "3";
                        unAdmin.RegistrarUsuario(unUsuario);
                        MessageBox.Show("Se registro el usuario correctamente");
                    };
                    break;
                case "Veterinario":
                    unUsuario = new BE.Administrador();
                    {
                        unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                        unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                        unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                        unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                        unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                        //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                        unUsuario.Rol = "4";
                        unAdmin.RegistrarUsuario(unUsuario);
                        MessageBox.Show("Se registro el usuario correctamente");
                    };
                    break;
            }

        }
    }
}
