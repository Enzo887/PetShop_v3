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
    public partial class UC_ProgramarVacuna : UserControl
    {
        UC_EditarHistorialMedico editarHistorial;
        private int idMascotaActual;
        

        public UC_ProgramarVacuna(UC_EditarHistorialMedico editarHistorialExistente)
        {
            editarHistorial = editarHistorialExistente;

         
            InitializeComponent();
            CargarVacunas();
            
           
        }
        BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
        private void dTPFechaAplicacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            if (cBoxEstadoAplicacion.Text == "Aplicada" && dTPFechaAplicacion.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha programada no coincide con el estado de la vacuna.\nuna vacuna aplicada no puedo tener fecha programada en un futuro.");
                return;
            }
            else if (cBoxEstadoAplicacion.Text == "Sin aplicar" && dTPFechaAplicacion.Value < DateTime.Today) 
            {
                MessageBox.Show("La fecha programada no coincide con el estado de la vacuna.\nuna vacuna sin aplicar no puedo tener fecha programada en el pasado.");
                return;
            }

                BE.Vacuna unaVacuna = new BE.Vacuna();
            var vacunaSeleccionada = (BE.Vacuna)cBoxVacuna.SelectedItem;
            unaVacuna.NombreVacuna = vacunaSeleccionada.NombreVacuna;
            unaVacuna.IdProducto = Convert.ToInt32(cBoxVacuna.SelectedValue);
            unaVacuna.FechaProgramada = dTPFechaAplicacion.Value;



            int ficha_id = editarHistorial.ObtenerId();
            unVeterinarioBLL.ProgramarVacuna(unaVacuna, ficha_id);

            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                
                veterinarioInicio.MostrarEdicionHistorial(idMascotaActual);
               
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            cBoxVacuna.SelectedIndex = -1;
            dTPFechaAplicacion.Value = DateTime.Today;
            cBoxEstadoAplicacion.SelectedIndex = -1;
            editarHistorial.CargarHistorial(idMascotaActual);
        }
        public void CargarVacunas()
        { 
           List<BE.Vacuna> vacunas = unVeterinarioBLL.ObtenerVacunas();
            cBoxVacuna.DataSource = vacunas;
            cBoxVacuna.DisplayMember = "Nombre";
            cBoxVacuna.ValueMember = "idProducto";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarEdicionHistorial(idMascotaActual);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            cBoxVacuna.SelectedIndex = -1;
            dTPFechaAplicacion.Value = DateTime.Today;
            cBoxEstadoAplicacion.SelectedIndex = -1;
        }

        private void cBoxEstadoAplicacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
