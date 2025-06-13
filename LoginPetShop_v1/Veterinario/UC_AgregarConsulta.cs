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
        public UC_AgregarConsulta(UC_EditarHistorialMedico editarHistorialExistente)
        {
            editarhistorial = editarHistorialExistente;
            InitializeComponent();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta()
            {
                Diagnostico = tBoxDiagnostico.Text,
                Observaciones=tBoxDescripcion.Text,
                Tratamiento=tBoxTratamiento.Text,
                FechaDeConsulta=dTPFechaConsulta.Value,
            };
            string diagnostico = consulta.Diagnostico;
            string tratamiento = consulta.Tratamiento;
            string fecha= consulta.FechaDeConsulta.ToString();

            //agrega las filas al data grid
            editarhistorial.AgregarFilaConsultas(diagnostico, tratamiento, fecha);

            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarEdicionHistorial();
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
                veterinarioInicio.MostrarEdicionHistorial();
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
