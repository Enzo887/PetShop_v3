using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Producto
    {

        public List<BE.Producto> BuscarProducto(string nombreProducto)
        {
            Conexion conexion = new Conexion();

            List<BE.Producto> productos = new List<BE.Producto>();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombreProducto", nombreProducto)
            };

            DataTable tabla = conexion.LeerPorStoreProcedure("SP_BuscarProductos", parametros);

            if (tabla.Rows.Count > 0)
            {

                foreach (DataRow fila in tabla.Rows)
                {
                    BE.Producto producto = new BE.Producto();

                    producto.IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]);
                    producto.Nombre = fila["NOMBRE"].ToString();
                    producto.PrecioUnidad = (float)(decimal)fila["PRECIO"];
                    productos.Add(producto);
                }
                return productos;

            }
            else
            {
                return null;
            }
        }

    }
}
