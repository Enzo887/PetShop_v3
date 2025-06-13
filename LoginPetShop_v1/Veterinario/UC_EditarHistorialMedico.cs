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
    public partial class UC_EditarHistorialMedico : UserControl
    {
        public UC_EditarHistorialMedico()
        {
            InitializeComponent();
        }

        private void btnAgregarConsulta_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;


            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarAgregarConsulta();
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
                veterinarioInicio.MostrarProgramarVacuna();
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
