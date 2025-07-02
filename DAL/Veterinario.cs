using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Veterinario
    {
        private Conexion conexion = new Conexion();
        public int CrearFichMedica(BE.FichaMedica unaFicha)
        {
            //le paso los parametros en los que se va a aescribir del store procedure para despues retornar el metodo de escribir por sp y mandar a las base de datos la nueva ficha con los datos que le pase en los parametros 
            SqlParameter[] parametros = new SqlParameter[]
            {
                //cliente/dueño de la mascota
                new SqlParameter("@ClienteDNI", unaFicha.Mascota.Dueño.DNI),
                new SqlParameter("@NombreCliente", unaFicha.Mascota.Dueño.Nombre),
                new SqlParameter("@ApellidoCliente", unaFicha.Mascota.Dueño.Apellido),
                new SqlParameter("@EmailCliente", unaFicha.Mascota.Dueño.Email),
                new SqlParameter("@TelefonoCliente", unaFicha.Mascota.Dueño.Telefono),

                //mascota
                new SqlParameter("@NombreMascota", unaFicha.Mascota.Nombre),
                new SqlParameter("@EspecieMascota", unaFicha.Mascota.Especie),
                new SqlParameter("@SexoMascota", unaFicha.Mascota.Sexo),
                new SqlParameter("@RazaMascota", unaFicha.Mascota.Raza),
                new SqlParameter("@PesoMascota", unaFicha.Mascota.Peso),
                new SqlParameter("@FechaNacimiento", unaFicha.Mascota.FechaDeNacimiento),

                //ficha medica
                new SqlParameter("@FechaRegistroFicha", unaFicha.FechaDeRegistro),

                new SqlParameter("@MascotaID", SqlDbType.Int){Direction = ParameterDirection.Output}
            };
            conexion.EscribirPorStoreProcedure("SP_CrearFichaMedica", parametros);

            int idMascotaGenerado = Convert.ToInt32(parametros[12].Value);
            unaFicha.Mascota.ID = idMascotaGenerado;

            return idMascotaGenerado;
        }

        public void ActualizarFichaMedica(BE.FichaMedica fichaActualizada)
        {
            //le paso los parametros en los que se va a escribir del store procedure para despues retornar el metodo de escribir por sp y mandar a las base de datos la ficha con los datos actualizados
            SqlParameter[] parametros = new SqlParameter[]
            {
                //Datos Mascota
                new SqlParameter("@MascotaID", fichaActualizada.Mascota.ID),
                new SqlParameter("@NombreMascota", fichaActualizada.Mascota.Nombre),
                new SqlParameter("@EspecieMascota", fichaActualizada.Mascota.Especie),
                new SqlParameter("@RazaMascota", fichaActualizada.Mascota.Raza),
                new SqlParameter("@SexoMascota", fichaActualizada.Mascota.Sexo),
                new SqlParameter("@PesoMascota", fichaActualizada.Mascota.Peso),
                new SqlParameter("@FechaNacimiento", fichaActualizada.Mascota.FechaDeNacimiento),
                //Datos Cliente
                new SqlParameter("@DNICliente", fichaActualizada.Cliente.DNI),
                new SqlParameter("@NombreCliente", fichaActualizada.Cliente.Nombre),
                new SqlParameter("@ApellidoCliente", fichaActualizada.Cliente.Apellido),
                new SqlParameter("@EmailCliente", fichaActualizada.Cliente.Email),
                new SqlParameter("@TelefonoCliente", fichaActualizada.Cliente.Telefono)
            };
            conexion.EscribirPorStoreProcedure("SP_ActualizarFichaMedica", parametros);
        }

        public void EliminarMascota(int idMascota)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdMascota", idMascota)
            };

            //llamamos al metodo que va a ejecutar el store procedure en la base de datos
            conexion.EscribirPorStoreProcedure("SP_EliminarMascota", parametros);
        }
        public int AgregarMedicamento(BE.Medicamento unMedicamento) 
        {   // escribe en base de datos un nuevo medicamento

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", unMedicamento.Nombre),
                new SqlParameter("@Precio", unMedicamento.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", unMedicamento.Vencimiento),
                new SqlParameter("@Stock", unMedicamento.Cantidad),
                new SqlParameter("@Categoria_Id", 1),
                new SqlParameter("@Producto_Id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }
            };
            conexion.EscribirPorStoreProcedure("SP_AgregarProducto", parameters);
            int idGenerado = Convert.ToInt32(parameters[5].Value);
            unMedicamento.IdProducto = idGenerado;

            return idGenerado;

        }
        public int AgregarVacuna(BE.Vacuna unaVacuna)
        {   // escribe en base de datos una nueva vacuna
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Nombre", unaVacuna.Nombre),
                new SqlParameter("@Precio", unaVacuna.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", unaVacuna.Vencimiento),
                new SqlParameter("@Stock", unaVacuna.Cantidad),
                new SqlParameter("@Categoria_Id", 2),
                new SqlParameter("@Producto_Id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }
            };
            conexion.EscribirPorStoreProcedure("SP_AgregarProducto", parameters);
            //me traigo el id autoincremental del sql y lo devuelvo
            int idGenerado = Convert.ToInt32(parameters[5].Value);
            unaVacuna.IdProducto = idGenerado;

            return idGenerado;

        }

        public void ActualizarVacuna(BE.Vacuna unaVacuna, int idProducto)
        {   // actualiza los datos en base de datos una vacuna existente
            string estado;
            if (unaVacuna.Estado == true)
            {
                estado = "Habilitado";
            }
            else
            {
                estado = "Deshabilitado";
            }

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", unaVacuna.Nombre),
                new SqlParameter("@Precio", unaVacuna.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", unaVacuna.Vencimiento),
                new SqlParameter("@Stock", unaVacuna.Cantidad),
                new SqlParameter("@Estado",estado)
            
            };
            conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parameters);
        }

        public void ActualizarMedicamento(BE.Medicamento unMedicamento, int idProducto)
        {   // actualiza los datos en base de datos un medicamento existente

            string Receta;
            if (unMedicamento.RequiereReceta == true)
            {
                Receta = "SI";
            }
            else 
            {
                Receta = "NO";
            }
            string estado;
            if (unMedicamento.Estado == true)
            {
                estado = "Habilitado";
            }
            else
            {
                estado = "Deshabilitado";
            }

            SqlParameter[] parameters = new SqlParameter[]
                {
                new SqlParameter("@IdProducto", idProducto),
                new SqlParameter("@Nombre", unMedicamento.Nombre),
                new SqlParameter("@Precio", unMedicamento.PrecioUnidad),
                new SqlParameter("@FechaVencimiento", unMedicamento.Vencimiento),
                new SqlParameter("@Stock", unMedicamento.Cantidad),
                new SqlParameter("@Estado",estado),
                new SqlParameter("@Receta", Receta)

                };
            conexion.EscribirPorStoreProcedure("SP_ActualizarProducto", parameters);

        }


        public Medicamento ObtenerMedicamentoPorId(int idProducto) 
        {   
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", idProducto)
                };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);//llama al metodo leer por storeprocedure

            if (tabla != null && tabla.Rows.Count > 0)
            {
                var fila = tabla.Rows[0];

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

                return new Medicamento
                {
                    IdProducto = Convert.ToInt32(fila["PRODUCTO_ID"]),
                    Nombre = fila["NOMBRE"].ToString(),
                    PrecioUnidad = float.Parse(fila["PRECIO"].ToString()),
                    Vencimiento = Convert.ToDateTime(fila["FECHA_VENCIMIENTO"]),
                    Cantidad = float.Parse(fila["STOCK"].ToString()),
                    Estado = _estado,
                    RequiereReceta= _receta,
                  
                };
            }//crea un objeto medicamento y lo llena con sus datos
            return null;
        }

        public Vacuna ObtenerVacunaPorId(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", idProducto)
                };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);//llama al metodo leer por storeprocedure

            if (tabla != null && tabla.Rows.Count > 0)
            {
                var fila = tabla.Rows[0];

                string estado = fila["ESTADO"].ToString();
                bool _estado;
                if (estado == "Habilitado")
                {
                    _estado = true;
                }
                else { _estado = false; }

                return new Vacuna
                {
                    IdProducto = Convert.ToInt32(fila["IdProducto"]),
                    Nombre = fila["Nombre"].ToString(),
                    PrecioUnidad = float.Parse(fila["Precio"].ToString()),
                    Vencimiento = Convert.ToDateTime(fila["FechaVencimiento"]),
                    Cantidad = float.Parse(fila["Stock"].ToString()),
                    Estado = _estado,
                };
            }//crea un objeto vacuna y lo llena con sus datos
            return null;
        }

        public DataTable ObtenerProductosDeVeterinario()
        {   // obtiene todos los datos de productos que son medicamento o vacunas
            return conexion.LeerPorComando("SELECT * FROM Vista_ProductosConCategoria");
        }
        public int ObtenerCategoriaPorID(int idProducto)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@IdProducto", idProducto)
            };

            var tabla = conexion.LeerPorStoreProcedure("SP_ObtenerProductoPorId", parametros);

            if (tabla != null && tabla.Rows.Count > 0)
            {   //devuelve solo la categoria
                return Convert.ToInt32(tabla.Rows[0]["CATEGORIA_ID"]);
            }
           else { return -1; }
        }


        /*
         * crear el proc y agregarlo qsyo gracias copiloto
        public void EliminarProducto(int idProducto)
        {   // elimina un producto de la base de datos
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@IdProducto", idProducto)
            };
            conexion.EscribirPorStoreProcedure("SP_EliminarProducto", parametros);
        */

        public int CrearConsulta(BE.Consulta unaConsulta, int idHistorial) 
        {
            // escribe en base de datos una nueva vacuna
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Historial_id", idHistorial),
                new SqlParameter("@FechaConsulta", unaConsulta.FechaDeConsulta),
                new SqlParameter("@Diagnostico", unaConsulta.Diagnostico),
                new SqlParameter("@Descripcion", unaConsulta.Observaciones),
                new SqlParameter("@Tratamiento", unaConsulta.Tratamiento),
                new SqlParameter("@Consulta_id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    }
            };
            conexion.EscribirPorStoreProcedure("SP_AgregarConsulta", parameters);
            //me traigo el id autoincremental del sql y lo devuelvo
            int idGenerado = Convert.ToInt32(parameters[5].Value);
            unaConsulta.IdConsulta = idGenerado;

            return idGenerado;
        }

       // public void ProgramarVacuna(BE.Vacuna un)


    }
}
