using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Administrador
    {
        private Conexion conexion = new Conexion();
        public int RegistrarUsuario(BE.Usuario unUsuario)
        {
       
            // escribe en base de datos un nuevo Usuario

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Rol", unUsuario.Rol),
                new SqlParameter("@DniUsuario", unUsuario.DNI),
                new SqlParameter("@Nombre", unUsuario.Nombre),
                new SqlParameter("@Apellido", unUsuario.Apellido),
                new SqlParameter("@NombreUsuario", unUsuario.NombreUsuario),
                new SqlParameter("@Contraseña", unUsuario.Contraseña),
                new SqlParameter("@Usuario_ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }
            };
            conexion.EscribirPorStoreProcedure("SP_RegistrarUsuario", parameters);
            unUsuario.UsuarioID = Convert.ToInt32(parameters[6].Value);

            return unUsuario.UsuarioID;
        }

        public void EditarUsuario(BE.Usuario unUsuario)
        {   // actualiza los datos en base de datos un usuario existente
            int IdRol = 0;
            string rolNormalizado = unUsuario.Rol.ToLower();
            if (rolNormalizado == "veterinario") { IdRol = 4; }
            else if (rolNormalizado == "vendedor") { IdRol = 3; }
            else if (rolNormalizado == "gerente") { IdRol = 2; }
            else if (rolNormalizado == "administrador") { IdRol = 1; }

            SqlParameter[] parameters = new SqlParameter[]
                        {
                            new SqlParameter("@Usuario_ID", unUsuario.UsuarioID),
                            new SqlParameter("@Rol", IdRol),
                            new SqlParameter("@DniUsuario", unUsuario.DNI),
                            new SqlParameter("@Nombre", unUsuario.Nombre),
                            new SqlParameter("@Apellido", unUsuario.Apellido),
                            new SqlParameter("@NombreUsuario", unUsuario.NombreUsuario),
                            new SqlParameter("@Contraseña", unUsuario.Contraseña)

                        };
            conexion.EscribirPorStoreProcedure("SP_EditarUsuario", parameters);

        }

        public void EliminarUsuario(int idUsuario) 
        {
            // escribe en base de datos un nuevo Usuario

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Usuario_ID", idUsuario),
        
            };
            conexion.EscribirPorStoreProcedure("SP_EliminarUsuario", parameters);
        }

        public DataTable ObtenerUsuarios() 
        {
            return   conexion.LeerPorComando("SELECT * FROM Vista_ObtenerUsuarios");
        }

        public BE.Usuario ObtenerUsuarioPorID(int idUsuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
             new SqlParameter("@UsuarioID", idUsuario)
            };

            DataTable tabla = conexion.LeerPorStoreProcedure("SP_ObtenerUsuarioPorID", parametros);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                return new BE.Usuario
                {
                    UsuarioID = Convert.ToInt32(fila["USUARIO_ID"]),
                    Rol = fila[("NOMBRE_ROL")].ToString(),
                    NombreUsuario = fila[("NOMBRE_USUARIO")].ToString(),
                    Nombre = fila[("NOMBRE")].ToString(),
                    Apellido = fila[("APELLIDO")].ToString(),
                    Contraseña = fila[("CONTRASEÑA")].ToString(),
                    DNI = Convert.ToInt32(fila["DNI_USUARIO"]),

                };
            }
            else 
            {
                return null;
            }
          
        }


    }
}
