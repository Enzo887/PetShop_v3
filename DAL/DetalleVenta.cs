using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DetalleVenta
    {
        public void RegistrarDetalleVenta(BE.DetalleVenta detalleVenta)
        {
            Conexion conexion = new Conexion();

            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@VENTA_ID", detalleVenta.Venta_ID),
                new SqlParameter("@PRODUCTO_ID", detalleVenta.Producto.IdProducto),
                new SqlParameter("@CANTIDAD_VENTA", detalleVenta.CantidadVenta),
                new SqlParameter("@PRECIO_UNITARIO", detalleVenta.Subtotal)
            };

            conexion.EscribirPorStoreProcedure("SP_RegistrarDetalleVenta", parametros);
        }
    }
}
