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

namespace LoginPetShop_v1.Veterinario
{
    public partial class UC_EditarHistorialMedico : UserControl
    {
        private int idMascotaActual;//lo declaro global para toda la clase para poder acceder desde cualquier metodo que lo necesite
        public UC_EditarHistorialMedico()
        {
            InitializeComponent();
        }

        public int ObtenerId() 
        {
           int idFicha = idMascotaActual;
            return idFicha;
        }
        public void CargarHistorial(int idMascota)
        {
            idMascotaActual = idMascota;//le asigno el valor que recibo de id aca para poder reutilizarlo
            BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();

            //cargamos las vacunas que ya tenga programadas la mascota (si es que tiene)
            List<Vacuna> vacunas = unVeterinarioBLL.ObtenerVacunasPorMascotaID(idMascota);
            // dataGridViewVacunas.Rows.Clear();
            //recorremos la lista de vacunas que nos retorna el metodo de ObtenerVacunasPorMascotaID que tiene el Veterinario BLL y añadimos en el DataGrid cada una de estas vacunas

            foreach (var vacuna in vacunas)
            {//verificamos que si la fecha programada ya paso se cambie el estado de la vacuno a aplica y viceversa
                if (vacuna.FechaProgramada < DateTime.Today)
                {
                    vacuna.EstadoDeAplicacion = true;
                }
                else
                {
                    vacuna.EstadoDeAplicacion = false;
                }
            }
                dataGridViewVacunas.AutoGenerateColumns = false;

            // Configurar el DataPropertyName para que mapee las propiedades de Producto
            dataGridViewVacunas.Columns["Vacuna"].DataPropertyName = "NombreVacuna";
            dataGridViewVacunas.Columns["FechaAplicacion"].DataPropertyName = "FechaProgramada";
            dataGridViewVacunas.Columns["Estado"].DataPropertyName = "EstadoAplicacionTexto";


            dataGridViewVacunas.DataSource = vacunas;

         
           
            //cargamos las consultas anteriores de la mascota 

            List<Consulta> consultas = unVeterinarioBLL.ObtenerConsultasPorMascotaID(idMascota);
            dataGridViewConsultas.AutoGenerateColumns = false;

            dataGridViewConsultas.Columns["Diagnostico"].DataPropertyName = "Diagnostico";
            dataGridViewConsultas.Columns["Tratamiento"].DataPropertyName = "Tratamiento";
            dataGridViewConsultas.Columns["Fecha"].DataPropertyName = "FechaDeConsulta";

         
            dataGridViewConsultas.DataSource = consultas;
        }
        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;


            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarAgregarConsulta(idMascotaActual);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }
        public void AgregarFilaConsultas(string diagnostico, string tratamiento, string fecha)
        {
          
            dataGridViewConsultas.Rows.Add(diagnostico, tratamiento, fecha);

        }

        private void btnProgramarVacuna_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;


            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarProgramarVacuna(idMascotaActual);
                
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
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

        private void dataGridViewVacunas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
