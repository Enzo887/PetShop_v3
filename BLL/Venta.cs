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

        //quizas seria bueno que sea bool asi me dice si se registro a no la venta?
        public int RegistrarVenta(BE.Venta venta) { 
            DAL.Venta unaVenta = new DAL.Venta();
            int venta_ID = unaVenta.RegistrarVenta(venta);
            return venta_ID;
        }
    }
}
