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

        public int RegistrarVenta(BE.Venta unaVenta) { 
            DAL.Venta unaVentaDAL = new DAL.Venta();
            DAL.DetalleVenta unDetalleVentaDAL = new DAL.DetalleVenta();
            int venta_ID = unaVentaDAL.RegistrarVenta(unaVenta);
            
            foreach (var detalle in unaVenta.DetalleVentas)
            {
                detalle.Venta_ID = venta_ID;
                unDetalleVentaDAL.RegistrarDetalleVenta(detalle);
            }
            
            return venta_ID;
        }
    }
}
