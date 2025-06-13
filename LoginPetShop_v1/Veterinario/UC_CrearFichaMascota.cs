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
        //proximamente borrar
        private int contadorId = 0;
        public int GenerarNuevoId()
        {
            return contadorId++;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string nombreMascota = tBoxNombreMascota.Text;
            GenerarNuevoId();
            //numericUpDown solo puede dar numero de tipo int o decimal
            decimal valor= numericUpDownPeso.Value;
            //convierto el valor decimal en float
            float pesoFloat = (float) valor;
            //valida que la mascota ya haya nacido
            if (dTPFechaNacimientoMascota.Value.Date > DateTime.Today ) 
            {
                MessageBox.Show("No se puede agendar una mascota que todavia no nacio");
            }
            //valida que los campos no esten vacios
            if
          (
                  string.IsNullOrWhiteSpace(tBoxNombreMascota.Text) ||
                  string.IsNullOrWhiteSpace(cBoxEspecie.Text) ||
                  string.IsNullOrWhiteSpace(cBoxRaza.Text) ||
                  string.IsNullOrWhiteSpace(cBoxSexo.Text) ||
                  pesoFloat <= 0 || 
                  string.IsNullOrWhiteSpace(tBoxNombreDueño.Text) ||
                  string.IsNullOrWhiteSpace(tBoxApellidoDueño.Text) ||
                  string.IsNullOrWhiteSpace(tBoxDniDueño.Text) ||
                  string.IsNullOrWhiteSpace(tboxTelefonoDueño.Text) ||
                  string.IsNullOrWhiteSpace(tBoxMail.Text)
          )
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.", "Campos Faltantes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Mascota mascota = new Mascota()
            {   
                ID = contadorId,
                Nombre = tBoxNombreMascota.Text,
                Especie = cBoxEspecie.Text,
                Raza = cBoxRaza.Text,
                Sexo = cBoxSexo.Text,
                Peso = pesoFloat,
                FechaDeNacimiento = dTPFechaNacimientoMascota.Value
            };


            Cliente cliente = new Cliente() 
            {
                Nombre = tBoxNombreDueño.Text,
                Apellido = tBoxApellidoDueño.Text,
                DNI = int.Parse(tBoxDniDueño.Text),
                Telefono = int.Parse(tboxTelefonoDueño.Text),
                Email = tBoxMail.Text
            };

          
            //arreglar asignacion de id(todos los id son 1)
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                    
                    veterinarioInicio.AgregarFila(contadorId, nombreMascota);
                    veterinarioInicio.MostrarPrincipal();

                        //setea todo en dafult
                        tBoxNombreMascota.Clear();
                        cBoxEspecie.SelectedIndex = -1;
                        cBoxRaza.SelectedIndex = -1;
                        cBoxSexo.SelectedIndex = -1;
                        numericUpDownPeso.Value = 0;
                        dTPFechaNacimientoMascota.Value = DateTime.Today;

                        tBoxNombreDueño.Clear();
                        tBoxApellidoDueño.Clear();
                        tBoxDniDueño.Clear(); ;
                        tBoxMail.Clear();
                        tboxTelefonoDueño.Clear();


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
