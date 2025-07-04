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
    public class Vendedor
    {
        Conexion conexion = new Conexion();
        public DataTable ObtenerProductosDeVeterinario()
        {
            return conexion.LeerPorComando("SELECT * FROM Vista_ProductosConCategoriaVendedor");
        }

        public int ObtenerCategoriaPorID(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@IdProducto", idProducto)
            };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);

            if (tabla != null && tabla.Rows.Count > 0)
            {   //devuelve solo la categoria
                return Convert.ToInt32(tabla.Rows[0]["CATEGORIA_ID"]);
            }
            else { return -1; }
        }

        public Alimento ObtenerAlimentoPorID(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", idProducto)
                };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);//llama al metodo leer por storeprocedure

            if (tabla != null && tabla.Rows.Count > 0)
            {
                var fila = tabla.Rows[0];

                string estado = fila["ESTADO"].ToString();
                bool _estado;
                //bool _receta;
                if (estado == "Habilitado")
                {
                    _estado = true;
                }
                else { _estado = false; }


                //string receta = fila["RECETA"].ToString();

                //if (receta == "SI")
                //{
                //    _receta = true;
                //}
                //else { _receta = false; }

                return new Alimento
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila["NOMBRE"].ToString(),
                    PrecioUnidad = float.Parse(fila["PRECIO"].ToString()),
                    Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                    Cantidad = float.Parse(fila["STOCK"].ToString()),
                    Estado = _estado,
                    //RequiereReceta = _receta,

                };
            }//crea un objeto Alimento y lo llena con sus datos
            return null;
        }
        
        public Accesorio ObtenerAccesorioPorID(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", idProducto)
                };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);//llama al metodo leer por storeprocedure

            if (tabla != null && tabla.Rows.Count > 0)
            {
                var fila = tabla.Rows[0];

                string estado = fila["ESTADO"].ToString();
                bool _estado;
                if (estado == "Habilitado")
                {
                    _estado = true;
                }
                else { _estado = false; }

                return new Accesorio
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila["Nombre"].ToString(),
                    PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                    Vencimiento = Convert.ToDateTime(fila["Fecha_Vencimiento"]),
                    Cantidad = float.Parse(fila["Stock"].ToString()),
                    Estado = _estado,
                };
            }//crea un objeto Accesorio y lo llena con sus datos
            return null;
        }

        public void ActualizarAccesorio(BE.Accesorio accesorio, int idProducto)
        {   // actualiza los datos en base de datos un accesorio existente
            string estado;
            if (accesorio.Estado == true)
            {
                estado = "Habilitado";
            }
            else
            {
                estado = "Deshabilitado";
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", accesorio.Nombre),
                new SqlParameter("@Precio", accesorio.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", accesorio.Vencimiento),
                new SqlParameter("@Stock", accesorio.Cantidad),
                new SqlParameter("@Estado",estado),
                new SqlParameter("@Receta", "NO")
            };
            conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parameters);
        }
        public void ActualizarAlimento(BE.Alimento alimento, int idProducto)
        {   // actualiza los datos en base de datos un Alimento existente
            string estado;
            if (alimento.Estado == true)
            {
                estado = "Habilitado";
            }
            else
            {
                estado = "Deshabilitado";
            }

            SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", alimento.Nombre),
                new SqlParameter("@Precio", alimento.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", alimento.Vencimiento),
                new SqlParameter("@Stock", alimento.Cantidad),
                new SqlParameter("@Estado",estado),
                new SqlParameter("@Receta", "NO")

                };
            conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parameters);

        }
        public void EliminarProducto(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Producto_Id", idProducto)
            };
            conexion.EscribirPorStoreProcedure("SP_EliminarProducto", parametros);

        }

    }
}
