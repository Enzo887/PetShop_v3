using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Venta
    {
        public int RegistrarVenta(BE.Venta venta)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@Descuento_ID", venta.Descuento.IdDescuento),
                new SqlParameter("@Fecha_venta", venta.FechaDeVenta),
                new SqlParameter("@DNI_CLIENTE", venta.Cliente.DNI),
                new SqlParameter("@PrecioTotal", venta.PrecioTotal),
                new SqlParameter("@USUARIO_ID", venta.Vendedor.UsuarioID),
                new SqlParameter("@Venta_ID", SqlDbType.Int)
                {Direction = ParameterDirection.Output}
            };

            conexion.EscribirPorStoreProcedure("SP_RegistrarVenta", parametros);
            int venta_ID = Convert.ToInt32(parametros[5].Value);
            return venta_ID;
        }
    }
}
