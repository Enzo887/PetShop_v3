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
            Conexion conexion = new Conexion();

            string query = $@"
            INSERT INTO USUARIO 
            (ROL_ID, DNI_USUARIO, NOMBRE, APELLIDO, NOMBRE_USUARIO, CONTRASEÑA)
            VALUES 
            ('{unUsuario.Rol}', {unUsuario.DNI}, 
            '{unUsuario.Nombre}', '{unUsuario.Apellido}', 
            '{unUsuario.NombreUsuario}', '{unUsuario.Contraseña}')
            ";

            conexion.EscribirPorComando(query);
        }
    }
}
