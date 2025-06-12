using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Usuario 
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _nombreUsuario;

		public string NombreUsuario
		{
			get { return _nombreUsuario; }
			set { _nombreUsuario = value; }
		}

		private string _contraseña;

		public string Contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}

		public void CerrarSesion()
		{

		}

		public void IniciarSesion()
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

		}
    }
}
