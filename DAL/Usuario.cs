using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class Usuario
    {
        public List<BE.Usuario> Listar()
        {
            List <BE.Usuario> usuarios = new List<BE.Usuario>();
            
            Conexion conexion = new Conexion();
            

            DataTable dt = conexion.LeerPorComando("SELECT [IdUsuario],[Nombre],[Apellido],[NombreUsuario],[Clave] FROM [dbo].[Usuarios]");

            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario unUsuario = new BE.Usuario();

                unUsuario.Nombre = fila["Nombre"].ToString();
                unUsuario.Apellido = fila["Apellido"].ToString();
                unUsuario.NombreUsuario = fila["NombreUsuario"].ToString();
                unUsuario.Clave = fila["Clave"].ToString();

                usuarios.Add(unUsuario);
            }

            return usuarios;
        }
    }
}
