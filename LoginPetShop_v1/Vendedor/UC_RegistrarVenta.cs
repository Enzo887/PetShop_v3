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
    public partial class UC_RegistrarVenta : UserControl
    {
        BE.Producto unProducto = new BE.Producto();
        BE.Cliente unCliente = new BE.Cliente();
        BE.Venta unaVenta = new BE.Venta();
        public UC_RegistrarVenta()
        {
            InitializeComponent();
        }


        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            float cantidad = (float)nudCantidad.Value;


            BLL.DetalleVenta unDetalleVentaBLL = new BLL.DetalleVenta();

            //Registrar en detalle venta
            BE.DetalleVenta unDetalleVenta = new BE.DetalleVenta();
            unDetalleVenta.Producto = unProducto;
            unDetalleVenta.CantidadVenta = cantidad;
                                        //Conecto la BLL con la BE mediante el parametro
            unDetalleVenta.Subtotal = unDetalleVentaBLL.CalcularSubtotal(unDetalleVenta);


            //Imprimo los datos en el DataGrid
            gridVenta.Rows.Add(unDetalleVenta.Producto.Nombre, unDetalleVenta.CantidadVenta, unDetalleVenta.Producto.PrecioUnidad, unDetalleVenta.Subtotal);

            //Añado a la lista de detallesVenta en La venta
            
            unaVenta.DetalleVentas.Add(unDetalleVenta);

            BLL.Venta unaVentaBLL = new BLL.Venta();
                                        //Conecto la BLL con la BE mediante el parametro
            tboxTotal.Text = unaVentaBLL.CalcularTotal(unaVenta).ToString();



            //limpio los datos de entrada
            tboxProducto.Clear();
            tboxProductoBuscado.Clear();
            nudCantidad.Value = 0;

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string producto = tboxProducto.Text;
            
            BLL.Producto unProductoBLL = new BLL.Producto();
            //Busco el producto en la BBDD
            unProducto = unProductoBLL.BuscarProducto(producto);
            //Muestro el Producto buscado.
            tboxProductoBuscado.Text = unProducto.Nombre.ToString() +" Precio:" +unProducto.PrecioUnidad.ToString();

            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string dni = tboxCliente.Text;

            BLL.Cliente unClienteBLL = new BLL.Cliente();
            //Busco el cliente en la BBDD
            unCliente = unClienteBLL.BuscarCliente(dni);
            //Muestro el Producto buscado.
            tboxClienteBuscado.Text = unCliente.Nombre.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            unaVenta.Cliente = unCliente;
        }
    }
}
