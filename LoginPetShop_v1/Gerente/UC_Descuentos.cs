using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1.Gerente
{
    
    public partial class UC_Descuentos : UserControl
    {
        BLL.Gerente unGerenteBLL = new BLL.Gerente();
        public UC_Descuentos()
        {
            InitializeComponent();

        }

        public void CargarDescuentos()
        {
            List<BE.Descuento> descuentos = unGerenteBLL.VerDescuentos();

            gridListaDescuentos.AutoGenerateColumns = false;

            gridListaDescuentos.Columns["cIdDescuento"].DataPropertyName = "IdDescuento";
            gridListaDescuentos.Columns["NombreDescuento"].DataPropertyName = "NombreDescuento";
            gridListaDescuentos.Columns["Porcentaje"].DataPropertyName = "PorcentajeDescuento";

            gridListaDescuentos.DataSource = descuentos;

        }
        private void btnAgregarDescuento_Click(object sender, EventArgs e)
        {
            var gerenteInicio = this.FindForm() as GerenteInicio;
            if (gerenteInicio != null)
            {
                gerenteInicio.MostrarCrearDescuento();
            }
        }

        private void gridListaDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex == gridListaDescuentos.Columns["Ver"].Index)
            {
                int idDescuento = Convert.ToInt32(gridListaDescuentos.Rows[e.RowIndex].Cells["cIdDescuento"].Value);


                BLL.Descuento unDescuentoBLL = new BLL.Descuento();
                BE.Descuento descuento = unDescuentoBLL.ObtenerDescuentoPorID(idDescuento);

                var gerenteInicio = this.FindForm() as GerenteInicio;
                if (gerenteInicio != null)
                {
                    gerenteInicio.MostrarEditarDescuento(descuento);
                }
                else
                {
                    MessageBox.Show("No se encontro el form");
                }
            }
        }
    }
}
