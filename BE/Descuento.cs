﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Descuento
    {
        private int _idDescuento;

        public int IdDescuento
        {
            get { return _idDescuento; }
            set { _idDescuento = value; }
        }

        private string _nombreDescuento;

        public string NombreDescuento
        {
            get { return _nombreDescuento; }
            set { _nombreDescuento = value; }
        }

        private int _porcentajeDescuento;

        public int PorcentajeDescuento
        {
            get { return _porcentajeDescuento; }
            set { _porcentajeDescuento = value; }
        }

        private int _usuarioID;

        public int UsuarioID
        {
            get { return _usuarioID; }
            set { _usuarioID = value; }
        }

    }
}
