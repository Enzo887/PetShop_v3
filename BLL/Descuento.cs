using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Descuento
    {
        DAL.Descuento descuentoDAL = new DAL.Descuento();

        public void CrearDescuento(string nombre, int porcentaje, int usuarioId)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new Exception("Datos del descuento invalidos");
            }
            if (porcentaje <= 0 || porcentaje >100)
            {
                throw new Exception("El porcentaje solo puede estar entre 1% y 100%");
            }
            BE.Descuento unDescuento = new BE.Descuento()
            {
                NombreDescuento = nombre,
                PorcentajeDescuento = porcentaje,
                UsuarioID = usuarioId
            };

            descuentoDAL.InsertarDescuento(unDescuento);
        }

        public List<BE.Descuento> ListarDescuentos()
        {
            DAL.Descuento descuentoDAL = new DAL.Descuento();
            return descuentoDAL.ListarDescuentos();
        }

        public BE.Descuento ObtenerDescuentoPorID(int idDescuento)
        {
            DAL.Descuento descuentoDAL = new DAL.Descuento();
            return descuentoDAL.ObternerDescuentoPorID(idDescuento);
        }

        public void EliminarDescuento(int idDescuento)
        {
            if (idDescuento <= 0)
            {
                throw new ArgumentException("El ID de la mascota no es válido.");
            }

            DAL.Descuento unDescuentoDAL = new DAL.Descuento();
            unDescuentoDAL.EliminarDescuento(idDescuento);
        }
    }
}
