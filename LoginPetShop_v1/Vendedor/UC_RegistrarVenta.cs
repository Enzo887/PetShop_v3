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
        List<BE.Producto> unosProductos = new List<BE.Producto>();
        List<BE.Cliente> unosClientes = new List<BE.Cliente>();
        BE.Venta unaVenta = new BE.Venta();
        BE.DetalleVenta unDetalleVenta = new BE.DetalleVenta();
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
            int indiceSeleccionado = cBoxProductoBuscado.SelectedIndex;

            if (indiceSeleccionado >= 0 && indiceSeleccionado < unosProductos.Count)
            {
                BE.Producto productoSeleccionado = unosProductos[indiceSeleccionado];
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

                //Muestro el precio total en pantalla
                tboxTotal.Text = unaVenta.PrecioTotal.ToString();

                //limpio los datos de entrada
                tboxProducto.Clear();
                cBoxProductoBuscado.Items.Clear(); //limpio la lista
                cBoxProductoBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
                cBoxProductoBuscado.Text = string.Empty; //limpio el texto seleccionado
                nudCantidad.Value = 0;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            string nombreProducto = tboxProducto.Text;
            
            BLL.Producto unProductoBLL = new BLL.Producto();
            //Busco el producto en la BBDD
            unosProductos = unProductoBLL.BuscarProducto(nombreProducto);

            if (unosProductos != null) {
                //Limpio el cBox
                cBoxProductoBuscado.Items.Clear();

                //Muestro el Producto buscado.
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
                    //tboxClienteBuscado.Text = unosClientes.Nombre.ToString();
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
            unaVenta.Cliente = unosClientes[indiceCliente];
            //registrar la venta
            BLL.Venta unaVentaBLL = new BLL.Venta();
            //MessageBox.Show(unaVenta.Cliente.DNI +" "+ unaVenta.FechaDeVenta);
            int venta_id = unaVentaBLL.RegistrarVenta(unaVenta);
            unDetalleVenta.Venta_ID = venta_id;
            MessageBox.Show(venta_id.ToString());
            MessageBox.Show("Venta registrada con exito!");

            tboxCliente.Clear();
            gridVenta.Rows.Clear();
            cBoxClienteBuscado.SelectedIndex = -1; //vuelve el seleccionado a default
            cBoxClienteBuscado.Text = string.Empty; //limpio el texto seleccionado



        }
    }
}
