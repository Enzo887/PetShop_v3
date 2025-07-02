using BE;
using LoginPetShop_v1.Veterinario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Administracion
{
    public partial class UC_AdministrarUsuarios : UserControl
    {
        BLL.Administrador unAdminBLL = new BLL.Administrador();
        private List<BE.Usuario> listaOriginalUsuarios;

        public UC_AdministrarUsuarios()
        {
            InitializeComponent();
            ActualizarTablaUsuarios();
            listaOriginalUsuarios = unAdminBLL.ObtenerUsuarios();


        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            RegistrarUsuario();
            ActualizarTablaUsuarios();
        }

        //crear editarUsuario y borrar usuario, los procs ya estan creados
        public void RegistrarUsuario() 
        {
           
                //creo una instancia de admnistrador de BLL que es la que opera con los metodos
                BLL.Administrador unAdmin = new BLL.Administrador();
            string tipoUsuario;


            if (comboxSeleccionRolNuevoUsuario.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciones un rol.");
                return;
            }
            else 
            {
              tipoUsuario = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
            }


                //validaciones
                string nombre = tboxNombreUsuarioCrear.Text;
                string apellido = tboxApellidoUsuarioCrear.Text;
                string nombreUsuario = tboxNUsuarioCrear.Text;
                string contraseña = tboxContraseñaUsuarioCrear.Text;
                string textoDNI = tboxDniUsuario.Text;
                int dni;

                if (!int.TryParse(textoDNI, out dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido (solo números).");
                    return;
                }

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
                if (string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, ingrese un nombre de usuario.");
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
                            MessageBox.Show($"Se registro el usuario con id {unUsuario.UsuarioID} correctamente");
                        }
                        ;
                        break;
                    case "Gerente":
                        unUsuario = new BE.Gerente();
                        {
                            unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                            unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                            unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                            unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                            unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                            //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                            unUsuario.Rol = "2";
                            unAdmin.RegistrarUsuario(unUsuario);
                            MessageBox.Show($"Se registro el usuario con id {unUsuario.UsuarioID} correctamente");
                        }
                        ;
                        break;
                    case "Vendedor":
                        unUsuario = new BE.Vendedor();
                        {
                            unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                            unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                            unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                            unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                            unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                            //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                            unUsuario.Rol = "3";
                            unAdmin.RegistrarUsuario(unUsuario);
                            MessageBox.Show($"Se registro el usuario con id {unUsuario.UsuarioID}  correctamente");
                        }
                        ;
                        break;
                    case "Veterinario":
                        unUsuario = new BE.Veterinario();
                        {
                            unUsuario.Nombre = tboxNombreUsuarioCrear.Text;
                            unUsuario.Apellido = tboxApellidoUsuarioCrear.Text;
                            unUsuario.NombreUsuario = tboxNUsuarioCrear.Text;
                            unUsuario.Contraseña = tboxContraseñaUsuarioCrear.Text;
                            unUsuario.DNI = int.Parse(tboxDniUsuario.Text);
                            //unUsuario.Rol = comboxSeleccionRolNuevoUsuario.SelectedItem.ToString();
                            unUsuario.Rol = "4";
                            unAdmin.RegistrarUsuario(unUsuario);
                            MessageBox.Show($"Se registro el usuario con id {unUsuario.UsuarioID} correctamente");
                        }
                        ;
                        break;
                }
            
            LimpiarCampos();
        
            
        }

        public void ActualizarTablaUsuarios()
        {
           List<BE.Usuario> usuarios = unAdminBLL.ObtenerUsuarios();

            DGridViewUsuarios.AutoGenerateColumns = false;
 
            DGridViewUsuarios.Columns["cID"].DataPropertyName = "UsuarioID";
            DGridViewUsuarios.Columns["cNUsuario"].DataPropertyName = "NombreUsuario";
            DGridViewUsuarios.Columns["cNombre"].DataPropertyName = "Nombre";
            DGridViewUsuarios.Columns["cApellido"].DataPropertyName = "Apellido";
            DGridViewUsuarios.Columns["cRolUsuario"].DataPropertyName = "Rol";

            DGridViewUsuarios.DataSource = usuarios;

            
        }
        public void LimpiarCampos() 
        {
            comboxSeleccionRolNuevoUsuario.SelectedText = "";
            tboxNombreUsuarioCrear.Text = "";
            tboxApellidoUsuarioCrear.Text = "";
            tboxNUsuarioCrear.Text = "";
            tboxDniUsuario.Text = "";
            tboxContraseñaUsuarioCrear.Text = "";
        }

        private void DGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BE.Usuario unUsuario= new BE.Usuario();

            //lleva a la edicion de producto
            if (DGridViewUsuarios.Columns[e.ColumnIndex].Name == "cEditarUsuario")
            {
                //obtiene el id del producto que esta en la fila
                int idUsuario = Convert.ToInt32(DGridViewUsuarios.Rows[e.RowIndex].Cells["cID"].Value);

                var adminInicio = this.FindForm() as AdminInicio;

                //estoy haciendo que el boton editar en el data grid me lleve a la edicion de usuario

                if (adminInicio != null)
                {   //pasa el id como parametro para encontrar el producto
                    adminInicio.MostrarEditarUsuario(idUsuario);
                }
                else
                {
                    MessageBox.Show("No se encontro el form");
                }
            }
        }


        private void tBoxBuscarUsuario_Enter(object sender, EventArgs e)
        {
            if (tboxBuscarUsuario.Text == "Buscar por \"ID\" o \"Nombre de usuario\"")
            {
                tboxBuscarUsuario.Text = "";
                tboxBuscarUsuario.ForeColor = Color.Black;//borra el texto por defecto y pone la fuente en negra
            }
            ActualizarTablaUsuarios();
        }

        private void tBoxBuscarUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tboxBuscarUsuario.Text))
            {
                tboxBuscarUsuario.Text = "Buscar por \"ID\" o \"Nombre de usuario\"";
                tboxBuscarUsuario.ForeColor = Color.Gray;//pone el texto por defecto y pone la fuente gris
            }
            ActualizarTablaUsuarios();
        }


        private void tboxBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            string filtro = tboxBuscarUsuario.Text.Trim().ToLower();

            // Filtrás la lista original por ID (como string) o por nombre de usuario
            var filtrados = listaOriginalUsuarios
                .Where(u => u.NombreUsuario.ToLower().Contains(filtro) || u.UsuarioID.ToString().Contains(filtro))
                .ToList();

            DGridViewUsuarios.DataSource = null;
            DGridViewUsuarios.DataSource = filtrados;
        }

        private void DGridViewUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGridViewUsuarios.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                return; // No hace nada, deja que el botón se maneje por CellContentClick
            }

            // Validar que se hizo clic en una fila válida (evita encabezados)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DGridViewUsuarios.Rows[e.RowIndex];

                // Toma el valor de la columna que quieras (por nombre o índice)
                string valor = fila.Cells["NombreProducto"].Value.ToString(); 

                tboxBuscarUsuario.Text = valor;
                tboxBuscarUsuario.ForeColor = Color.Black; // pone el texto en negro para que se note
            }
        }

        private void btnBorrarBusqueda_Click(object sender, EventArgs e)
        {
            //borra todo lo que esta en la barra de busqueda y pone un texto por defecto
            tboxBuscarUsuario.Text = "";
            tboxBuscarUsuario.Text = "Buscar por \"ID\" o \"Nombre de usuario\"";
            tboxBuscarUsuario.ForeColor = Color.Gray;

            ActualizarTablaUsuarios();
        }
    }
}
