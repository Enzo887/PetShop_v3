using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class FichaMedica
    {
        public FichaMedica MostrarFicha()
        {
            return null;
        }
        public DataTable BuscarFicha(string nombreMascota)
        {
            //creo una instancia de ficha medica dal para poder usar los metodos de la clase en esa capa que es la que va a hacer la consulta a la base de datos y entonces retorno la ficha bsucada con ese nombre que haya encontrado en la base de datos 
            DAL.FichaMedica FichaMedicaDAL = new DAL.FichaMedica();
            return FichaMedicaDAL.BuscarFichaMascota(nombreMascota);
        }

        public List<Mascota> ListarFichas()
        {
            //parecido al metodo de arriba instancio una ficha medica de la capa DAL para usar el metodo que me va a traer todas las fichas mediante una consulta a la base de datos
            DAL.FichaMedica fichaMedicaDAL = new DAL.FichaMedica();
            return fichaMedicaDAL.ListarFichasEnGrid();
        }
    }
        	
}
