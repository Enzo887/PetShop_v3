﻿using System;
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

        private DateTime _fechaDeVenta = DateTime.Now;

        public DateTime FechaDeVenta
        {
            get { return _fechaDeVenta; }
            set { _fechaDeVenta = value; }
        }

        private Cliente _cliente;

        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }

        private Vendedor _nombreVendedor;

        public Vendedor NombreVendedor
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

        private List<DetalleVenta> _detalleVentas = new List<DetalleVenta>();

        public List<DetalleVenta> DetalleVentas
        {
            get { return _detalleVentas; }
            set { _detalleVentas = value; }
        }

    }
}
