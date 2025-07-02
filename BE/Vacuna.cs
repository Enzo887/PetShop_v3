using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vacuna : Producto
    {
		private string _nombreVacuna;

		public string NombreVacuna
		{
			get { return _nombreVacuna; }
			set { _nombreVacuna = value; }
		}

		private DateTime _fechaProgramada;

		public DateTime FechaProgramada
		{
			get { return _fechaProgramada; }
			set { _fechaProgramada = value; }
		}

		private bool _estadoDeAplicacion;

		public bool EstadoDeAplicacion
		{
			get { return _estadoDeAplicacion; }
			set { _estadoDeAplicacion = value; }
		}

		public string EstadoAplicacionTexto
		{
			get
			{
                if (EstadoDeAplicacion)
                {
                    return "Aplicada";
                }
                else
                {
                    return "Pendiente";
                }
            }
		}
	}
}
