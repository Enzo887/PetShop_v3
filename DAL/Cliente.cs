using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public List<BE.Cliente> BuscarCliente(string DNI)
        {
            Conexion conexion = new Conexion();
            List<BE.Cliente> clientes = new List<BE.Cliente>();

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@DNI", DNI)
            };

            DataTable tabla = conexion.LeerPorStoreProcedure("SP_BuscarCliente", parametros);

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    BE.Cliente cliente = new BE.Cliente
                    {
                        DNI = Convert.ToInt32(fila["DNI"]),
                        Nombre = fila["NOMBRE"].ToString(),
                        Apellido = fila["APELLIDO"].ToString(),
                        //Email = fila["EMAIL"].ToString(),
                        //Telefono = Convert.ToInt32(fila["TELEFONO"])
                        
                    };
                    clientes.Add(cliente);
                }
                

                return clientes;
            }
            else
            {
                return null;
            }
        }
    }
}
