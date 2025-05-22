using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPetShop_v1
{
    public partial class formInicio : Form
    {
        public formInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = tboxUsuario.Text;
            string clave = tboxClave.Text;

            BLL.Usuario usuario = new BLL.Usuario();
            BE.Usuario usuarioLogeado =  usuario.Loguearse(nombreUsuario, clave);

            if(usuarioLogeado != null)
            {
                if(usuarioLogeado.NombreUsuario == "admin")
                {
                    Form formInicio = new Administracion.AdminInicio();
                    formInicio.Show();
                }
                else if (usuarioLogeado.NombreUsuario == "gerente")
                {
                    Form formGerente = new Gerente.GerenteInicio();
                    formGerente.Show();
                }
                else if (usuarioLogeado.NombreUsuario == "vendedor")
                {
                    Form formVendedor = new Vendedor.VendedorHome();
                    formVendedor.Show();
                }
                else if (usuarioLogeado.NombreUsuario == "veterinario")
                {
                    Form formVeterinario = new Veterinario.VeterinarioInicio();
                    formVeterinario.Show();
                }
            }
            else
            {
                MessageBox.Show("El usuario o la clave es incorrecta");
            }
        }
    }
}
