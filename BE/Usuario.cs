﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario 
    {
		private string _nombre;

		public string Nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		private string _apellido;

		public string Apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}

		private string _nombreUsuario;

		public string NombreUsuario
		{
			get { return _nombreUsuario; }
			set { _nombreUsuario = value; }
		}

		private string _contraseña;

		public string Contraseña
		{
			get { return _contraseña; }
			set { _contraseña = value; }
		}

        private string _rol;

        public string Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }

		private int _dni;

		public int DNI
		{
			get { return _dni; }
			set { _dni = value; }
		}

		private int _usuarioID;

		public int UsuarioID
		{
			get { return _usuarioID; }
			set { _usuarioID = value; }
		}

	}
}
