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

        private Producto _producto;

        public Producto Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        private int _ventaID;

        public int Venta_ID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }

        private float _subTotal;

        public float Subtotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }

    }
}
