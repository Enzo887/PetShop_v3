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
        
        
        public VeterinarioInicio()
        {
            InitializeComponent();

            crearFichaMascota = new UC_CrearFichaMascota();
            editarFichaMascota = new UC_EditarFichaMascota();
            editarHistorialMedico = new UC_EditarHistorialMedico();
            gestionarStock = new UC_GestionarStock();
            agregarProducto = new UC_AgregarProducto(gestionarStock);
            editarProducto = new UC_EditarProducto(gestionarStock);
            agregarConsulta = new UC_AgregarConsulta(editarHistorialMedico);
            programarVacuna= new UC_ProgramarVacuna(editarHistorialMedico);

            crearFichaMascota.Dock = DockStyle.Fill;
            editarFichaMascota.Dock = DockStyle .Fill;
            editarHistorialMedico.Dock = DockStyle .Fill;
            gestionarStock.Dock = DockStyle .Fill;
            agregarProducto.Dock = DockStyle .Fill;
            agregarConsulta.Dock = DockStyle .Fill;
            programarVacuna.Dock = DockStyle .Fill;
            //agrega los UserControl
            panelContenedorVeterinario.Controls.Add(crearFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarFichaMascota);
            panelContenedorVeterinario.Controls.Add(editarHistorialMedico);
            panelContenedorVeterinario.Controls.Add(gestionarStock);
            panelContenedorVeterinario.Controls.Add(agregarProducto);
            panelContenedorVeterinario.Controls.Add (agregarConsulta);
            panelContenedorVeterinario.Controls.Add(programarVacuna);

            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible = false ;
            programarVacuna.Visible = false;


        }
        public void MostrarCreacionFicha() 
        {
            crearFichaMascota.Visible = true;
            crearFichaMascota.BringToFront();
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible=false;
            programarVacuna.Visible = false;    
        
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
            agregarConsulta.Visible = false;
            programarVacuna.Visible = false;
        }
        public void MostrarEdicionHistorial()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = true;
            editarHistorialMedico.BringToFront();
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible = false;
            programarVacuna.Visible = false;
        }
        public void MostrarGestionStock()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = true;
            gestionarStock.BringToFront();
            agregarProducto.Visible = false;
            agregarConsulta.Visible = false;
            programarVacuna.Visible = false;
        }
        public void MostrarAgregarProducto()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = true;
            agregarProducto.BringToFront();
            agregarConsulta.Visible = false;
            programarVacuna.Visible = false;
        }
        public void MostrarPrincipal() 
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible = false;
            programarVacuna.Visible = false;
        }
        public void MostrarAgregarConsulta()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible = true;
            programarVacuna.Visible = false;
        }
        public void MostrarProgramarVacuna()
        {
            crearFichaMascota.Visible = false;
            editarFichaMascota.Visible = false;
            editarHistorialMedico.Visible = false;
            gestionarStock.Visible = false;
            agregarProducto.Visible = false;
            agregarConsulta.Visible = false;
            programarVacuna.Visible = true;
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
           
            if (tBoxBusqueda.Text == null) 
            {
                MessageBox.Show("Escriba el nombre de una mascota para buscar");
            }
            string texto = tBoxBusqueda.Text.ToLower();
            foreach (DataGridViewRow fila in dataGridViewFichas.Rows) 
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.Cells["NombreMascota"].Value.ToString().ToLower();

                // Mostrar solo si contiene el texto buscado
                fila.Visible = string.IsNullOrEmpty(texto) || nombre.Contains(texto);
            }
            tBoxBusqueda.Clear();

        }
        
    }
}
