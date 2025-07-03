using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Descuento
    {
        Conexion conexion = new Conexion();

        public void InsertarDescuento(BE.Descuento unDescuento)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreDescuento", unDescuento.NombreDescuento),
                new SqlParameter("@PorcentajeDescuento", unDescuento.PorcentajeDescuento),
                new SqlParameter("@UsuarioId", unDescuento.UsuarioID)
            };

            conexion.EscribirPorStoreProcedure("SP_CrearDescuento", parametros);
        }
    }
}
