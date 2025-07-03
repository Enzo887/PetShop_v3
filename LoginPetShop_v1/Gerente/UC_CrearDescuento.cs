using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginPetShop_v1.formInicio;

namespace LoginPetShop_v1.Gerente
{
    public partial class UC_CrearDescuento : UserControl
    {
       
        public UC_CrearDescuento()
        {
            InitializeComponent();
            
        }

        private void btnCrearDescuento_Click(object sender, EventArgs e)
        {
            
            try
            {
                var nombre = tboxNombreDescuento.Text.Trim();
                int porcentaje = int.Parse(tboxDescuento.Text);

                //Guardamos en una variable gerente la sesion actual para poder agarrar el ID del usuario que crea el descuento (deberia ser siempre el gerente)
                var gerente = SesionActual.UsuarioLogueado as BE.Gerente;
                if (gerente == null)
                {
                    MessageBox.Show("Error obteniendo el usuario logueado");
                    return;
                }
                
                //Instanciamos descuento bll y llamamos al metodo que va a crearlo en la base de datos, le pasamos por parametros el nombre del descuento, el porcentaje de descuento y el id del usuario que lo crea
                BLL.Descuento descuentoBLL = new BLL.Descuento();
                descuentoBLL.CrearDescuento(nombre, porcentaje, gerente.UsuarioID);

                MessageBox.Show("Descuento creado correctamente");

                //Una vez que se crea retornamos a la vista inicial de la creacion de los descuentos
                var gerenteInicio = this.FindForm() as GerenteInicio;
                if (gerenteInicio != null)
                {
                    gerenteInicio.MostrarCrearDescuento();
                    gerenteInicio.CargarDescuentos();     
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando el descuento: " + ex.Message);
            }
        }
    }
}
