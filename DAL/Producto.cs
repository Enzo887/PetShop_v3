using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Producto
    {

        public BE.Producto BuscarProducto(string texto)
        {
            Conexion conexion = new Conexion();

            // Armamos el SELECT en texto plano
            string query = $"SELECT * FROM PRODUCTO WHERE NOMBRE LIKE '%{texto}%'";

            DataTable tabla = conexion.LeerPorComando(query);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                BE.Producto producto = new BE.Producto
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila["NOMBRE"].ToString(),
                    PrecioUnidad = (float)(decimal)fila["PRECIO"],
                    Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                    Cantidad = Convert.ToSingle(fila["STOCK"])
                };

                return producto;
            }
            else
            {
                return null;
            }
        }

    }
}
