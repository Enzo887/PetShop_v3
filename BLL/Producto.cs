using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Producto
    {
		public virtual List<Producto> MostrarStock()
		{ 
			//hay que modificar el return
			return null;

        }

		public virtual BE.Producto BuscarProducto(string producto)
		{
			DAL.Producto unProductoDAL = new DAL.Producto();
			return unProductoDAL.BuscarProducto(producto);
		}
	}
}
