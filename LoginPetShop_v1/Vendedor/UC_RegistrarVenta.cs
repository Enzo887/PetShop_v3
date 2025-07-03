using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginPetShop_v1.Veterinario;
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.Vendedor
{
    public partial class UC_RegistrarVenta : UserControl
    {
        private List<BE.Producto> unosProductos = new List<BE.Producto>();
        private List<BE.Cliente> unosClientes = new List<BE.Cliente>();
        private List<BE.Descuento> descuentos = new List<BE.Descuento>();
        private BE.Venta unaVenta = new BE.Venta();

        public UC_RegistrarVenta()
        {
            InitializeComponent();
            cargarDescuentos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro de venta Cancelada");
            unaVenta = new BE.Venta();
            if(unosProductos == null || unosClientes == null)
            {
                unosProductos.Clear();
                unosClientes.Clear();
            }
            tboxCliente.Clear();
            gridVenta.Rows.Clear();
            cBoxClienteBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
            cBoxClienteBuscado.Text = string.Empty; //limpio el texto seleccionado
            tboxTotal.Clear();
            tboxProducto.Clear();
            cBoxProductoBuscado.Items.Clear(); //limpio la lista
            cBoxProductoBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
            cBoxProductoBuscado.Text = string.Empty; //limpio el texto seleccionado
            nudCantidad.Value = 1;
            cboxDescuento.SelectedIndex = -1;
            cboxDescuento.Text = string.Empty;
            tboxTotalConDescuento.Clear();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            float cantidad = (float)nudCantidad.Value;
            int indiceSeleccionado = cBoxProductoBuscado.SelectedIndex;
            int indiceSelecDescuento = cboxDescuento.SelectedIndex;

            BLL.DetalleVenta unDetalleVentaBLL = new BLL.DetalleVenta();

            if (cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            if (indiceSeleccionado >= 0 && indiceSeleccionado < unosProductos.Count)
            {
                BE.Producto productoSeleccionado = unosProductos[indiceSeleccionado];

                BE.DetalleVenta unDetalleVenta = new BE.DetalleVenta();
                unDetalleVenta.Producto = productoSeleccionado;
                unDetalleVenta.CantidadVenta = cantidad;
                unDetalleVenta.Subtotal = unDetalleVentaBLL.CalcularSubtotal(unDetalleVenta);


                //Imprimo los datos en el DataGrid
                gridVenta.Rows.Add(unDetalleVenta.Producto.Nombre, unDetalleVenta.CantidadVenta, unDetalleVenta.Producto.PrecioUnidad, unDetalleVenta.Subtotal);

                //Añado a la lista de detallesVenta en La venta
                unaVenta.DetalleVentas.Add(unDetalleVenta);

                BLL.Venta unaVentaBLL = new BLL.Venta();
                //Añado el precio total a la venta
                unaVenta.PrecioTotal = unaVentaBLL.CalcularTotal(unaVenta);
                
                unaVenta.Descuento = descuentos[indiceSelecDescuento];
                //Muestro el precio total en pantalla
                tboxTotal.Text = unaVenta.PrecioTotal.ToString();

                //Muestro el precio total CON DESCUENTO en pantalla
                tboxTotalConDescuento.Text = unaVentaBLL.CalcularTotalConDescuento(unaVenta).ToString();

                //limpio los datos de entrada
                tboxProducto.Clear();
                cBoxProductoBuscado.Items.Clear(); //limpio la lista
                cBoxProductoBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
                cBoxProductoBuscado.Text = string.Empty; //limpio el texto seleccionado
                nudCantidad.Value = 1;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = tboxProducto.Text;
            
            BLL.Producto unProductoBLL = new BLL.Producto();

            unosProductos = unProductoBLL.BuscarProducto(nombreProducto);

            if (unosProductos != null) {
                //Limpio el cBox
                cBoxProductoBuscado.Items.Clear();

                //Muestro el producto buscado
                foreach (var unProducto in unosProductos)
                {
                    cBoxProductoBuscado.Items.Add(unProducto.Nombre.ToString() + " Precio:" + unProducto.PrecioUnidad.ToString());
                }
                //Se selecciona el primero en la busqueda
                if (cBoxProductoBuscado.Items.Count > 0)
                {
                    cBoxProductoBuscado.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el producto");
            }
            

        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string dni = tboxCliente.Text;

            if (string.IsNullOrEmpty(dni) || !dni.All(char.IsDigit))
            {
                MessageBox.Show("Ingrese el DNI con numeros porfavor");
                return;
            }
            if (dni.Length < 7 || dni.Length > 8)
            {
                MessageBox.Show("El DNI debe tener entre 7 y 8 numeros.");
                return;
            }

            BLL.Cliente unClienteBLL = new BLL.Cliente();
            //Busco el cliente en la BBDD
            unosClientes = unClienteBLL.BuscarCliente(dni);
            if (unosClientes != null) {

                //Limpio el cBox
                cBoxClienteBuscado.Items.Clear();

                //Muestro el Producto buscado.
                foreach (var cliente in unosClientes)
                {
                    cBoxClienteBuscado.Items.Add(cliente.Nombre.ToString() + " " + cliente.Apellido.ToString() + " " + cliente.DNI.ToString());
                }

                if (cBoxClienteBuscado.Items.Count > 0)
                {
                    cBoxClienteBuscado.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("El cliente buscado no esta registrado");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            int indiceCliente = cBoxClienteBuscado.SelectedIndex;
            int indiceSeleccionado = cBoxProductoBuscado.SelectedIndex;
            var vendedor = SesionActual.UsuarioLogueado as BE.Vendedor;
            
            if (vendedor != null)
            {
                unaVenta.Vendedor = vendedor;
            }

            if (gridVenta.Rows.Count <= 1) // 1 = solo la fila nueva vacía
            {
                MessageBox.Show("Se debe agregar al menos un producto");
                return;
            }

            if (indiceCliente == -1)
            { 
                MessageBox.Show("Se debe cargar un cliente");
                return;
            }

            unaVenta.Cliente = unosClientes[indiceCliente];

            BLL.Venta unaVentaBLL = new BLL.Venta();
            int venta_id = unaVentaBLL.RegistrarVenta(unaVenta);

            MessageBox.Show("Venta registrada con exito!");

            //"Resetear"
            unaVenta = new BE.Venta();
            unosProductos.Clear();
            unosClientes.Clear();
            tboxCliente.Clear();
            gridVenta.Rows.Clear();
            cBoxClienteBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
            cBoxClienteBuscado.Text = string.Empty; //limpio el texto seleccionado
            cboxDescuento.SelectedIndex = -1;
            cboxDescuento.Text = string.Empty;
            tboxTotalConDescuento.Clear();
            tboxTotal.Clear();
            
        }
        
        private void cargarDescuentos()
        {
            BLL.Descuento descuentoBLL = new BLL.Descuento();
            
            descuentos = descuentoBLL.ListarDescuentos();

            if (descuentos != null)
            {
                //Limpio el cBox
                cboxDescuento.Items.Clear();

                //Muestro el descuento buscado
                foreach (var descuento in descuentos)
                {
                    cboxDescuento.Items.Add(descuento.NombreDescuento.ToString() + " %" + descuento.PorcentajeDescuento.ToString());
                }
                //Se selecciona el primero en la busqueda
                if (cboxDescuento.Items.Count > 0)
                {
                    cboxDescuento.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("No se encuentra el descuento");
            }
        }
    }
}
