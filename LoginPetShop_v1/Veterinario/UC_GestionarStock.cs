﻿using System;
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
    public partial class UC_GestionarStock : UserControl
    {
        public UC_GestionarStock()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            
            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarPrincipal();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }
        public void AgregarFilaProductos(string nombreProducto, bool estado)
        {
            string _estado;
            if (estado == true)
            {
                _estado = "Habilitado";
            }
            else if (estado == false)
            {
                _estado = "Deshabilitado";
            }
            else { _estado = "Deshabilitado"; }
                dataGridViewProductos.Rows.Add(nombreProducto, _estado, "ver");

        }
        public void AgregarFilaProximoAVencer(string nombreProducto, string vencimiento, float cantidadRestante) 
        {
            dataGridViewProductoProxVencimiento.Rows.Add(nombreProducto, vencimiento, cantidadRestante);
        }
        public void ProximoAVencer() 
        {
            //agregar funcion de detectar que un producto vence dentro de poco y que lo agrege al data grid de proximo a vencer y si un producto ya esta vencido cambie su estado a deshabilitado y lanze un aviso
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            
            var veterinarioInicio = this.FindForm() as VeterinarioInicio;

            

            if (veterinarioInicio != null)
            {
                veterinarioInicio.MostrarAgregarProducto();
            }
            else
            {
                MessageBox.Show("No se encontro el form");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (tBoxBuscarProducto == null)
            {
                MessageBox.Show("Escriba el nombre de una mascota para buscar");
            }
            string texto = tBoxBuscarProducto.Text.ToLower();
            foreach (DataGridViewRow fila in dataGridViewProductos.Rows)
            {
                if (fila.IsNewRow) continue;

                string nombre = fila.Cells["NombreProducto"].Value.ToString().ToLower();

                // Mostrar solo si contiene el texto buscado
                fila.Visible = string.IsNullOrEmpty(texto) || nombre.Contains(texto);
            }
            tBoxBuscarProducto.Clear();
        }

        private void tBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewProductoProxVencimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
