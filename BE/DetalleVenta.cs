using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleVenta
    {
        private float _cantidadVenta;

        public float CantidadVenta
        {
            get { return _cantidadVenta; }
            set { _cantidadVenta = value; }
        }

        private Producto _precioUnidad;

        public Producto PrecioUnidad
        {
            get { return _precioUnidad; }
            set { _precioUnidad = value; }
        }

        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private Venta _ventaID;

        public Venta Venta
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }
    }
}
