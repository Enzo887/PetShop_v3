using LoginPetShop_v1.Veterinario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Vendedor
{
    public partial class UC_AgregarProducto : UserControl
    {
        UC_GestionarStock gestionarStock;
        public UC_AgregarProducto()
        {
            InitializeComponent();
        }

        private void cBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxCategoria.Text == "Accesorio")
            {
                inputFechaVencimiento.Enabled = false;

            }
            else if (cBoxCategoria.Text == "Alimento")
            {   //lo habilita si la categoria es Alimento
                inputFechaVencimiento.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            BLL.Vendedor unVendedorBLL = new BLL.Vendedor();
            decimal cantidad = nUDCantidad.Value;
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
                string.IsNullOrWhiteSpace(tboxNombre.Text) ||
                string.IsNullOrWhiteSpace(tboxPrecio.Text) ||
                string.IsNullOrWhiteSpace(nUDCantidad.Text) ||
                string.IsNullOrWhiteSpace(cBoxEstado.Text)

        )
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.", "Campos Faltantes!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cBoxCategoria.SelectedItem == null) { return; }

            string categoriaSeleccionada = cBoxCategoria.SelectedItem.ToString();


            if (cBoxCategoria.Text == "Accesorio")
            {

                BE.Accesorio accesorio = new BE.Accesorio()
                {
                    Nombre = tboxNombre.Text,
                    PrecioUnidad = float.Parse(tboxPrecio.Text),
                    Cantidad = cantidadProducto,
                    Estado = estado,

                };

                nombreProducto = accesorio.Nombre;
                Estado = accesorio.Estado;

                try
                {
                    unVendedorBLL.AgregarAccesorio(accesorio);
                    MessageBox.Show("Accesorio agregado correctamente");
                    gestionarStock.ActualizarDataGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la vacuna " + ex.Message);
                }

               
            }
            else if (cBoxCategoria.Text == "Alimento")
            {


                BE.Alimento alimento = new BE.Alimento()
                {
                    Nombre = tboxNombre.Text,
                    PrecioUnidad = float.Parse(tboxPrecio.Text),
                    Vencimiento = inputFechaVencimiento.Value,
                    Cantidad = cantidadProducto,
                    Estado = estado,
                };

                nombreProducto = alimento.Nombre;
                Estado = alimento.Estado;


                try
                {
                    unVendedorBLL.AgregarAlimento(alimento);
                    MessageBox.Show("Alimento agregado correctamente");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar el medicamento: " + ex.Message);
                }
            }



            //vuelve a gestion de stock y limpia el formulario
            var vendedorInicio = this.FindForm() as VendedorHome;

            if (vendedorInicio != null)
            {
                vendedorInicio.MostrarGestionStock();
          
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }

            tboxNombre.Clear();
            tboxPrecio.Clear();
            inputFechaVencimiento.Value = DateTime.Today;
            nUDCantidad.Value = 0;
            cBoxEstado.SelectedIndex = -1;
            cBoxCategoria.SelectedIndex = -1;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            var vendedorInicio = this.FindForm() as VendedorHome;

            if (vendedorInicio != null)
            {
                vendedorInicio.MostrarGestionStock();
                gestionarStock.ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }

            tboxNombre.Clear();
            tboxPrecio.Clear();
            inputFechaVencimiento.Value = DateTime.Today;
            nUDCantidad.Value = 0;
            cBoxEstado.SelectedIndex = -1;
            cBoxCategoria.SelectedIndex = -1;

        }
    }
    }
