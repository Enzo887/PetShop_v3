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
            DAL.FichaMedica FichaMedicaDAL = new DAL.FichaMedica();
            return FichaMedicaDAL.BuscarFichaMascota(nombreMascota);
        }
    }
        	
}
