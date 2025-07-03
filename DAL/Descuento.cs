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
    public class Descuento
    {
        Conexion conexion = new Conexion();

        public void InsertarDescuento(BE.Descuento unDescuento)
        {
            //le pasamos por parametro el descuento con los datos y en el array de parametros pasamos uno por uno los datos que se van a escribir
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreDescuento", unDescuento.NombreDescuento),
                new SqlParameter("@PorcentajeDescuento", unDescuento.PorcentajeDescuento),
                new SqlParameter("@UsuarioId", unDescuento.UsuarioID)
            };
            //ejecutamos el store procedure que va a insertar en la base de datos en la tabla de descuento los datos que ponemos en la presentacion
            conexion.EscribirPorStoreProcedure("SP_CrearDescuento", parametros);
        }

        public List<BE.Descuento> ListarDescuentos()
        {
            //leemos los datos de la tabla descuentos con la vista y devolvemos una tabla con todas las coincidencias
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Vista_VerDescuentos");

            //Devolvemos una lista de descuentos de tipo descuento 
            List<BE.Descuento> descuentos = new List<BE.Descuento>();

            //recorremos esta tabla y por cada fila la convertimos en un descuento con todos sus datos, los agregamos a la lista de descuentos y retornamos esa lista una vez que se termina de recorrer
            foreach (DataRow fila in tabla.Rows)
            {
                BE.Descuento descuento = new BE.Descuento();
                descuento.IdDescuento = Convert.ToInt32(fila["DESCUENTO_ID"]);
                descuento.NombreDescuento= fila["NOMBRE_DESCUENTO"].ToString();
                descuento.PorcentajeDescuento = Convert.ToInt32(fila["PORCENTAJE_DESCUENTO"]);

                descuentos.Add(descuento);
            }

            return descuentos;
        }

        public BE.Descuento ObternerDescuentoPorID(int idDescuento)
        {
            //Pasamos por parametro el id del descuento que queremos obtener, que seria el actual
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdDescuento", idDescuento)
            };
            //Vamos a guardar en una tabla la coincidencia que nos devuelva el store procedure
            DataTable tabla = conexion.LeerPorStoreProcedure("SP_ObtenerDescuentoPorID", parametros);

            //validamos que se haya encontrado un descuento
            if (tabla.Rows.Count == 0)
            {
                return null;
            }

            //Agarramos la primera fila de los resultados
            DataRow fila = tabla.Rows[0];

            //creamos un objeto descuento y le pasamos los datos de la fila que haya devuelto el store procedure
            BE.Descuento descuento = new BE.Descuento()
            {
                IdDescuento = Convert.ToInt32(fila["DESCUENTO_ID"]),
                NombreDescuento = fila["NOMBRE_DESCUENTO"].ToString(),
                PorcentajeDescuento = Convert.ToInt32(fila["PORCENTAJE_DESCUENTO"]),
            };
            //devolvemos la coincidencia
            return descuento;
        }

        public void EliminarDescuento(int idDescuento)
        {
            //le pasamos el id del descuento que queremos eliminar como parametro
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdDescuento", idDescuento)
            };
            //llamamos al store procedure y le pasamos el id del descuento a eliminar, este ejecuta y elimina ese descuento
            conexion.EscribirPorStoreProcedure("SP_EliminarDescuento", parametros);
        }
    }
}
