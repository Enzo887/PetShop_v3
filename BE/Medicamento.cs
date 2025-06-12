using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Medicamento : Producto
    {
        private float _dosis;

        public float Dosis
        {
            get { return _dosis; }
            set { _dosis = value; }
        }

        private bool _requiereReceta;

        public bool RequiereReceta
        {
            get { return _requiereReceta; }
            set { _requiereReceta = value; }
        }
    }
}
