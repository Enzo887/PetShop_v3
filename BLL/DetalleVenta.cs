using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleVenta
    {
        public float CalcularSubtotal(BE.DetalleVenta detalleVenta) {
            float subtotal = 0f;
            subtotal = detalleVenta.Producto.PrecioUnidad * detalleVenta.CantidadVenta;
            return subtotal;
        }
    }
}
