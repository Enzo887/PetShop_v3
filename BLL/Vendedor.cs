using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Vendedor : Usuario
    {
        public override void AgregarProducto(Producto unProducto)
        {

        }

        public override void EditarProducto(Producto unProducto)
        {

        }

        //public override void EliminarProducto(Producto unProducto)
        //{

        //}

        public override void HabilitarProducto(Producto unProducto)
        {

        }

        public override void DeshabilitarProducto(Producto unProducto)
        {

        }
        public Descuento AplicarDescuento(Venta venta)
        {
            return null;
        }

        public List<Venta> VerReporteDeVentas()
        {
            return null;
        }

        //public List<Producto> VerStock()
        //{
        //    return null;
        //}
        DAL.Vendedor unVendedorDAL = new DAL.Vendedor();
        public List<BE.Producto> ObtenerProductos()
        {
            var productos = new List<BE.Producto>();
            var tabla = unVendedorDAL.ObtenerProductosDeVeterinario();
            foreach (DataRow fila in tabla.Rows)
            {
                int categoria = Convert.ToInt32(fila["Categoria_Id"]);

                if (categoria == 3) // Alimento
                {
                    string estado = fila["ESTADO"].ToString();
                    bool _estado;
                    //bool _receta;
                    if (estado == "Habilitado")
                    {
                        _estado = true;
                    }
                    else { _estado = false; }

                    //string receta = fila["RECETA"].ToString();

                    //if (receta == "SI")
                    //{
                    //    _receta = true;
                    //}
                    //else { _receta = false; }

                    productos.Add(new BE.Alimento
                    {
                        IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                        Nombre = fila["NombreProducto"].ToString(),
                        PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                        Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                        Cantidad = float.Parse(fila["Stock"].ToString()),
                        Estado = _estado,
                        //RequiereReceta = _receta,

                    });
                }
                else if (categoria == 4) // Accesorio
                {
                    string estado = fila["ESTADO"].ToString();
                    bool _estado;

                    if (estado == "Habilitado")
                    {
                        _estado = true;
                    }
                    else { _estado = false; }


                    productos.Add(new BE.Accesorio
                    {
                        IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                        Nombre = fila["NombreProducto"].ToString(),
                        PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                        //Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                        Cantidad = float.Parse(fila["Stock"].ToString()),
                        Estado = _estado,

                    });
                }
            }

            return productos;
        }
        public int ObtenerCategoriaPorID(int idProducto)
        {
            return unVendedorDAL.ObtenerCategoriaPorID((int)idProducto);
        }
        public BE.Alimento ObtenerAlimentoPorID(int idProducto)
        {

            return unVendedorDAL.ObtenerAlimentoPorID(idProducto);

        }
        
        public BE.Accesorio ObtenerAccesorioPorID(int idProducto)
        {
            return unVendedorDAL.ObtenerAccesorioPorID(idProducto);
        }
        public void ActualizarAccesorio(BE.Accesorio accesorio, int idProducto)
        {

            unVendedorDAL.ActualizarAccesorio(accesorio, idProducto);
        }
        

        public void ActualizarAlimento(BE.Alimento alimento, int idProducto)
        {

            unVendedorDAL.ActualizarAlimento(alimento, idProducto);
        }
        public void EliminarProducto(int idProducto)
        {
            unVendedorDAL.EliminarProducto(idProducto);
        }
    }
}
