using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Administracion
{
    public partial class UC_VerEstadisticas : UserControl
    {
        BLL.Administrador unAdminBLL = new BLL.Administrador();
        public UC_VerEstadisticas()
        {
            InitializeComponent();

            ActualizarDataGrid();
        }

        private void dGridViewProductosMasVendidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void ActualizarDataGrid() 
        {
            dGridViewProductosMasVendidos.AutoGenerateColumns = false;
            dGridViewClientesFrecuentes.AutoGenerateColumns = false;
            dGridViewVentasGenerales.AutoGenerateColumns = false;
            dGridViewStockDisponible.AutoGenerateColumns = false;


            dGridViewProductosMasVendidos.Columns["IdProducto"].DataPropertyName = "IdProducto";
            dGridViewProductosMasVendidos.Columns["Nombre"].DataPropertyName = "Nombre";
            dGridViewProductosMasVendidos.Columns["Cantidad"].DataPropertyName = "Cantidad";

            dGridViewClientesFrecuentes.Columns["DNI"].DataPropertyName = "DNI";
            dGridViewClientesFrecuentes.Columns["NombreCliente"].DataPropertyName = "Nombre";
            dGridViewClientesFrecuentes.Columns["ApellidoCliente"].DataPropertyName = "Apellido";

            dGridViewVentasGenerales.Columns["VentaID"].DataPropertyName = "VentaID";
            dGridViewVentasGenerales.Columns["Fecha"].DataPropertyName = "FechaDeVenta";
            dGridViewVentasGenerales.Columns["PrecioTotal"].DataPropertyName = "PrecioTotal";

            dGridViewStockDisponible.Columns["ProductoId"].DataPropertyName = "IdProducto";
            dGridViewStockDisponible.Columns["NombreProducto"].DataPropertyName = "Nombre";
            dGridViewStockDisponible.Columns["CantidadProducto"].DataPropertyName = "Cantidad";

            dGridViewProductosMasVendidos.DataSource = unAdminBLL.ObtenerProductosMasVendidos();
            dGridViewClientesFrecuentes.DataSource = unAdminBLL.ObtenerClientesFrecuentes();
            dGridViewVentasGenerales.DataSource = unAdminBLL.ObtenerVentasGenerales();
            dGridViewStockDisponible.DataSource = unAdminBLL.ObtenerStockActual();
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
