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
    
    public partial class UC_AgregarConsulta : UserControl
    {
        UC_EditarHistorialMedico editarhistorial;
        private int idMascota;

        public void SetearIdMascota(int id)
        {
            idMascota = id;
        }
        public UC_AgregarConsulta(UC_EditarHistorialMedico editarHistorialExistente)
        {
            editarhistorial = editarHistorialExistente;
            InitializeComponent();
        }
        BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta()
            {   
                Diagnostico = tBoxDiagnostico.Text,
                Tratamiento = tBoxTratamiento.Text,
                Observaciones = tBoxDescripcion.Text,
                FechaDeConsulta = dTPFechaConsulta.Value
            };

            unVeterinarioBLL.CrearConsulta(consulta, idMascota);
            //agrega las filas al data grid
            editarhistorial.AgregarFilaConsultas(consulta.Diagnostico, consulta.Tratamiento, consulta.FechaDeConsulta.ToString());

            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarEdicionHistorial(idMascota);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            tBoxDiagnostico.Clear();
            tBoxDescripcion.Clear();
            tBoxTratamiento.Clear();
            dTPFechaConsulta.Value = DateTime.Today;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarEdicionHistorial(idMascota);
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            tBoxDiagnostico.Clear();
            tBoxDescripcion.Clear();
            tBoxTratamiento.Clear();
            dTPFechaConsulta.Value = DateTime.Today;

        }
    }
    
}
