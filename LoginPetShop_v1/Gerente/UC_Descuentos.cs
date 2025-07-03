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
        public UC_Descuentos()
        {
            InitializeComponent();
        }

        private void btnAgregarDescuento_Click(object sender, EventArgs e)
        {
            var gerenteInicio = this.FindForm() as GerenteInicio;
            if (gerenteInicio != null)
            {
                gerenteInicio.MostrarCrearDescuento();
            }
        }
    }
}
