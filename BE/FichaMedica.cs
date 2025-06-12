using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FichaMedica
    {
            private Cliente _cliente;

            public Cliente Cliente
            {
                get { return _cliente; }
                set { _cliente = value; }
            }

            private DateTime _fechaDeRegistro;

            public DateTime FechaDeRegistro
            {
                get { return _fechaDeRegistro; }
                set { _fechaDeRegistro = value; }
            }

            private int _idFichaMedica;

            public int IdFichaMedica
            {
                get { return _idFichaMedica; }
                set { _idFichaMedica = value; }
            }

            private Mascota _mascota;

            public Mascota Mascota
            {
                get { return _mascota; }
                set { _mascota = value; }
            }
    }
}
