using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Consulta
    {
		private string _diagnostico;

		public string Diagnostico
		{
			get { return _diagnostico; }
			set { _diagnostico = value; }
		}

		private DateTime _fechaDeConsulta;

		public DateTime FechaDeConsulta
		{
			get { return _fechaDeConsulta; }
			set { _fechaDeConsulta = value; }
		}

		private int _idConsulta;

		public int IdConsulta
		{
			get { return _idConsulta; }
			set { _idConsulta = value; }
		}

		private string _observaciones;

		public string Observaciones
		{
			get { return _observaciones; }
			set { _observaciones = value; }
		}

		private string _tratamiento;

		public string Tratamiento
		{
			get { return _tratamiento; }
			set { _tratamiento = value; }
		}

	}
}
