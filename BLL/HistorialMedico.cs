using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class HistorialMedico
    {
		private List<Consulta> _consulta;

		public List<Consulta> Consulta
		{
			get { return _consulta; }
			set { _consulta = value; }
		}

		private FichaMedica _ficha;

		public FichaMedica Ficha
		{
			get { return _ficha; }
			set { _ficha = value; }
		}

		private int _idHistorial;

		public int IdHistorial
		{
			get { return _idHistorial; }
			set { _idHistorial = value; }
		}

		private Vacuna _vacuna;

		public Vacuna Vacuna
		{
			get { return _vacuna; }
			set { _vacuna = value; }
		}

		private Veterinario _veterinario;

		public Veterinario Veterinario
		{
			get { return _veterinario; }
			set { _veterinario = value; }
		}

		public void AgregarConsulta()
		{

		}

		public HistorialMedico MostrarHistorialMedico()
		{

		}
	}
}
