using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int _idProducto;

        public int IdProducto
        {
            get { return _idProducto; }
            set { _idProducto = value; }
        }

        private float _cantidad;

        public float Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private float _precioUnidad;

        public float PrecioUnidad
        {
            get { return _precioUnidad; }
            set { _precioUnidad = value; }
        }

        private DateTime _vencimiento;

        public DateTime Vencimiento
        {
            get { return _vencimiento; }
            set { _vencimiento = value; }
        }
    }
}
