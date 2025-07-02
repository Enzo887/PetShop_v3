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
        DAL.Veterinario unVeterinarioDal = new DAL.Veterinario();
        public override void AgregarProducto(Producto unProducto)
        {
           
        }
        //revisar si hice cagada o no hice mis propios metodos xd
        public void ActualizarVacuna(BE.Vacuna unaVacuna, int idProducto) 
        {   
            
            unVeterinarioDal.ActualizarVacuna(unaVacuna, idProducto);
        }

        public void ActualizarMedicamento(BE.Medicamento unMedicamento, int idProducto)
        {
            
            unVeterinarioDal.ActualizarMedicamento(unMedicamento, idProducto);
        }

        public void AgregarMedicamento(BE.Medicamento unMedicamento)
        {
           
            unVeterinarioDal.AgregarMedicamento(unMedicamento);
        }
        public void AgregarVacuna(BE.Vacuna unaVacuna)
        {
            
            unVeterinarioDal.AgregarVacuna(unaVacuna);
        }


        public BE.Medicamento ObtenerMedicamentoPorID(int idProducto) 
        {
            
            return unVeterinarioDal.ObtenerMedicamentoPorId(idProducto);
            
        }
        public BE.Vacuna ObtenerVacunaPorID(int idProducto)
        {
            return unVeterinarioDal.ObtenerVacunaPorId(idProducto);
        }
        public int ObtenerCategoriaPorID(int idProducto) 
        {
            return unVeterinarioDal.ObtenerCategoriaPorID((int)idProducto);
        }
        public List<BE.Producto> ObtenerProductos() 
        {
            var productos = new List<BE.Producto>();
           
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

        public void CrearConsulta(BE.Consulta unaConsulta, int idHistorial)
        {
            unVeterinarioDal.CrearConsulta(unaConsulta, idHistorial);
        }

        public int CrearFichaMascota(BE.FichaMedica unaFicha, BE.Mascota unaMascota, BE.Cliente unCliente)
        {
            //Verificamos que todos los campos sean validos
            if (unaMascota.FechaDeNacimiento > DateTime.Today)
                throw new Exception("No se puede agendar una mascota que todavía no nació.");
            if (string.IsNullOrWhiteSpace(unaMascota.Nombre) ||
                string.IsNullOrWhiteSpace(unaMascota.Especie) ||
                string.IsNullOrWhiteSpace(unaMascota.Raza) ||
                string.IsNullOrWhiteSpace(unaMascota.Sexo) ||
                unaMascota.Peso <= 0 ||
                string.IsNullOrWhiteSpace(unaMascota.Dueño.Nombre) ||
                string.IsNullOrWhiteSpace(unaMascota.Dueño.Apellido) ||
                (unaMascota.Dueño.DNI <= 0) ||
                (unaMascota.Dueño.Telefono <= 0) ||
                string.IsNullOrWhiteSpace(unaMascota.Dueño.Email))
            {
                throw new Exception("Por favor, completá todos los campos obligatorios.");
            }
            //Creamos un cliente basado en la informacion que recibimos del formulario, sera el dueño de la mascota
            BE.Cliente cliente = new BE.Cliente
            {
                Nombre = unaMascota.Dueño.Nombre,
                Apellido = unaMascota.Dueño.Apellido,
                DNI = unaMascota.Dueño.DNI,
                Telefono = unaMascota.Dueño.Telefono,
                Email = unaMascota.Dueño.Email
            };
            //Creamos una mascota tambien basada en la info recibida del form y le asignamos al cliente creado como ddueño
            BE.Mascota mascota = new BE.Mascota
            {
                Nombre = unaMascota.Nombre,
                Especie = unaMascota.Especie,
                Raza = unaMascota.Raza,
                Sexo = unaMascota.Sexo,
                Peso = unaMascota.Peso,
                FechaDeNacimiento = unaMascota.FechaDeNacimiento,
                Dueño = cliente
            };
            //Creamos la ficha medica con los datos de la mascota, su dueño y la fecha actual, que seria la de registro
            BE.FichaMedica ficha = new BE.FichaMedica
            {
                Mascota = mascota,
                FechaDeRegistro = DateTime.Now,
                Cliente = cliente
            };

           
            //instanciamos un veterinario de la clase dal que es donde se va a comunicar con la base de datos, ahi llamamos al metodo CrearFichaMedica de veterinario en la capa dal y le pasasmos como parametro la ficha que creamos para poder insertarla y nos va a retornar el id que se haya generado
         
            return unVeterinarioDal.CrearFichMedica(ficha);
        }

        public BE.FichaMedica ObtenerFichaPorMascotaID(int idMascota)
        {
            DAL.FichaMedica fichaMedicaDAL = new DAL.FichaMedica();
            return fichaMedicaDAL.ObtenerFichaPorMascotaID(idMascota);
        }
        public void GuardarCambiosFicha(BE.FichaMedica unaFicha)
        {
            //vamos a guardar la mascota y el cliente que seria le dueño de la ficha que recibimos por parametro
            var mascota = unaFicha.Mascota;
            var cliente = unaFicha.Cliente;

            //validamos que todos los campos sean validos
            if (mascota.FechaDeNacimiento > DateTime.Today)
                throw new Exception("No se puede agendar una mascota que todavía no nació.");
            if (string.IsNullOrWhiteSpace(mascota.Nombre) ||
                string.IsNullOrWhiteSpace(mascota.Especie) ||
                string.IsNullOrWhiteSpace(mascota.Raza) ||
                string.IsNullOrWhiteSpace(mascota.Sexo) ||
                mascota.Peso <= 0 ||
                string.IsNullOrWhiteSpace(cliente.Nombre) ||
                string.IsNullOrWhiteSpace(cliente.Apellido) ||
                cliente.DNI <= 0 ||
                cliente.Telefono <= 0 ||
                string.IsNullOrWhiteSpace(cliente.Email))
            {
                throw new Exception("Por favor, completá todos los campos obligatorios.");
            }

            // Creamos una instancia de veterinario de la capa DAL donde se comunica con la base de datos y llamamos al metodo que va a escribir la actualizacion de la ficha donde le pasamos la ficha actualizada
            DAL.Veterinario unVeterinarioDAL = new DAL.Veterinario();
            unVeterinarioDAL.ActualizarFichaMedica(unaFicha);
        }
        
        //editar ficha va a ser actualizar
        public void EditarFichaMascota(FichaMedica unaFicha)
        {

        }

        public void EditarHistorialMedico(HistorialMedico unHistorial)
        {

        }

        public void ProgramarVacuna()
        {

        }
        public List<BE.Vacuna> ObtenerVacunasPorMascotaID(int idMascota)
        {
            //instancio un historial medico que va a hacer las consultas a la base de datos para traerme las vacunas que tenga programadas una mascota o la consultas de esta misma mascota, tanto el metodo ObtenerVacunasPorMascotaID como ObtenercConsultasPorMascotaID va a retornar la lista de vacunas y consultas
            DAL.HistorialMedico unHistorialDAL = new DAL.HistorialMedico();
            return unHistorialDAL.ObtenerVacunasPorMascotaID(idMascota);
        }
        public List<BE.Consulta> ObtenerConsultasPorMascotaID(int idMascota)
        {
            DAL.HistorialMedico unHistorialDAL = new DAL.HistorialMedico();
            return unHistorialDAL.ObtenerConsultasPorMascotaID(idMascota);
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
