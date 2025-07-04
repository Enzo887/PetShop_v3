using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Alimento : Producto
    {
        private string _especie;

        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }

        private float _peso;

        public float Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }
}
