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
    public partial class UC_EditarProducto : UserControl
    {
        UC_GestionarStock gestionarStock;
        public UC_EditarProducto(UC_GestionarStock gestionarStockExistente)
        {
            gestionarStock = gestionarStockExistente;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;


            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarGestionStock();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }

            tboxNombreProducto.Clear();
            tboxPrecioProducto.Clear();
            inputFechaVencimiento.Value = DateTime.Today;
            nUDCantidadProducto.Value = 0;
            cBoxReceta.SelectedIndex = -1;
            cBoxEstado.SelectedIndex = -1;
            cBoxCategoria.SelectedIndex = -1;
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCategoria.Text == "Vacuna")
            {
                //inhabilita el comboBox de receta ya que este no necesita ese campo
                cBoxReceta.Enabled = false;
                cBoxReceta.SelectedIndex = -1;
            }
            else if (cBoxCategoria.Text == "Medicamento")
            {   //lo habilita si la categoria es medicamento
                cBoxReceta.Enabled = true;
            }
        }
    }
}
