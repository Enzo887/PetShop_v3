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
    public partial class UC_EditarProducto : UserControl
    {
        UC_GestionarStock gestionarStock;
        int IDProducto;

        public UC_EditarProducto(UC_GestionarStock gestionarStockExistente, int Producto_id)
        {
            gestionarStock = gestionarStockExistente;
            
            InitializeComponent();
            IDProducto = Producto_id;
        }
        BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
        public void CargarProducto(int idProducto)
        {
           
            //llena los campos con la info del producto ya sea vacuna o medicamento
            int categoriaID = unVeterinarioBLL.ObtenerCategoriaPorID(idProducto);

            if (categoriaID == 1)// si es medicamento
            {

                BE.Medicamento producto = unVeterinarioBLL.ObtenerMedicamentoPorID(idProducto);

                if (producto != null)
                {
                    //MessageBox.Show($"Nombre que llega: {producto.Nombre}");
                    tboxNombreProducto.Text = producto.Nombre;
                    tboxPrecioProducto.Text = producto.PrecioUnidad.ToString();
                    inputFechaVencimiento.Value = producto.Vencimiento;
                    nUDCantidadProducto.Value = (decimal)producto.Cantidad;
                    cBoxCategoria.Text = "Medicamento";
                    cBoxReceta.Text = producto.RecetaTexto.ToString();
                    cBoxEstado.Text = producto.EstadoTexto.ToString();

                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            }
            else if (categoriaID == 2)// si es vacuna carga vacuna
            {
            BE.Vacuna producto = unVeterinarioBLL.ObtenerVacunaPorID(idProducto);

                if (producto != null)
                {
                    //MessageBox.Show($"Nombre que llega: {producto.Nombre}");
                    tboxNombreProducto.Text = producto.Nombre;
                    tboxPrecioProducto.Text = producto.PrecioUnidad.ToString();
                    inputFechaVencimiento.Value = producto.Vencimiento;
                    nUDCantidadProducto.Value = (decimal)producto.Cantidad;
                    cBoxCategoria.Text = "Vacuna";
                    cBoxEstado.Text = producto.EstadoTexto;
                   

                }
                else
                {
                    MessageBox.Show("No se encontró el producto.");
                }
            }
            IDProducto = idProducto;
        }
        


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;


            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarGestionStock();
                gestionarStock.ActualizarDataGrid();
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

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
            decimal cantidad = nUDCantidadProducto.Value;
            float cantidadProducto = (float)cantidad;
            bool estado = false;
          
            //verifica que los campos tengan informacion valida
            if (inputFechaVencimiento.Value.Date <= DateTime.Today)
            {
                MessageBox.Show("No se puede guardar un producto con vencimiento vencido");
                return;
            }

            if (
                string.IsNullOrWhiteSpace(tboxNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(tboxPrecioProducto.Text) ||
                string.IsNullOrWhiteSpace(nUDCantidadProducto.Text) ||
                string.IsNullOrWhiteSpace(cBoxEstado.Text)
            )
            {
                MessageBox.Show("Por favor, completá todos los campos obligatorios.");
                return;
            }

            if (cBoxCategoria.SelectedItem == null)
            {
                MessageBox.Show("Seleccioná una categoría.");
                return;
            }

            string categoriaSeleccionada = cBoxCategoria.SelectedItem.ToString();

            try
            {
                if (categoriaSeleccionada == "Vacuna")
                {
                    if (cBoxEstado.Text == "Habilitado")
                    { estado = true; }
                    else
                    { estado = false; }

                    BE.Vacuna vacuna = new BE.Vacuna()
                    {
                        IdProducto = this.IDProducto, 
                        Nombre = tboxNombreProducto.Text,
                        PrecioUnidad = float.Parse(tboxPrecioProducto.Text),
                        Vencimiento = inputFechaVencimiento.Value,
                        Cantidad = cantidadProducto,
                        Estado = estado
                    };


                    unVeterinarioBLL.ActualizarVacuna(vacuna, IDProducto);
                    MessageBox.Show("Vacuna actualizada correctamente.");
                }
                else if (categoriaSeleccionada == "Medicamento")
                {
                    if (string.IsNullOrWhiteSpace(cBoxReceta.Text))
                    {
                        MessageBox.Show("Indicá si requiere receta.");
                        return;
                    }
                    //sete la receta en false por defecto dependiendo el texto varia si queda false o se vuelve true
                    bool receta = false;
                    if (cBoxReceta.Text == "Si")
                    { receta = true; }
                    else
                    { receta = false; }

                    if (cBoxEstado.Text == "Habilitado")
                    { estado = true; }
                    else
                    { estado = false; }

                    BE.Medicamento medicamento = new BE.Medicamento()
                    {
                        IdProducto = this.IDProducto, 
                        Nombre = tboxNombreProducto.Text,
                        PrecioUnidad = float.Parse(tboxPrecioProducto.Text),
                        Vencimiento = inputFechaVencimiento.Value,
                        Cantidad = cantidadProducto,
                        Estado = estado,
                        RequiereReceta = receta
                    };

                    unVeterinarioBLL.ActualizarMedicamento(medicamento, IDProducto);
                    MessageBox.Show("Medicamento actualizado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los cambios: " + ex.Message);
            }
            //volver al gestor de stock y actualizar el data grid

            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarGestionStock();
                gestionarStock.ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            // borra los valores de los campos
            tboxNombreProducto.Clear();
            tboxPrecioProducto.Clear();
            inputFechaVencimiento.Value = DateTime.Today;
            nUDCantidadProducto.Value = 0;
            cBoxReceta.SelectedIndex = -1;
            cBoxEstado.SelectedIndex = -1;
            cBoxCategoria.SelectedIndex = -1;


        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //verificamos que no se elimine ninguna ficha con mascota sin querer
            if (MessageBox.Show("¿Seguro que desea eliminar este producto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                try
                {
                    
                    
                    unVeterinarioBLL.EliminarProducto(IDProducto);

                    MessageBox.Show("Producto eliminado correctamente.");

                 
                    var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                    if (veterinarioInicio != null)
                    {
                        veterinarioInicio.MostrarGestionStock();
                   
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                }
            }
        }
    }
}
