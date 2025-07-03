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

namespace LoginPetShop_v1.Gerente
{
    public partial class UC_EditarDescuento : UserControl
    {
        private BE.Descuento descuentoActual;
        public UC_EditarDescuento()
        {
            InitializeComponent();
        }

        public void CargarDescuento(BE.Descuento descuento)
        {
            descuentoActual = descuento;

            tboxNombreDescuento.Text = descuento.NombreDescuento;
            tboxDescuento.Text = descuento.PorcentajeDescuento.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
         //Con esto reseteamos la vista al formulario principal de creacion de descuentos   
            var gerenteInicio = this.FindForm() as GerenteInicio;

            if (gerenteInicio != null)
            {
                gerenteInicio.CargarDescuentos();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void btnEditarDescuento_Click(object sender, EventArgs e)
        {
            if (descuentoActual == null)
            {
                MessageBox.Show("No hay un descuento cargado");
                return;
            }
            //Verificamos que no haya tocado eliminar sin querer y pida confirmacion
            if(MessageBox.Show("¿Seguro que desea eliminar este descuento?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    //Instanciamos un descuento de bll y llamamos el metodo de eliminar al cual le pasamos el id del descuento para buscar en la base de datos
                    BLL.Descuento unDescuentoBLL = new BLL.Descuento();
                    unDescuentoBLL.EliminarDescuento(descuentoActual.IdDescuento);

                    MessageBox.Show("Descuento eliminado correctamente");

                    //Una vez que se elimina reseteamos la vista a la vista principal de creacion de descuentos
                    var gerenteInicio = this.FindForm() as GerenteInicio;
                    if(gerenteInicio != null)
                    {
                        gerenteInicio.MostrarCrearDescuento();
                        gerenteInicio.CargarDescuentos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error eliminando el descuento: " + ex.Message);
                }
            }
        }
    }
}
