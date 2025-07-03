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
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreDescuento", unDescuento.NombreDescuento),
                new SqlParameter("@PorcentajeDescuento", unDescuento.PorcentajeDescuento),
                new SqlParameter("@UsuarioId", unDescuento.UsuarioID)
            };

            conexion.EscribirPorStoreProcedure("SP_CrearDescuento", parametros);
        }

        public List<BE.Descuento> ListarDescuentos()
        {
            DataTable tabla = conexion.LeerPorComando("SELECT * FROM Vista_VerDescuentos");

            List<BE.Descuento> descuentos = new List<BE.Descuento>();

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
    }
}
