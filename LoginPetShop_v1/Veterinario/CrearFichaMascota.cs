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
    public partial class CrearFichaMascota : UserControl
    {
        public Action<UserControl> CambiarControl;
        public CrearFichaMascota()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            VeterinarioInicio main = new VeterinarioInicio();
            main.Show();
             Form esteform = this.FindForm();
            esteform.Close();
           

        }

        private void btnVerHistorialMedico_Click(object sender, EventArgs e)
        {
          
            
        }
    }
}
