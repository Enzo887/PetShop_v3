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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginPetShop_v1.Vendedor
{
    public partial class UC_RegistrarCliente : UserControl
    {
        private BE.Cliente cliente = new BE.Cliente(); 
        public UC_RegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombre.Text;
            string apellido = tboxApellido.Text;
            string email = tboxEmail.Text;
            string telefono = tboxTelefono.Text;
            string DNI = tboxDni.Text;


            if (string.IsNullOrWhiteSpace(apellido))
            {
                MessageBox.Show("Por favor, ingrese un apellido");
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Por favor, ingrese un nombre");
                return;
            }
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Por favor, ingrese un email");
                return;
            }
            if (string.IsNullOrEmpty(telefono) || !telefono.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese el telefono correctamente");
                return;
            }

            if (telefono.Length < 7 || telefono.Length > 10) 
            {
                MessageBox.Show("El telefono debe tener entre 7 y 15 digitos");
                return;
            }
            if (string.IsNullOrEmpty(DNI) || !DNI.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese el DNI con numeros porfavor");
                return;
            }
            if (DNI.Length < 7 || DNI.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 numeros");
                return;
            }

            int telefonoEntero = int.Parse(telefono);
            int DNIEntero = int.Parse(DNI);

            
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Email = email;
            cliente.Telefono = telefonoEntero;
            cliente.DNI = DNIEntero;
            BLL.Cliente clienteBLL = new BLL.Cliente();
            clienteBLL.RegistrarCliente(cliente);
            MessageBox.Show("Se registro el cliente correctamente");

            //"reseteo"
            cliente = new BE.Cliente();
            tboxNombre.Clear();
            tboxApellido.Clear();
            tboxEmail.Clear();
            tboxTelefono.Clear();
            tboxDni.Clear();
        }
    }
}
