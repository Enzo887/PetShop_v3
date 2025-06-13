using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Administrador
    {
        public void RegistrarUsuario(BE.Usuario unUsuario)
        {
            //instancio una conexion, que se va a conectar a la base de datos y le paso la query para que inserte el nuevo usuario en ella
            Conexion conexion = new Conexion();

            string query = $@"
            INSERT INTO USUARIO 
            (ROL_ID, DNI_USUARIO, NOMBRE, APELLIDO, NOMBRE_USUARIO, CONTRASEÑA)
            VALUES 
            ('{unUsuario.Rol}', {unUsuario.DNI}, 
            '{unUsuario.Nombre}', '{unUsuario.Apellido}', 
            '{unUsuario.NombreUsuario}', '{unUsuario.Contraseña}')
            ";
            //llamo al metodo escribir por comando de la clase conexion y le paso como parametro la consulta
            conexion.EscribirPorComando(query);
        }
    }
}
