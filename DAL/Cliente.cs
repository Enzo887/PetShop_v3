using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Cliente
    {
        public BE.Cliente BuscarCliente(string texto)
        {
            Conexion conexion = new Conexion();

            // Armamos el SELECT en texto plano
            string query = $"SELECT * FROM CLIENTE WHERE DNI = '{texto}'";

            DataTable tabla = conexion.LeerPorComando(query);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];

                BE.Cliente cliente = new BE.Cliente
                {
                    DNI = Convert.ToInt32(fila["DNI"]),
                    Nombre = fila["NOMBRE"].ToString(),
                    Apellido = fila["APELLIDO"].ToString(),
                    Email = fila["EMAIL"].ToString(),
                    Telefono = Convert.ToInt32(fila["TELEFONO"])
                };

                return cliente;
            }
            else
            {
                return null;
            }
        }
    }
}
