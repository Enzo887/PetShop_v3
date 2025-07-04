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

namespace LoginPetShop_v1.Vendedor
{
    public partial class UC_GestionarStock : UserControl
    {
        private List<BE.Producto> listaOriginalProductos;
        //BLL.Veterinario unVeterinarioBLL = new BLL.Veterinario();
        BLL.Vendedor unVendedorBLL = new BLL.Vendedor();
        public UC_GestionarStock()
        {
            InitializeComponent();
            ActualizarDataGrid();

            listaOriginalProductos = unVendedorBLL.ObtenerProductos();
            dataGridViewProductos.DataSource = listaOriginalProductos;
        }

        public void ActualizarDataGrid()
        {

            List<BE.Producto> productos = unVendedorBLL.ObtenerProductos();



            dataGridViewProductos.AutoGenerateColumns = false;

            // Configurar el DataPropertyName para que mapee las propiedades de Producto
            dataGridViewProductos.Columns["IdProducto"].DataPropertyName = "IdProducto";
            dataGridViewProductos.Columns["NombreProducto"].DataPropertyName = "Nombre";
            dataGridViewProductos.Columns["Estado"].DataPropertyName = "EstadoTexto";


            dataGridViewProductos.DataSource = productos;


            dataGridViewProductoProxVencimiento.AutoGenerateColumns = false;

            dataGridViewProductoProxVencimiento.Columns["NombreProducto2"].DataPropertyName = "Nombre";

            dataGridViewProductoProxVencimiento.Columns["Vencimiento"].DataPropertyName = "Vencimiento";//no esta agregando vencimiento

            dataGridViewProductoProxVencimiento.Columns["CantidadRestante"].DataPropertyName = "Cantidad";//no esta agregando cantidad restante

            var productosProxVto = productos
            .OfType<BE.Alimento>() // Solo los productos que son alimentos
            .OrderBy(p => p.Vencimiento)
            .ToList();

            // Asignar solo los productos próximos a vencer
            dataGridViewProductoProxVencimiento.DataSource = productosProxVto;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            var VendedorHome = this.FindForm() as VendedorHome;


            if (VendedorHome != null)
            {
                VendedorHome.VolverAPantallaPrincipal();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
            ActualizarDataGrid();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            var VendedorHome = this.FindForm() as VendedorHome;

            if (VendedorHome != null)
            {
                VendedorHome.MostrarAgregarProducto();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void tBoxBuscarProducto_Enter(object sender, EventArgs e)
        {
            if (tBoxBuscarProducto.Text == "Buscar por \"ID\" o \"Nombre\"")
            {
                tBoxBuscarProducto.Text = "";
                tBoxBuscarProducto.ForeColor = Color.Black;//borra el texto por defecto y pone la fuente en negra
            }
            ActualizarDataGrid();
        }

        private void tBoxBuscarProducto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBoxBuscarProducto.Text))
            {
                tBoxBuscarProducto.Text = "Buscar por \"ID\" o \"Nombre\"";
                tBoxBuscarProducto.ForeColor = Color.Gray;//pone el texto por defecto y pone la fuente gris
            }
            ActualizarDataGrid();
        }

        private void tBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            string filtro = tBoxBuscarProducto.Text.Trim().ToLower();

            // Filtrás la lista original por ID (como string) o por nombre
            var filtrados = listaOriginalProductos
                .Where(p => p.Nombre.ToLower().Contains(filtro) || p.IdProducto.ToString().Contains(filtro))
                .ToList();

            dataGridViewProductos.DataSource = null;
            dataGridViewProductos.DataSource = filtrados;
        }
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProductos.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                return; // No hace nada, deja que el botón se maneje por CellContentClick
            }

            // Validar que se hizo clic en una fila válida (evita encabezados)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataGridViewProductos.Rows[e.RowIndex];

                // Toma el valor de la columna que quieras (por nombre o índice)
                string valor = fila.Cells["NombreProducto"].Value.ToString(); // o "IdProducto"

                tBoxBuscarProducto.Text = valor;
                tBoxBuscarProducto.ForeColor = Color.Black; // pone el texto en negro para que se note
            }
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lleva a la edicion de producto
            if (dataGridViewProductos.Columns[e.ColumnIndex].Name == "Editar")
            {
                //obtiene el id del producto que esta en la fila
                int idProducto = Convert.ToInt32(dataGridViewProductos.Rows[e.RowIndex].Cells["IdProducto"].Value);

                var VendedorHome = this.FindForm() as VendedorHome;



                if (VendedorHome != null)
                {   //pasa el id como parametro para encontrar el producto
                    VendedorHome.MostrarEditarProducto(idProducto);
                }
                else
                {
                    MessageBox.Show("No se encontro el form");
                }
            }
        }

        private void btnLimpiarBusqueda_Click_1(object sender, EventArgs e)
        {
            //borra todo lo que esta en la barra de busqueda y pone un texto por defecto
            tBoxBuscarProducto.Text = "";
            tBoxBuscarProducto.Text = "Buscar por \"ID\" o \"Nombre\"";
            tBoxBuscarProducto.ForeColor = Color.Gray;

            ActualizarDataGrid();
        }
    }
}
