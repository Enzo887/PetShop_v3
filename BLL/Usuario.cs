using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        public BE.Usuario Loguearse(string NombreUsuario, string Clave)
        {
            DAL.Usuario dalUsuario = new DAL.Usuario();
            List<BE.Usuario> usuarios = dalUsuario.Listar();

            foreach (BE.Usuario unUsuario in usuarios)
            {
                if(unUsuario.Clave== Clave.Trim() && unUsuario.NombreUsuario == NombreUsuario.Trim())
                {
                    return unUsuario;
                }
            }
            return null;
        }

    }
}
