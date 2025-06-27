using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Veterinario
    {
        private Conexion conexion = new Conexion();
        public int CrearFichMedica(BE.FichaMedica unaFicha)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                //cliente/dueño de la mascota
                new SqlParameter("@ClienteDNI", unaFicha.Mascota.Dueño.DNI),
                new SqlParameter("@NombreCliente", unaFicha.Mascota.Dueño.Nombre),
                new SqlParameter("@ApellidoCliente", unaFicha.Mascota.Dueño.Apellido),
                new SqlParameter("@EmailCliente", unaFicha.Mascota.Dueño.Email),
                new SqlParameter("@TelefonoCliente", unaFicha.Mascota.Dueño.Telefono),

                //mascota
                new SqlParameter("@NombreMascota", unaFicha.Mascota.Nombre),
                new SqlParameter("@EspecieMascota", unaFicha.Mascota.Especie),
                new SqlParameter("@SexoMascota", unaFicha.Mascota.Sexo),
                new SqlParameter("@RazaMascota", unaFicha.Mascota.Raza),
                new SqlParameter("@PesoMascota", unaFicha.Mascota.Peso),
                new SqlParameter("@FechaNacimiento", unaFicha.Mascota.FechaDeNacimiento),

                //ficha medica
                new SqlParameter("@FechaRegistroFicha", unaFicha.FechaDeRegistro)
            };
           return conexion.EscribirPorStoreProcedure("SP_CrearFichaMedica", parametros);
        }

       
    }
}
