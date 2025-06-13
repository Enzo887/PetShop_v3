using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Administrador : Usuario
    {
        public void AgregarAlertaARol(Rol unRol, Alerta unaAlerta)
        {

        }

        public void AgregarRolAUsuario(Rol unRol, Usuario unUsuario)
        {

        }

        public void CrearAlerta()
        {

        }

        public void CrearRol()
        {

        }

        public void EditarPermisosDeRol(Rol unRol)
        {

        }

        public void EliminarAlerta(Rol unRol)
        {

        }

        public void EliminarRol(Rol unRol)
        {

        }

        public void EliminarRolAUsuario(Rol unRol, Usuario unUsuario)
        {

        }
        public void VerEstadisticas()
        {

        }

        public List<Usuario> VerListaDeUsuarios()
        {
            return null;
        }

        
        public Administrador()
        {
            
        }
        public void RegistrarUsuario(BE.Usuario unUsuario)
        {
            //instancio un objeto admin de la clase DAL que es quien va a registrar al usuario 
            DAL.Administrador unAdminDal = new DAL.Administrador();
            unAdminDal.RegistrarUsuario(unUsuario);
        }
    }
}
