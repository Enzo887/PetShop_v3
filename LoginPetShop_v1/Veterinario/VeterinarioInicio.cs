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
        private UC_GestionarStock gestionarStock;
        private UC_AgregarProducto agregarProducto;
        
        
        public VeterinarioInicio()
        {
            InitializeComponent();

            crearFichaMascota = new UC_CrearFichaMascota();
            editarFichaMascota = new UC_EditarFichaMascota();
            editarHistorialMedico = new UC_EditarHistorialMedico();
            gestionarStock = new UC_GestionarStock();
            agregarProducto = new UC_AgregarProducto(gestionarStock);

            crearFichaMascota.Dock = DockStyle.Fill;
            editarFichaMascota.Dock = DockStyle .Fill;
            editarHistorialMedico.Dock = DockStyle .Fill;
            gestionarStock.Dock = DockStyle .Fill;
            agregarProducto.Dock = DockStyle .Fill;
            //agrega los UserControl
            panelContenedorVeterinario.Controls.Add(crearFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarHistorialMedico);
            panelContenedorVeterinario.Controls.Add(gestionarStock);
            panelContenedorVeterinario.Controls.Add(agregarProducto);

            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;

            /*panelContenedorVeterinario.AutoScroll = false;
            tableLayoutPanelFichas.Dock = DockStyle.Top;
            vScrollBarFichas.Dock = DockStyle.Right;*/

        }
        public void MostrarCreacionFicha() 
        {
            crearFichaMascota.Visible = true;
            crearFichaMascota.BringToFront();
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
        
        }
        public void MostrarEdicionFicha(Mascota mascota, Cliente cliente)
        {
            editarFichaMascota.CargarMascota(mascota, cliente);

            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = true;
            editarFichaMascota.BringToFront();
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
        }
        public void MostrarEdicionHistorial()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = true;
            editarHistorialMedico.BringToFront();
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
        }
        public void MostrarGestionStock()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = true;
            gestionarStock.BringToFront();
            agregarProducto.Visible = false;
        }
        public void MostrarAgregarProducto()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = true;
            agregarProducto.BringToFront();    
        }
        public void MostrarPrincipal() 
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
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

        //despues arreglar idmascota
        public void AgregarFila(string nombreMascota)
        {

            dataGridViewFichas.Rows.Add(nombreMascota, "ver");
           
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
            //le asigno un nombre a la busqueda para que sea facil de manipular
            string nombreBuscado = tBoxBusqueda.Text.Trim();

            //verifico que se haya ingresado un nombre
            if (string.IsNullOrWhiteSpace(nombreBuscado)) 
            {
                MessageBox.Show("Escriba el nombre de una mascota para buscar");
            }

            //creo la instancia de la ficha y llamo al metodo de la busqueda que va a devolver los resultados con un datatable
            //asignamos este datatable que nos devuelve como datasource del grid que va a ser lo que carga los datos en la pantalla
            try
            {
                BLL.FichaMedica FichaMedicaBLL = new BLL.FichaMedica();
                DataTable nombreEncontrado = FichaMedicaBLL.BuscarFicha(nombreBuscado);

                dataGridViewFichas.Rows.Clear();

                foreach (DataRow Fila in nombreEncontrado.Rows)
                {
                    int idMascota = Convert.ToInt32(Fila["MASCOTA_ID"]);
                    string nombreMascota = Fila["NombreMascota"].ToString();

                    dataGridViewFichas.Rows.Add(idMascota, nombreMascota);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error buscando la ficha de la mascota" + ex.Message);
            }
            tBoxBusqueda.Clear();
        }
    }
}
