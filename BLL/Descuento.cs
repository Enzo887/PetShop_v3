using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
