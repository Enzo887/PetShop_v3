﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class TarjetaDePuntos
    {
        private int _cantidadPuntos;

        public int CantidadPuntos
        {
            get { return _cantidadPuntos; }
            set { _cantidadPuntos = value; }
        }

        private int _idTarjeta;

        public int IdTarjeta
        {
            get { return _idTarjeta; }
            set { _idTarjeta = value; }
        }

        //en el diagrama tiene un dni cliente, debemos agregarlo?
    }
}
