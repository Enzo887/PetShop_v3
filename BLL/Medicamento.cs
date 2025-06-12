using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Medicamento : Producto
    {
		
		//en el diagrama de clases el es List<Medicamento>
		public override List<Producto> MostrarStock()
		{
			return null;
		}

	}
}
