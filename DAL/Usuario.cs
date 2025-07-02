using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;

namespace DAL
{
    public class Usuario
    {
        public List<BE.Usuario> Listar()
        {
            List <BE.Usuario> usuarios = new List<BE.Usuario>();
            
            Conexion conexion = new Conexion();
            

            DataTable dt = conexion.LeerPorComando("SELECT U.USUARIO_ID AS USUARIO_ID,U.DNI_USUARIO AS DNI,R.NOMBRE_ROL AS ROL,U.NOMBRE,U.APELLIDO,U.NOMBRE_USUARIO,U.CONTRASEÑA FROM dbo.USUARIO U JOIN dbo.ROL R ON U.ROL_ID = R.ROL_ID");

            foreach (DataRow fila in dt.Rows)
            {
                BE.Usuario unUsuario = new BE.Usuario();
                unUsuario.UsuarioID= Convert.ToInt32(fila["USUARIO_ID"]);
                unUsuario.Nombre = fila["NOMBRE"].ToString();
                unUsuario.Apellido = fila["APELLIDO"].ToString();
                unUsuario.NombreUsuario = fila["NOMBRE_USUARIO"].ToString();
                unUsuario.Contraseña = fila["CONTRASEÑA"].ToString();
                unUsuario.DNI = Convert.ToInt32(fila["DNI"]);
                unUsuario.Rol = fila["ROL"].ToString();

                usuarios.Add(unUsuario);
            }

            return usuarios;
        }

        public void InsertarCambios(BE.Usuario usuario)
        {
            Conexion conexion = new Conexion();
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@Usuario_ID", usuario.UsuarioID),
                new SqlParameter("@DniUsuario", usuario.DNI),
                new SqlParameter("@Nombre", usuario.Nombre),
                new SqlParameter("@Apellido", usuario.Apellido),
                new SqlParameter("@NombreUsuario", usuario.NombreUsuario),
                new SqlParameter("@Contraseña", usuario.Contraseña)
            };
            conexion.EscribirPorStoreProcedure("SP_", parametros);
        }
    }
}
