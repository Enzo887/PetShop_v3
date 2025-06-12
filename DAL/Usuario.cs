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
            

            DataTable dt = conexion.LeerPorComando("SELECT R.NOMBRE_ROL AS ROL,U.NOMBRE,U.APELLIDO,U.NOMBRE_USUARIO,U.CONTRASEÑA FROM dbo.USUARIO U JOIN dbo.ROL R ON U.ROL_ID = R.ROL_ID");

            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario unUsuario = new BE.Administrador();

                unUsuario.Nombre = fila["NOMBRE"].ToString();
                unUsuario.Apellido = fila["APELLIDO"].ToString();
                unUsuario.NombreUsuario = fila["NOMBRE_USUARIO"].ToString();
                unUsuario.Contraseña = fila["CONTRASEÑA"].ToString();
                unUsuario.Rol = fila["ROL"].ToString();

                usuarios.Add(unUsuario);
            }

            return usuarios;
        }
    }
}
