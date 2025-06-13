using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mascota
    {
		private Cliente _dueño;

		public Cliente Dueño
		{
			get { return _dueño; }
			set { _dueño = value; }
		}

		private string _especie;

		public string Especie
		{
			get { return _especie; }
			set { _especie = value; }
		}

		private DateTime _fechaDeNacimiento;

		public DateTime FechaDeNacimiento
		{
			get { return _fechaDeNacimiento; }
			set { _fechaDeNacimiento = value; }
		}

		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private float _peso;

		public float Peso
		{
			get { return _peso; }
			set { _peso = value; }
		}

		private string _raza;

		public string Raza
		{
			get { return _raza; }
			set { _raza = value; }
		}

		private string _sexo;

		public string Sexo
		{
			get { return _sexo; }
			set { _sexo = value; }
		}
		private int _id;

		public int ID
		{
			get { return _id; }
			set { _id = value; }
		}



	}
}
