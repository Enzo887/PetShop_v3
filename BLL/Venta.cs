using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Venta
    {
        public float CalcularTotal(BE.Venta venta)
        {
            float total = 0f;
            foreach (var detalle in venta.DetalleVentas)
            {
                total += detalle.Subtotal;
            }

            return total;
        }
    }
}
