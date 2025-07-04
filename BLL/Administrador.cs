using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class Administrador : Usuario
    {
        DAL.Administrador unAdminDal = new DAL.Administrador();
        BE.Usuario unUsuario = new BE.Usuario();
     
        public List<Usuario> VerListaDeUsuarios()
        {
            return null;
        }

        
        public Administrador()
        {
            
        }
        public void RegistrarUsuario(BE.Usuario unUsuario)
        {
            //instancio un objeto admin de la clase DAL que es quien va a registrar al usuario 
       
            unAdminDal.RegistrarUsuario(unUsuario);
        }

        public void EditarUsuario(BE.Usuario unUsuario) 
        {
            
            unAdminDal.EditarUsuario(unUsuario);
    
        }

        public void EliminarUsuario (int idUsuario) 
        {
          
            unAdminDal.EliminarUsuario(idUsuario);
        }

        public List<BE.Usuario> ObtenerUsuarios() 
        {
            
            List<BE.Usuario> ListaUsuarios = new List<BE.Usuario>();
            

            DataTable Usuarios = unAdminDal.ObtenerUsuarios();
            foreach (DataRow fila in Usuarios.Rows) 
            {
                ListaUsuarios.Add(new BE.Usuario
                {
                    UsuarioID = Convert.ToInt32(fila["USUARIO_ID"]),
                    Rol = fila[("NOMBRE_ROL")].ToString(),
                    NombreUsuario = fila[("NOMBRE_USUARIO")].ToString(),
                    Nombre = fila[("NOMBRE")].ToString(),
                    Apellido = fila[("APELLIDO")].ToString(),
                    Contraseña = fila[("CONTRASEÑA")].ToString(),

                });
                    
            }
            return ListaUsuarios;
        }
        public List<BE.Venta> ObtenerVentasGenerales()
        {

            List<BE.Venta> ListaVentasGenerales = new List<BE.Venta>();


            DataTable ventasGenerales = unAdminDal.ObtenerVentasGenerales();
            foreach (DataRow fila in ventasGenerales.Rows)
            {
                ListaVentasGenerales.Add(new BE.Venta
                {
                    VentaID = Convert.ToInt32(fila["VENTA_ID"]),
                    FechaDeVenta = Convert.ToDateTime(fila["FECHA_VENTA"]),
                    PrecioTotal = Convert.ToInt32(fila["MONTO_TOTAL"]),

                });

            }
            return ListaVentasGenerales;
        }
        public List<BE.Cliente> ObtenerClientesFrecuentes()
        {

            List<BE.Cliente> ListaClientesFrecuentas = new List<BE.Cliente>();


            DataTable ClientesFrecuentes = unAdminDal.ObtenerClientesFrecuentes();
            foreach (DataRow fila in ClientesFrecuentes.Rows)
            {
                ListaClientesFrecuentas.Add(new BE.Cliente
                {
                    DNI = Convert.ToInt32(fila["DNI"]),
                    Nombre = fila[("NOMBRE")].ToString(),
                    Apellido =  fila[("APELLIDO")].ToString()

                });
            }
            return ListaClientesFrecuentas;
        }

        public List<BE.Producto> ObtenerStockActual()
        {

            List<BE.Producto> ListaProductos = new List<BE.Producto>();


            DataTable ProductosActuales = unAdminDal.ObtenerStock();
            foreach (DataRow fila in ProductosActuales.Rows)
            {
                ListaProductos.Add(new BE.Producto
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila[("NOMBRE")].ToString(),
                    Cantidad= Convert.ToInt32(fila["STOCK"]),

                });
            }
            return ListaProductos;
        }

        public List<BE.Producto> ObtenerProductosMasVendidos()
        {

            List<BE.Producto> ListaProductosMasVendidos = new List<BE.Producto>();


            DataTable ProductosActuales = unAdminDal.ObtenerProductosMasVendidos();
            foreach (DataRow fila in ProductosActuales.Rows)
            {
                ListaProductosMasVendidos.Add(new BE.Producto
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila[("NOMBRE")].ToString(),
                    Cantidad = Convert.ToInt32(fila["STOCK"]),
                });
            }
            return ListaProductosMasVendidos;
        }

        public BE.Usuario ObtenerUsuarioPorID(int idUsuario) 
        {
           return unAdminDal.ObtenerUsuarioPorID(idUsuario);
        }
    }
}
