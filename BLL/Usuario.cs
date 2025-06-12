using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class Usuario
    {
        public BE.Usuario Loguearse(string NombreUsuario, string Clave)
        {
            DAL.Usuario dalUsuario = new DAL.Usuario();
            List<BE.Usuario> usuarios = dalUsuario.Listar();

            foreach (BE.Usuario unUsuario in usuarios)
            {
                if(unUsuario.Contraseña== Clave.Trim() && unUsuario.NombreUsuario == NombreUsuario.Trim())
                {
                    return unUsuario;
                }
            }
            return null;
        }
        public void CerrarSesion()
        {

        }

        public void EditarPerfil()
        {

        }
        public virtual void EditarProducto(Producto unProducto)
        {

        }

        public virtual void AgregarProducto(Producto unProducto)
        {

        }

        public virtual void EliminarProducto(Producto unProducto)
        {

        }

        public virtual void HabilitarProducto(Producto unProducto)
        {

        }

        public virtual void DeshabilitarProducto(Producto unProducto)
        {

        }

        public List<Producto> VerStock()
        {
            return null;
        }

    }
}
