using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Vendedor : Usuario
    {
        public override void AgregarProducto(Producto unProducto)
        {

        }

        public override void EditarProducto(Producto unProducto)
        {

        }

        public override void EliminarProducto(Producto unProducto)
        {

        }

        public override void HabilitarProducto(Producto unProducto)
        {

        }

        public override void DeshabilitarProducto(Producto unProducto)
        {

        }
        public Descuento AplicarDescuento(Venta venta)
        {
            return null;
        }

        public List<Venta> VerReporteDeVentas()
        {
            return null;
        }

        //public List<Producto> VerStock()
        //{
        //    return null;
        //}

        public void RegistrarVenta(Venta venta)
        {

        }
    }
}
