﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class FichaMedica
    {
        Conexion conexion = new Conexion();

        public List<Mascota> BuscarFichaMascota(string nombreMascota)
        {
            //Creamos una lista de mascotas vacia donde se va a guardar las coincidencias de la busqueda
            List<Mascota> listaMascotas = new List<Mascota>();
             //aca es donde recibo el nombre de la mascota que se busque y lo paso como parametro para que cuando haga la consulta a la base de datos en el return me devuelva las coincidencias que encuentra el Store Procedure
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreMascota", nombreMascota)
            };

            DataTable mascotasBuscadas = conexion.LeerPorStoreProcedure("SP_BuscarHistorialMascota", parametros);
            //recorremos cada fila de las coincidencias y las convertimos en mascota para añadir cada una a la lista de mascotas
            foreach (DataRow fila in mascotasBuscadas.Rows)
            {
                Mascota mascota = new Mascota
                {
                    ID = Convert.ToInt32(fila["MASCOTA_ID"]),
                    Nombre = fila["NombreMascota"].ToString()
                };
                listaMascotas.Add(mascota);
            }
            //Una vez termina de ejecutar retornamos esta lista
            return listaMascotas;
        }

        public List<Mascota> ListarFichasEnGrid()
        {
            //primero creamos una lista vacia de Mascota que es donde se va a guardar cada ficha de mascota que viene de la base de datos
            List<Mascota> listaMascotas = new List<Mascota>();

            //ejecutamos el Store Procedure que me va a retornar un DataTable deonde cada fila de este DataTable va a ser una Mascota 
            DataTable tabla = conexion.LeerPorStoreProcedure("SP_ListarFichas");

            //recorremos cada fila de la tabla y se crea una instancia de mascota por cada una donde se le asignan el ID y el Nombre que tienen en la base de datos, para despues agregarse en la lista vacia del principio y una vez que se termina de recorrer retornamos esa lista
            foreach (DataRow fila in tabla.Rows)
            {
                Mascota mascota = new Mascota()
                {
                    ID = Convert.ToInt32(fila["MASCOTA_ID"]),
                    Nombre = fila["NOMBRE_MASCOTA"].ToString()
                };
                listaMascotas.Add(mascota);
            }
            return listaMascotas;
        }

        public BE.FichaMedica ObtenerFichaPorMascotaID(int idMascota)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@MascotaID", idMascota)
            };
            DataTable tabla = conexion.LeerPorStoreProcedure("SP_ObtenerFichaPorIdMascota", parametros);

            if (tabla.Rows.Count == 0)
            {
                return null;
            }

            DataRow fila = tabla.Rows[0];

            BE.Cliente cliente = new BE.Cliente
            {
                DNI = Convert.ToInt32(fila["DNI_CLIENTE"]),
                Nombre = fila["NOMBRE_CLIENTE"].ToString(),
                Apellido = fila["APELLIDO_CLIENTE"].ToString(),
                Email = fila["EMAIL_CLIENTE"].ToString(),
                Telefono = Convert.ToInt32(fila["TELEFONO_CLIENTE"])
            };

            BE.Mascota mascota = new BE.Mascota
            {
                ID = Convert.ToInt32(fila["MASCOTA_ID"]),
                Nombre = fila["NOMBRE_MASCOTA"].ToString(),
                Especie = fila["ESPECIE"].ToString(),
                Raza = fila["RAZA"].ToString(),
                Sexo = fila["SEXO"].ToString(),
                Peso = float.Parse(fila["PESO"].ToString()),
                FechaDeNacimiento = Convert.ToDateTime(fila["FECHA_NACIMIENTO"])
            };

            return new BE.FichaMedica
            {
                Mascota = mascota,
                Cliente = cliente
            };
        }
    }
}
