using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Rol
    {
		private int _idRol;

		public int IdRol
		{
			get { return _idRol; }
			set { _idRol = value; }
		}

		private string _nombreRol;

		public string NombreRol
		{
			get { return _nombreRol; }
			set { _nombreRol = value; }
		}

		private List<Permiso> _permisos;

		public List<Permiso> Permisos
		{
			get { return _permisos; }
			set { _permisos = value; }
		}

	}
}
