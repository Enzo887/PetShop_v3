using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Venta
    {
        private string _estado;

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        private DateTime _fechaDeVenta;

        public DateTime FechaDeVenta
        {
            get { return _fechaDeVenta; }
            set { _fechaDeVenta = value; }
        }

        private string _metodoDePago;

        public string MetodoDePago
        {
            get { return _metodoDePago; }
            set { _metodoDePago = value; }
        }

        private Cliente _nombreCliente;

        public Cliente NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }

        private Vendedor _nombreVendedor;

        public Vendedor MyProperty
        {
            get { return _nombreVendedor; }
            set { _nombreVendedor = value; }
        }

        private float _precioTotal;

        public float PrecioTotal
        {
            get { return _precioTotal; }
            set { _precioTotal = value; }
        }

        private int _ventaID;

        public int VentaID
        {
            get { return _ventaID; }
            set { _ventaID = value; }
        }
    }
}
