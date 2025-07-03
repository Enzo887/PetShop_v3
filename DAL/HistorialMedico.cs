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
    public class HistorialMedico
    {
        Conexion conexion = new Conexion();
        public List<BE.Vacuna> ObtenerVacunasPorMascotaID(int idMascota)
        {
            //creamos una lista de vacunas que es donde se van a guardar todas las vacunas de la mascota que este revisando que haya la base de datos
            var listaDeVacunas = new List<BE.Vacuna>();

            //le paso como parametro el id de mascota y llamamos al store procedure que me a va a traer la tabla de vacunas
            SqlParameter[] parametros = {new SqlParameter("@MascotaID", idMascota)};
            DataTable tablaDeVacunas = conexion.LeerPorStoreProcedure("SP_ObtenerVacunasPorMascotaID", parametros);

            //recorro cada fila de la tabla de vacunas y guardo cada una de ellas en la lista para despues retornar la lista final que voy a mostrar
            foreach (DataRow fila in tablaDeVacunas.Rows)
            {
                var vacuna = new Vacuna
                {
                    NombreVacuna = fila["NombreVacuna"].ToString(),
                    FechaProgramada = Convert.ToDateTime(fila["Fecha_Programada"]),
                    EstadoDeAplicacion = Convert.ToBoolean(fila["Estado"].ToString())
                };
                listaDeVacunas.Add(vacuna);
            }
            return listaDeVacunas;
        }

        public List<BE.Consulta> ObtenerConsultasPorMascotaID(int idMascota)
        {
            //creamos una lista de consultas donde vamos a guardar cada consulta de la mascota que se este revisando
            var listaDeConsultas = new List<BE.Consulta>();

            //le pasamos como parametro el id de la mascota y llamamos alñ store procedure que me va a traer la tabla de consultas
            SqlParameter[] parametros = { new SqlParameter("@MascotaID", idMascota) };
            DataTable tablaDeConsultas = conexion.LeerPorStoreProcedure("SP_ObtenerConsultasPorMascotaID", parametros);

            //recorremos cada fila de la tabla de consultas, donde cada fila va a ser una consulta que vamos a guardar en la lista de consultas para despues retornar la lista final que voy a mostrar
            foreach (DataRow fila in tablaDeConsultas.Rows)
            {
                var consulta = new Consulta
                {
                    Diagnostico = fila["DIAGNOSTICO"].ToString(),
                    Tratamiento = fila["TRATAMIENTO"].ToString(),
                    FechaDeConsulta = Convert.ToDateTime(fila["FECHA_CONSULTA"])
                };
                listaDeConsultas.Add(consulta);
            }
            return listaDeConsultas;
        }
    }
}
