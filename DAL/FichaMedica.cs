using System;
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

        public DataTable BuscarFichaMascota(string nombreMascota)
        {
            //aca es donde recibo el nombre de la mascota que se busque y lo paso como parametro para que cuando haga la consulta a la base de datos en el return me devuelva las coincidencias que encuentra el Store Procedure
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@NombreMascota", nombreMascota)
            };

            return conexion.LeerPorStoreProcedure("SP_BuscarHistorialMascota", parametros);
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
    }
}
