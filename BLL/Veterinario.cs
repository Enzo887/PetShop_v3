using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Veterinario : Usuario
    {
        public override void AgregarProducto(Producto unProducto)
        {
           
        }
        //revisar si hice cagada o no hice mis propios metodos xd
        public void ActualizarVacuna(BE.Vacuna unaVacuna, int idProducto) 
        {   
            DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
            unVeterinarioDal.ActualizarVacuna(unaVacuna, idProducto);
        }

        public void ActualizarMedicamento(BE.Medicamento unMedicamento, int idProducto)
        {
            DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
            unVeterinarioDal.ActualizarMedicamento(unMedicamento, idProducto);
        }

        public void AgregarMedicamento(BE.Medicamento unMedicamento)
        {
            DAL.Veterinario unVeterinarioDAL = new DAL.Veterinario();
            unVeterinarioDAL.AgregarMedicamento(unMedicamento);
        }
        public void AgregarVacuna(BE.Vacuna unaVacuna)
        {
            DAL.Veterinario unVeterinarioDAL = new DAL.Veterinario();
            unVeterinarioDAL.AgregarVacuna(unaVacuna);
        }

        public BE.Medicamento ObtenerMedicamentoPorID(int idProducto) 
        {
            DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
            return unVeterinarioDal.ObtenerMedicamentoPorId(idProducto);
            
        }
        public BE.Vacuna ObtenerVacunaPorID(int idProducto)
        {
            DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
            return unVeterinarioDal.ObtenerVacunaPorId(idProducto);
        }
        public int ObtenerCategoriaPorID(int idProducto) 
        {
            DAL.Veterinario unveterinarioDal = new DAL.Veterinario();
            return unveterinarioDal.ObtenerCategoriaPorID((int)idProducto);
        }
        public List<BE.Producto> ObtenerProductos() 
        {
            var productos = new List<BE.Producto>();
            DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
            // Obtengo los datos desde la DAL y los guardo en una lista
            var tabla = unVeterinarioDal.ObtenerProductosDeVeterinario();

            foreach (DataRow fila in tabla.Rows)
            {
                int categoria = Convert.ToInt32(fila["Categoria_Id"]);

                if (categoria == 1) // Medicamento
                {
                    string estado = fila["ESTADO"].ToString();
                    bool _estado;
                    bool _receta;
                    if (estado == "Habilitado")
                    {
                        _estado = true;
                    }
                    else { _estado = false; }

                   

                        string receta = fila["RECETA"].ToString();

                    if (receta == "SI") 
                    {
                        _receta = true;
                    }
                    else { _receta = false; }

                        productos.Add(new BE.Medicamento
                        {
                            IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                            Nombre = fila["NombreProducto"].ToString(),
                            PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                            Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                            Cantidad = float.Parse(fila["Stock"].ToString()),
                            Estado = _estado,
                            RequiereReceta = _receta,

                        });
                }
                else if (categoria == 2) // Vacuna
                {
                    string estado = fila["ESTADO"].ToString();
                    bool _estado;
    
                    if (estado == "Habilitado")
                    {
                        _estado = true;
                    }
                    else { _estado = false; }


                    productos.Add(new BE.Vacuna
                    {
                        IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                        Nombre = fila["NombreProducto"].ToString(),
                        PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                        Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                        Cantidad = float.Parse(fila["Stock"].ToString()),
                        Estado = _estado,
                        
                    });
                }
            }

            return productos;
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
