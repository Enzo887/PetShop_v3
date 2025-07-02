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
    public partial class UC_CrearFichaMascota : UserControl
    {
        public UC_CrearFichaMascota()
        {
            InitializeComponent();

        }
             
        private void tBoxNombreMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxEspecieMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxRazaMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBoxSexoMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //this.FindForm() busca el formulario contenedor (la ventana) en la que está actualmente
            //as FormPrincipal intenta hacer un cast seguro del formulario encontrado a la clase FormPrincipal
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            //si no encuentra un tipo FormPrincipsl devuelve null y el if lo filtra para evitar excepciones
            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarPrincipal();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

       
        private void btnCrear_Click(object sender, EventArgs e)
        {

            try
            {
                //convertimos los datos que vienen como texto
                int dni = int.Parse(tBoxDniDueño.Text);
                int telefono = int.Parse(tboxTelefonoDueño.Text);
                float peso = (float)numericUpDownPeso.Value;

                //Creamos el objeto cliente con los datos que vienen del form
                var cliente = new Cliente
                {
                    Nombre = tBoxNombreDueño.Text,
                    Apellido = tBoxApellidoDueño.Text,
                    DNI = dni,
                    Telefono = telefono,
                    Email = tBoxMail.Text
                };
                //Creamos el objeto mascota con los datos que vienen del form y le asignamos el cliente creado como dueño
                var mascota = new Mascota
                {
                    Nombre = tBoxNombreMascota.Text,
                    Especie = cBoxEspecie.Text,
                    Raza = cBoxRaza.Text,
                    Sexo = cBoxSexo.Text,
                    Peso = peso,
                    FechaDeNacimiento = dTPFechaNacimientoMascota.Value,
                    Dueño = cliente
                };
                //Creamos el objeto ficha con la mascota y el dueño, ademas de que le guardamos la fecha actual como la fecha del registro
                var ficha = new FichaMedica
                {
                    Mascota = mascota,
                    FechaDeRegistro = DateTime.Now,
                    Cliente = cliente
                };

                //Creamos una instancia de veterinario de la capa BLL que para llamar al metodo que va a crear y le pasamos la ficha, mascota y cliente 
                BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
                int idMascota = unVeterinarioBLL.CrearFichaMascota(ficha, mascota, cliente);

                MessageBox.Show("Ficha médica creada correctamente");

                //Una vez creada la ficha nos devuelve al form principal donde actualiza y agrega la ficha de la nueva mascota al datagrid
                var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                if (veterinarioInicio != null)
                {
                    veterinarioInicio.AgregarFila(idMascota, tBoxNombreMascota.Text);
                    veterinarioInicio.MostrarPrincipal();
                    veterinarioInicio.MostrarFichasMascotas();
                }

                // Limpiar campos
                tBoxNombreMascota.Clear();
                cBoxEspecie.SelectedIndex = -1;
                cBoxRaza.SelectedIndex = -1;
                cBoxSexo.SelectedIndex = -1;
                numericUpDownPeso.Value = 0;
                dTPFechaNacimientoMascota.Value = DateTime.Today;
                tBoxNombreDueño.Clear();
                tBoxApellidoDueño.Clear();
                tBoxDniDueño.Clear();
                tBoxMail.Clear();
                tboxTelefonoDueño.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la ficha médica: " + ex.Message);
            }
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

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }
    }
}
