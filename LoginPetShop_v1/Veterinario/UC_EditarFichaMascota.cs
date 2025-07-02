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
            try
            {
                // Agarramos todos los datos que vienen del form
                string nombreMascota = tBoxNombreMascota.Text;
                string especieMascota = cBoxEspecie.Text;
                string razaMascota = cBoxRaza.Text;
                string sexoMascota = cBoxSexo.Text;
                float pesoFloat = (float)numericUpDownPeso.Value;
                DateTime fechaNacimiento = dTPFechaNacimientoMascota.Value;

                string nombreDueño = tBoxNombreDueño.Text;
                string apellidoDueño = tBoxApellidoDueño.Text;
                int dni = int.Parse(tBoxDniDueño.Text);
                int telefono = int.Parse(tboxTelefonoDueño.Text);
                string email = tBoxMail.Text;

                // Creamos cliente con datos del dueño de la mascota
                Cliente cliente = new Cliente
                {
                    Nombre = nombreDueño,
                    Apellido = apellidoDueño,
                    DNI = dni,
                    Telefono = telefono,
                    Email = email
                };
                // Creamos mascota usando el id actual para identificar que es una mascota que ya existe
                Mascota mascota = new Mascota
                {
                    ID = mascotaActual.ID,
                    Nombre = nombreMascota,
                    Especie = especieMascota,
                    Raza = razaMascota,
                    Sexo = sexoMascota,
                    Peso = pesoFloat,
                    FechaDeNacimiento = fechaNacimiento,
                    Dueño = cliente
                };
                //Creamos la ficha que tiene la mascota y el dueño con el id actual (el que entramos a editar) para poder devolver el mismo
                FichaMedica ficha = new FichaMedica
                {
                    IdFichaMedica = fichaActual.IdFichaMedica,
                    Mascota = mascota,
                    Cliente = cliente
                };

                // Creamos una instancia de veterinario BLL para llamar al metodo que trabaja la logica de actualizacion
                BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
                unVeterinarioBLL.GuardarCambiosFicha(ficha);

                MessageBox.Show("Ficha médica actualizada correctamente");

                //Una vez que se crea volvemos a la vista principal con todo actualizado donde nos muestra la mascota actualizada si le damos a "Ver"
                var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                if (veterinarioInicio != null)
                {
                    veterinarioInicio.MostrarPrincipal();
                    veterinarioInicio.MostrarFichasMascotas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la ficha médica: " + ex.Message);
            }
        }

        private void btnEliminarMascota_Click(object sender, EventArgs e)
        {
            //verificamos que no se elimine ninguna ficha con mascota sin querer
            if (MessageBox.Show("¿Seguro que desea eliminar esta ficha?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                try
                {
                    //instanciamos un veteriario de bll y llamamos a su metodo de eliminar mascota al cual le pasamos el id de la mascota que estamos "editando"
                    BLL.Veterinario veterinarioBLL = new BLL.Veterinario();
                    veterinarioBLL.EliminarMascota(mascotaActual.ID); 

                    MessageBox.Show("Mascota eliminada correctamente.");

                    // Actualizamos la vista despues de eliminar para mostrar el inicio
                    var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                    if (veterinarioInicio != null)
                    {
                        veterinarioInicio.MostrarFichasMascotas();
                        veterinarioInicio.MostrarPrincipal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la mascota: " + ex.Message);
                }
            }
        }
    }
    
}
