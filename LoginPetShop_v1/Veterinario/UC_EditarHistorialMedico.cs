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

        public void CargarHistorial(int idMascota)
        {
            idMascotaActual = idMascota;//le asigno el valor que recibo de id aca para poder reutilizarlo
            BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();

            //cargamos las vacunas que ya tenga programadas la mascota (si es que tiene)
            List<Vacuna> vacunas = unVeterinarioBLL.ObtenerVacunasPorMascotaID(idMascota);
            dataGridViewVacunas.Rows.Clear();
            //recorremos la lista de vacunas que nos retorna el metodo de ObtenerVacunasPorMascotaID que tiene el Veterinario BLL y añadimos en el DataGrid cada una de estas vacunas
            foreach (var vacuna in vacunas)
            {
                dataGridViewVacunas.Rows.Add(vacuna.NombreVacuna, vacuna.FechaProgramada.ToShortDateString(), vacuna.EstadoAplicacionTexto);
            }
            //cargamos las consultas anteriores de la mascota 
            List<Consulta> consultas = unVeterinarioBLL.ObtenerConsultasPorMascotaID(idMascota);
            dataGridViewConsultas.Rows.Clear();
            //recorremos la lista de consultas que nos retorna el metodo de ObtenerConsultasPorMascotaID que tiene el Veterinario BLL y añadimos en el DataGrid cada una de estas consultas
            foreach (var consulta in consultas)
            {
                dataGridViewConsultas.Rows.Add(consulta.Diagnostico, consulta.Tratamiento, consulta.FechaDeConsulta.ToShortDateString());
            }
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
    }
}
