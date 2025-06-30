using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FichaMedica
    {
        Conexion conexion = new Conexion();

        public DataTable BuscarFichaMascota(string nombreMascota)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreMascota", nombreMascota)
            };

            return conexion.LeerPorStoreProcedure("SP_BuscarHistorialMascota", parametros);
        }
    }
}
