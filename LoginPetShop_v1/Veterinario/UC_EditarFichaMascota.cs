using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Veterinario
{
    public partial class UC_EditarFichaMascota : UserControl
    {
        private Mascota mascotaActual;
        private Cliente clienteActual;

        private UC_EditarHistorialMedico editarHistorialMedico;
        public UC_EditarFichaMascota()
        {
            editarHistorialMedico = new UC_EditarHistorialMedico();
            InitializeComponent();
         
            editarHistorialMedico.Dock = DockStyle.Fill;
           
        }

        public void CargarMascota(Mascota mascota, Cliente cliente) 
        {
            mascotaActual=mascota;
            clienteActual=cliente;
            /*mascotaActual.ID = mascota.ID;
            mascotaActual.Nombre = mascota.Nombre;
            mascotaActual.Especie = mascota.Especie;
            mascotaActual.Raza= mascota.Raza;
            mascotaActual.Sexo= mascota.Sexo;
            mascotaActual.Peso= mascota.Peso;
            mascotaActual.FechaDeNacimiento=mascota.FechaDeNacimiento;

            clienteActual.Nombre=cliente.Nombre;
            clienteActual.Apellido= cliente.Apellido;
            clienteActual.DNI = cliente.DNI;
            clienteActual.Email= cliente.Email;
            clienteActual.Telefono= cliente.Telefono;*/

            //le asigno el paso a la variable valor de tipo float
            float valor = mascotaActual.Peso;
            //convierto la variable valor en valor decimal para pasarlo
            decimal valorDecimal = (decimal)valor;

            tBoxNombreMascota.Text = mascotaActual.Nombre.ToString();
            cBoxEspecie.Text = mascotaActual.Especie.ToString();
            cBoxRaza.Text = mascotaActual.Raza.ToString();
            cBoxSexo.Text = mascotaActual.Sexo.ToString();
            numericUpDownPeso.Value = valorDecimal;
            dTPFechaNacimientoMascota.Value = mascotaActual.FechaDeNacimiento;

            tBoxNombreDueño.Text = clienteActual.Nombre.ToString();
            tBoxApellidoDueño.Text = clienteActual.Apellido.ToString();
            tBoxDniDueño.Text = clienteActual.DNI.ToString();
            tBoxMail.Text = clienteActual.Email.ToString();
            tboxTelefonoDueño.Text = clienteActual.Telefono.ToString();
            
        }
        private void MostrarEdicionHistorial()
        {
            this.Visible = false;
            
            editarHistorialMedico.Visible = true;
            
        }
        private void btnVerHistorialMedico_Click(object sender, EventArgs e)
        {
            MostrarEdicionHistorial();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            
            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarPrincipal();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }
        string[] razasPerro =
       {
            "Labrador",
            "Bulldog",
            "Pastor Alemán",
            "Beagle",
            "Golden Retriever",
            "Caniche",
            "Chihuahua",
            "Boxer",
            "Dachshund(salchicha)",
            "Rottweiler",
            "Shih Tzu",
            "Doberman",
            "Border Collie",
            "Cocker"
        };

        string[] razasGato =
        {
            "Siamés",
            "Persa",
            "Maine Coon",
            "Bengala",
            "Sphynx",
            "Ragdoll",
            "Scottish Fold",
            "British Shorthair",
            "Azul Ruso",
            "Himalayo",
            "American Shorthair",
            "Exótico de Pelo Corto",
            "Burmese",
            "Noruego de Bosque",
            "Ocicat"
        };
        private void cBoxRaza_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxEspecie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxRaza.Items.Clear();
            if (cBoxEspecie.SelectedItem == null) { return; }

            string especieSeleccionada = cBoxEspecie.SelectedItem.ToString();

            if (especieSeleccionada == "Perro")
            {
                cBoxRaza.Items.AddRange(razasPerro);
            }
            else if (especieSeleccionada == "Gato")
            {
                cBoxRaza.Items.AddRange(razasGato);
            }

            if (cBoxRaza.Items.Count > 0)
            {
                cBoxRaza.SelectedIndex = 0;
            }
        }

        private void cBoxEspecie_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {

        }
    }
}
