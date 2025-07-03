using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Gerente : Usuario
    {

        public List<BE.Descuento> VerDescuentos()
        {
            DAL.Descuento unDescuento = new DAL.Descuento();
            return unDescuento.ListarDescuentos();
        }

        public void CrearDescuento()
        {

        }
    }
}
