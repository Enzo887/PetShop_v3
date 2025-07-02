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
        public void SetearIdMascota(int idMascota)
        {
            idMascotaActual = idMascota;
        }
        public UC_ProgramarVacuna(UC_EditarHistorialMedico editarHistorialExistente)
        {
            editarHistorial = editarHistorialExistente;
            InitializeComponent();
           
        }

        private void dTPFechaAplicacion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnProgramar_Click(object sender, EventArgs e)
        {
            //agregar logica de programar vacuna en el metodo de vacuna
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
            tBoxNombreVacuna.Clear();
            dTPFechaAplicacion.Value = DateTime.Today;
            cBoxEstadoAplicacion.SelectedIndex = -1;
        }
    }
}
