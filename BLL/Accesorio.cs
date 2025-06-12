using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Accesorio : Producto
    {
		private string _material;

		public string Material
		{
			get { return _material; }
			set { _material = value; }
		}

		public override List<Producto> MostrarStock()
		{

		}


	}
}
