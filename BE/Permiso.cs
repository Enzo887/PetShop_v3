using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Permiso
    {
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _idPermiso;

        public int IdPermiso
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }

        private string _nombrePermiso;

        public string NombrePermiso
        {
            get { return _nombrePermiso; }
            set { _nombrePermiso = value; }
        }
    }
}
