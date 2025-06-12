using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Alerta
    {
        private string _descripcionAlerta;

        public string DescripcionAlerta
        {
            get { return _descripcionAlerta; }
            set { _descripcionAlerta = value; }
        }

        private DateTime _fechaProgramada;

        public DateTime FechaProgramada
        {
            get { return _fechaProgramada; }
            set { _fechaProgramada = value; }
        }

        private Rol _rolDestino;

        public Rol RolDestino
        {
            get { return _rolDestino; }
            set { _rolDestino = value; }
        }
    }
}
