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
    public partial class VeterinarioInicio : Form
    {
        
        public VeterinarioInicio()
        {
            InitializeComponent();

        }
        private void CargarUserControl(UserControl control)
        {
            panelContenedorVeterinario.Controls.Clear();           // Limpia el contenido actual
            control.Dock = DockStyle.Fill;             // Ocupa todo el panel
            panelContenedorVeterinario.Controls.Add(control);      // Agrega el nuevo
        }
        private void VeterinarioInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void lblVeterinario_Click(object sender, EventArgs e)
        {

        }


        private void BtnCrearFicha_Click(object sender, EventArgs e)
        {
            CargarUserControl(new CrearFichaMascota());

           



        }

        private void lblBuscador_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lBoxMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            CargarUserControl(new VeterinarioStock());
        }

        private void panelContenedorVeterinario_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
