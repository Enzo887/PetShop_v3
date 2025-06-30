using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Veterinario : Usuario
    {
        public override void AgregarProducto(Producto unProducto)
        {

        }

        public override void EliminarProducto(Producto unProducto)
        {

        }

        public override void EditarProducto(Producto unProducto)
        {

        }

        public override void HabilitarProducto(Producto unProducto)
        {

        }

        public override void DeshabilitarProducto(Producto unProducto)
        {

        }

        public void BuscarMedicamento(Medicamento unMedicamento)
        {

        }

        public void CrearConsulta()
        {

        }

        public void CrearFichaMascota(BE.FichaMedica unaFicha)
        {
            //instanciamos un veterinario de la clase dal que es donde se va a comunicar con la base de datos, ahi llamamos al metodo CrearFichaMedica de veterinario en la capa dal y le pasasmos como parametro la ficha que creamos para poder insertarla con una consulta a la base de datos
            DAL.Veterinario unVeterinarioDAL = new DAL.Veterinario();
            unVeterinarioDAL.CrearFichMedica(unaFicha);
        }

        public void EditarFichaMascota(FichaMedica unaFicha)
        {

        }

        public void EditarHistorialMedico(HistorialMedico unHistorial)
        {

        }

        public void ProgramarVacuna()
        {

        }

        public void VerConsulta()
        {

        }

        public FichaMedica VerFichaMascota(Mascota unaMascota)
        {
            return null;
        }

        public HistorialMedico VerHistorialMedico(Mascota unaMascota)
        {
            return null;
        }

        public List<Medicamento> VerMedicamentos()
        {
            return null;
        }

        //choca con el metodo de usuario
        //public List<Producto> VerStock()
        //{
        //    return null;
        //}
    }
}
