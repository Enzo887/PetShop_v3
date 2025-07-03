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

                var gerente = SesionActual.UsuarioLogueado as BE.Gerente;
                if (gerente == null)
                {
                    MessageBox.Show("Error obteniendo el usuario logueado");
                    return;
                }
                /*string nombreDescuento = tboxNombreDescuento.Text.Trim();
                int porcentaje = int.Parse(tboxDescuento.Text);

                //verificamos que el nombre y valor del porcentaje sean validos
                if (string.IsNullOrWhiteSpace(nombreDescuento))
                {
                    MessageBox.Show("Por favor introduzca un nombre para el descuento");
                }
                if (porcentaje <= 0 || porcentaje > 100)
                {
                    MessageBox.Show("El porcentaje debe ser un valor entre 1 y 100");
                    return;
                }

                //Guardamos el gerente que este logueado
                var gerente = SesionActual.UsuarioLogueado as BE.Gerente;
                if (gerente == null)
                {
                    MessageBox.Show("Error guardando el usuario logueado");
                    return;
                }

                //Creamos el objeto descuento que vamos a pasar como parametro
                BE.Descuento unDescuento = new BE.Descuento
                {
                    NombreDescuento = nombreDescuento,
                    PorcentajeDescuento = porcentaje,
                    UsuarioID = gerente.UsuarioID
                };
                */
                //Instanciamos descuento bll y llamamos al metodo que va a crearlo en la base de datos
                BLL.Descuento descuentoBLL = new BLL.Descuento();
                descuentoBLL.CrearDescuento(nombre, porcentaje, gerente.UsuarioID);

                MessageBox.Show("Descuento creado correctamente");

                //despues de crear limpiamos la pantalla
                tboxNombreDescuento.Clear();
                tboxDescuento.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creando el descuento: " + ex.Message);
            }
        }
    }
}
