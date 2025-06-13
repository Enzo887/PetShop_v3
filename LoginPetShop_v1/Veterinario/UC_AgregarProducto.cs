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
    public partial class UC_AgregarProducto : UserControl
    {
        UC_GestionarStock gestionarStock;
        public UC_AgregarProducto(UC_GestionarStock gestionarStockExistente)
        {
            InitializeComponent();
            gestionarStock = gestionarStockExistente;
            //desp cambiar para que se pueda actualiza el dataGrid :)
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal cantidad = nUDCantidadProducto.Value;
            float cantidadProducto = (float)cantidad;
           
            bool estado = cBoxEstado.Text == "Habilitado";
            string nombreProducto;
            bool Estado;

            if (inputFechaVencimiento.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("No se puede agregar un producto vencido");
                return;
            }

            if
        (
                string.IsNullOrWhiteSpace(tboxNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(tboxPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(nUDCantidadProducto.Text) ||
                string.IsNullOrWhiteSpace(cBoxEstado.Text)
           
        )
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.", "Campos Faltantes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cBoxCategoria.SelectedItem == null) { return; }

            string categoriaSeleccionada = cBoxCategoria.SelectedItem.ToString();
          

            if (cBoxCategoria.Text == "Vacuna")
            {
                //inhabilita el comboBox de receta ya que este no necesita ese campo
                cBoxReceta.Enabled = false;
                cBoxReceta.SelectedIndex = -1;
                Vacuna vacuna = new Vacuna()
                {
                    Nombre = tboxNombreProducto.Text,
                    PrecioUnidad = float.Parse(tboxPrecioProducto.Text),
                    Vencimiento = inputFechaVencimiento.Value,
                    Cantidad = cantidadProducto,
                    Estado = estado,

                };

                nombreProducto = vacuna.Nombre;
                Estado = vacuna.Estado;

                gestionarStock.AgregarFilaProductos(nombreProducto, Estado);
            }
            else if (cBoxCategoria.Text == "Medicamento")
            {
                cBoxReceta.Enabled = true;
                if (string.IsNullOrWhiteSpace(cBoxReceta.Text))
                {
                    MessageBox.Show("Por favor, seleccione si el medicamento requiere receta");
                    return;
                }
                bool receta = cBoxReceta.Text == "si";

                Medicamento medicamento = new Medicamento()
                {
                    Nombre = tboxNombreProducto.Text,
                    PrecioUnidad = float.Parse(tboxPrecioProducto.Text),
                    Vencimiento = inputFechaVencimiento.Value,
                    Cantidad = cantidadProducto,
                    RequiereReceta = receta,
                    Estado = estado,
                };
               
                nombreProducto = medicamento.Nombre;
                Estado = medicamento.Estado;

                gestionarStock.AgregarFilaProductos(nombreProducto, Estado);
            }
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
            tboxPrecioProducto.Clear ();
            inputFechaVencimiento.Value = DateTime.Today;
            nUDCantidadProducto.Value = 0;
            cBoxReceta.SelectedIndex = -1;
            cBoxEstado.SelectedIndex = -1;

                
        }
    }
}
