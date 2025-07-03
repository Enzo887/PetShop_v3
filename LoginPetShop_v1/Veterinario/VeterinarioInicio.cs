using BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginPetShop_v1.Veterinario
{
    public partial class VeterinarioInicio : Form
    {
        //instancia los UserControl
        private UC_CrearFichaMascota crearFichaMascota;
        private UC_EditarFichaMascota editarFichaMascota;
        private UC_EditarHistorialMedico editarHistorialMedico;
        private UC_AgregarConsulta agregarConsulta;
        private UC_GestionarStock gestionarStock;
        private UC_AgregarProducto agregarProducto;
        private UC_EditarProducto editarProducto;
        private UC_ProgramarVacuna programarVacuna;
        int idProducto;
        
        
        public VeterinarioInicio()
        {
            InitializeComponent();

            crearFichaMascota = new UC_CrearFichaMascota();
            editarFichaMascota = new UC_EditarFichaMascota();
            editarHistorialMedico = new UC_EditarHistorialMedico();
            gestionarStock = new UC_GestionarStock();
            agregarProducto = new UC_AgregarProducto(gestionarStock);
            editarProducto = new UC_EditarProducto(gestionarStock, idProducto);
            agregarConsulta = new UC_AgregarConsulta(editarHistorialMedico);
            programarVacuna= new UC_ProgramarVacuna(editarHistorialMedico);


            crearFichaMascota.Dock = DockStyle.Fill;
            editarFichaMascota.Dock = DockStyle .Fill;
            editarHistorialMedico.Dock = DockStyle .Fill;
            gestionarStock.Dock = DockStyle .Fill;
            agregarProducto.Dock = DockStyle .Fill;
            agregarConsulta.Dock = DockStyle .Fill;
            programarVacuna.Dock = DockStyle .Fill;
            editarProducto.Dock = DockStyle .Fill;
            //agrega los UserControl
            panelContenedorVeterinario.Controls.Add(crearFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarHistorialMedico);
            panelContenedorVeterinario.Controls.Add(gestionarStock);
            panelContenedorVeterinario.Controls.Add(agregarProducto);
            panelContenedorVeterinario.Controls.Add (agregarConsulta);
            panelContenedorVeterinario.Controls.Add(programarVacuna);
            panelContenedorVeterinario.Controls.Add(editarProducto);



            MostrarSolo(null);
            MostrarFichasMascotas();

        }

        private void MostrarSolo(UserControl visibleControl)
        {
            foreach (Control ctrl in panelContenedorVeterinario.Controls)
            {
                if (ctrl is UserControl uc)
                {
                    uc.Visible = (uc == visibleControl && visibleControl != null);
                    if (uc.Visible)
                        uc.BringToFront();
                }
            }
        }


        public void MostrarCreacionFicha() 
        {
            MostrarSolo(crearFichaMascota);

        }
        public void MostrarEdicionFicha(FichaMedica unaFicha)
        {
            MostrarSolo(editarFichaMascota);
            editarFichaMascota.CargarFicha(unaFicha);
        }
        public void MostrarEdicionHistorial(int idMascota)
        {


            MostrarSolo(editarHistorialMedico);

            editarHistorialMedico.CargarHistorial(idMascota);
        }
        public void MostrarGestionStock()
        {
            MostrarSolo(gestionarStock);
            gestionarStock.ActualizarDataGrid();
     
            
        }
        public void MostrarAgregarProducto()
        {
            MostrarSolo(agregarProducto);
        }
        public void MostrarEditarProducto(int idProducto)
        {

            MostrarSolo(editarProducto);
            editarProducto.CargarProducto(idProducto);
        }
        public void MostrarPrincipal() 
        {

            MostrarSolo(null);
        }
        public void MostrarAgregarConsulta(int idMascota)
        {
            MostrarSolo(agregarConsulta);
            agregarConsulta.SetearIdMascota(idMascota);
           
        }
        public void MostrarProgramarVacuna(int idMascota)
        {
            MostrarSolo(programarVacuna);
            programarVacuna.CargarVacunas();

        }
        private void VeterinarioInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void lblVeterinario_Click(object sender, EventArgs e)
        {

        }


        private void BtnCrearFicha_Click(object sender, EventArgs e)
        {
            MostrarCreacionFicha();

        }

        private void lblBuscador_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lBoxMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {
           MostrarGestionStock();
        }

        private void panelContenedorVeterinario_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AgregarFila(int idMascota, string nombreMascota)
        {

            dataGridViewFichas.Rows.Add(idMascota, nombreMascota, "ver");
           
        }

        public void MostrarFichasMascotas()
        {
            //instanciamos una ficha medica de bll y una lista de mascotas de tipo mascota para poder guardar en esa lista los datos que queremos mostrar de las mascotas en el inicio del formulario, como son el ID y Nombre de la mascota
            BLL.FichaMedica fichaMedicaBLL = new BLL.FichaMedica();
            List<Mascota> listaMascotas = fichaMedicaBLL.ListarFichas();

            dataGridViewFichas.Rows.Clear();
            //recorremos la lista y por cada mascota llamamos al metodo agregar fila que va a poner en sus respectiva columna el id de la mascota que tiene en la base de datos, el nombre de la mascota y el boton ver 
            foreach(var mascota in listaMascotas)
            {
                AgregarFila(mascota.ID, mascota.Nombre);
            }
        }
        private void tBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewFichas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //toma el nombre de la celda de al lado para pasarlo como parametro
            string nombreMascota = dataGridViewFichas.Rows[e.RowIndex].Cells["nombreMascota"].Value.ToString();
            //hay que agregar la solicitud de parametro de la edicion de ficha
            //MostrarEdicionFicha();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //nombreBuscado va a guardar el nombre que ingrese por teclado
            string nombreBuscado = tBoxBusqueda.Text.Trim();

            //verifico que se haya ingresado un nombre
            if (string.IsNullOrWhiteSpace(nombreBuscado)) 
            {
                MessageBox.Show("Escriba el nombre de una mascota para buscar");
                return;
            }

            //creo la instancia de la ficha bll que es la que tiene la logica y llamo al metodo de BuscarFichas al cual le pasamos por parametro el nombre que se busco, esto va a devolver los resultados con un datatable de las coincidencias
            try
            {
                BLL.FichaMedica FichaMedicaBLL = new BLL.FichaMedica();
                List<Mascota> mascotasEncontradas = FichaMedicaBLL.BuscarFicha(nombreBuscado);

                //limpiamos el grid para que solo se muestre la coincidencia
                dataGridViewFichas.Rows.Clear();

                //recorremos cada fila de la coincidencia y gurdamos lo necesario que siempre es el ID y el Nombre de la mascota, para despues otra vez llamar al metodo AgregarFila que va a poner los datos que guardo antes de la coincidencia
                foreach (Mascota mascota in mascotasEncontradas)
                {
                    AgregarFila(mascota.ID, mascota.Nombre);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error buscando la ficha de la mascota" + ex.Message);
            }
            tBoxBusqueda.Clear();
        }

     
        private void dataGridViewFichas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridViewFichas.Columns["Ver"].Index)
            {
                int idMascota = Convert.ToInt32(dataGridViewFichas.Rows[e.RowIndex].Cells[0].Value);

                BLL.Veterinario veterinarioBLL = new BLL.Veterinario();
                BE.FichaMedica fichaCompleta = veterinarioBLL.ObtenerFichaPorMascotaID(idMascota);

                if(fichaCompleta != null)
                {
                    var veterinarioInicio = this.FindForm() as VeterinarioInicio;
                    if (veterinarioInicio != null)
                    {
                        veterinarioInicio.MostrarEdicionFicha(fichaCompleta);
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error con la ficha médica");
                }
            }
        }

        private void btnLimpiarBusquedaFicha_Click(object sender, EventArgs e)
        {
            tBoxBusqueda.Clear();
            MostrarFichasMascotas();
        }
    }
}
