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
        private FichaMedica fichaActual;

        private UC_EditarHistorialMedico editarHistorialMedico;
        public UC_EditarFichaMascota()
        {
            editarHistorialMedico = new UC_EditarHistorialMedico();
            InitializeComponent();
         
            editarHistorialMedico.Dock = DockStyle.Fill;
           
        }

        public void CargarFicha(FichaMedica unaFicha) 
        {

            //Aca una vez que le damos click al boton ver de cada mascota, nos va a cargar los datos que tenga guardados del registro, los cuales vamos a poder actualizar o editar
            BLL.Veterinario veterinarioBLL = new BLL.Veterinario();



            fichaActual = unaFicha;
            mascotaActual=unaFicha.Mascota;
            clienteActual=unaFicha.Cliente;
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
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            //Aca una vez que le damos click a ver historial de mascota nos va a mostrar la pantalla donde vamos a tener las vacunas programadas y las consultas de la mascota actual
            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarEdicionHistorial(mascotaActual.ID);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            
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
            //Funciona practicamente igual que crear ficha la logica del boton guardar cambios, con la diferencia de que me carga la ficha con los datos de la mascota actual que este revisando, cuando le doy a guardar pasa la misma ficha, porque el id no cambia pero con los datos actualizados
            BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
            string nombreMascota = tBoxNombreMascota.Text;
            string nombreDueño = tBoxNombreDueño.Text;
            string apellidoDueño = tBoxApellidoDueño.Text;
            int dniDueño = int.Parse(tBoxDniDueño.Text);
            int telefonoDueño = int.Parse(tboxTelefonoDueño.Text);
            string emailDueño = tBoxMail.Text;
            decimal pesoMascota = numericUpDownPeso.Value;
            string especieMascota = cBoxEspecie.Text;
            string razaMascota = cBoxRaza.Text;
            string sexoMascota = cBoxSexo.Text;
            

            float pesoFloat = (float)pesoMascota;

            if (dTPFechaNacimientoMascota.Value.Date > DateTime.Today)
            {
                MessageBox.Show("No se puede agendar una mascota que todavia no nacio");
            }

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

            //Creamos el cliente actualizado
            Cliente cliente = new Cliente
            {
                Nombre = nombreDueño,
                Apellido = apellidoDueño,
                DNI = dniDueño,
                Telefono = telefonoDueño,
                Email = emailDueño
            };
            //Creamos la mascota actualizada
            Mascota mascota = new Mascota
            {
                ID = mascotaActual.ID,
                Nombre = nombreMascota,
                Especie = especieMascota,
                Raza = razaMascota,
                Sexo = sexoMascota,
                Peso = pesoFloat,
                FechaDeNacimiento = dTPFechaNacimientoMascota.Value,
                Dueño = cliente
            };
            //Creamos la ficha actualizada
            FichaMedica fichaActualizada = new FichaMedica
            {
                IdFichaMedica= fichaActual.IdFichaMedica,
                Mascota = mascota,
                Cliente = cliente
            };

            //llamamos al metodo de veterinario en bll y le pasamos como parametro la ficha con los cambios
            try
            {
                unVeterinarioBLL.ActualizarFichaMedica(fichaActualizada);
                MessageBox.Show("Ficha medica actualizada correctamente");

                var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                if (veterinarioInicio != null)
                {
                    veterinarioInicio.MostrarPrincipal();
                    veterinarioInicio.MostrarFichasMascotas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error actualizando la ficha medica: " + ex.Message);
            }
        }
    }
}
