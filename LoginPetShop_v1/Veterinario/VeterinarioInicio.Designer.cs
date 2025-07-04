namespace LoginPetShop_v1.Veterinario
{
    partial class VeterinarioInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.BtnCrearFicha = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.panelLateralVeterinario = new System.Windows.Forms.Panel();
            this.panelTopVeterinario = new System.Windows.Forms.Panel();
            this.tBoxBusqueda = new System.Windows.Forms.TextBox();
            this.panelContenedorVeterinario = new System.Windows.Forms.Panel();
            this.btnLimpiarBusquedaFicha = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewFichas = new System.Windows.Forms.DataGridView();
            this.lblBuscador = new System.Windows.Forms.Label();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelLateralVeterinario.SuspendLayout();
            this.panelTopVeterinario.SuspendLayout();
            this.panelContenedorVeterinario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblVeterinario.Location = new System.Drawing.Point(17, 18);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(101, 24);
            this.lblVeterinario.TabIndex = 1;
            this.lblVeterinario.Text = "Veterinario";
            this.lblVeterinario.Click += new System.EventHandler(this.lblVeterinario_Click);
            // 
            // BtnCrearFicha
            // 
            this.BtnCrearFicha.Location = new System.Drawing.Point(21, 183);
            this.BtnCrearFicha.Name = "BtnCrearFicha";
            this.BtnCrearFicha.Size = new System.Drawing.Size(112, 73);
            this.BtnCrearFicha.TabIndex = 4;
            this.BtnCrearFicha.Text = "Crear ficha de mascota";
            this.BtnCrearFicha.UseVisualStyleBackColor = true;
            this.BtnCrearFicha.Click += new System.EventHandler(this.BtnCrearFicha_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(21, 312);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(112, 73);
            this.btnStock.TabIndex = 6;
            this.btnStock.Text = "Ver Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // panelLateralVeterinario
            // 
            this.panelLateralVeterinario.Controls.Add(this.panelTopVeterinario);
            this.panelLateralVeterinario.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralVeterinario.Location = new System.Drawing.Point(0, 0);
            this.panelLateralVeterinario.Name = "panelLateralVeterinario";
            this.panelLateralVeterinario.Size = new System.Drawing.Size(169, 453);
            this.panelLateralVeterinario.TabIndex = 8;
            // 
            // panelTopVeterinario
            // 
            this.panelTopVeterinario.Controls.Add(this.btnCerrarSesion);
            this.panelTopVeterinario.Controls.Add(this.btnEditarPerfil);
            this.panelTopVeterinario.Controls.Add(this.lblVeterinario);
            this.panelTopVeterinario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopVeterinario.Location = new System.Drawing.Point(0, 0);
            this.panelTopVeterinario.Name = "panelTopVeterinario";
            this.panelTopVeterinario.Size = new System.Drawing.Size(169, 142);
            this.panelTopVeterinario.TabIndex = 0;
            // 
            // tBoxBusqueda
            // 
            this.tBoxBusqueda.Location = new System.Drawing.Point(46, 45);
            this.tBoxBusqueda.Name = "tBoxBusqueda";
            this.tBoxBusqueda.Size = new System.Drawing.Size(464, 20);
            this.tBoxBusqueda.TabIndex = 2;
            this.tBoxBusqueda.TextChanged += new System.EventHandler(this.tBoxBusqueda_TextChanged);
            // 
            // panelContenedorVeterinario
            // 
            this.panelContenedorVeterinario.AutoScroll = true;
            this.panelContenedorVeterinario.Controls.Add(this.btnLimpiarBusquedaFicha);
            this.panelContenedorVeterinario.Controls.Add(this.btnBuscar);
            this.panelContenedorVeterinario.Controls.Add(this.dataGridViewFichas);
            this.panelContenedorVeterinario.Controls.Add(this.lblBuscador);
            this.panelContenedorVeterinario.Controls.Add(this.tBoxBusqueda);
            this.panelContenedorVeterinario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorVeterinario.Location = new System.Drawing.Point(169, 0);
            this.panelContenedorVeterinario.Name = "panelContenedorVeterinario";
            this.panelContenedorVeterinario.Size = new System.Drawing.Size(631, 453);
            this.panelContenedorVeterinario.TabIndex = 9;
            this.panelContenedorVeterinario.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorVeterinario_Paint);
            // 
            // btnLimpiarBusquedaFicha
            // 
            this.btnLimpiarBusquedaFicha.Location = new System.Drawing.Point(516, 75);
            this.btnLimpiarBusquedaFicha.Name = "btnLimpiarBusquedaFicha";
            this.btnLimpiarBusquedaFicha.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarBusquedaFicha.TabIndex = 8;
            this.btnLimpiarBusquedaFicha.Text = "Volver";
            this.btnLimpiarBusquedaFicha.UseVisualStyleBackColor = true;
            this.btnLimpiarBusquedaFicha.Click += new System.EventHandler(this.btnLimpiarBusquedaFicha_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(516, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewFichas
            // 
            this.dataGridViewFichas.AllowUserToAddRows = false;
            this.dataGridViewFichas.AllowUserToDeleteRows = false;
            this.dataGridViewFichas.AllowUserToResizeColumns = false;
            this.dataGridViewFichas.AllowUserToResizeRows = false;
            this.dataGridViewFichas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFichas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMascota,
            this.NombreMascota,
            this.Ver});
            this.dataGridViewFichas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFichas.Location = new System.Drawing.Point(117, 112);
            this.dataGridViewFichas.Name = "dataGridViewFichas";
            this.dataGridViewFichas.ReadOnly = true;
            this.dataGridViewFichas.Size = new System.Drawing.Size(344, 288);
            this.dataGridViewFichas.TabIndex = 6;
            this.dataGridViewFichas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFichas_CellClick);
            this.dataGridViewFichas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFichas_CellContentClick);
            // 
            // lblBuscador
            // 
            this.lblBuscador.AutoSize = true;
            this.lblBuscador.Location = new System.Drawing.Point(43, 29);
            this.lblBuscador.Name = "lblBuscador";
            this.lblBuscador.Size = new System.Drawing.Size(124, 13);
            this.lblBuscador.TabIndex = 5;
            this.lblBuscador.Text = "Buscar ficha de mascota";
            this.lblBuscador.Click += new System.EventHandler(this.lblBuscador_Click);
            // 
            // IdMascota
            // 
            this.IdMascota.HeaderText = "Id de mascota";
            this.IdMascota.Name = "IdMascota";
            this.IdMascota.ReadOnly = true;
            // 
            // NombreMascota
            // 
            this.NombreMascota.HeaderText = "Nombre de mascota";
            this.NombreMascota.Name = "NombreMascota";
            this.NombreMascota.ReadOnly = true;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "";
            this.Ver.Name = "Ver";
            this.Ver.ReadOnly = true;
            this.Ver.Text = "Ver";
            this.Ver.UseColumnTextForButtonValue = true;
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.Location = new System.Drawing.Point(21, 56);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(97, 23);
            this.btnEditarPerfil.TabIndex = 2;
            this.btnEditarPerfil.Text = "Editar perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = true;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(21, 95);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(97, 23);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // VeterinarioInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 453);
            this.Controls.Add(this.panelContenedorVeterinario);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.BtnCrearFicha);
            this.Controls.Add(this.panelLateralVeterinario);
            this.Name = "VeterinarioInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeterinarioInicio";
            this.Load += new System.EventHandler(this.VeterinarioInicio_Load);
            this.panelLateralVeterinario.ResumeLayout(false);
            this.panelTopVeterinario.ResumeLayout(false);
            this.panelTopVeterinario.PerformLayout();
            this.panelContenedorVeterinario.ResumeLayout(false);
            this.panelContenedorVeterinario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFichas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Button BtnCrearFicha;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Panel panelLateralVeterinario;
        private System.Windows.Forms.TextBox tBoxBusqueda;
        private System.Windows.Forms.Panel panelContenedorVeterinario;
        private System.Windows.Forms.Label lblBuscador;
        private System.Windows.Forms.Panel panelTopVeterinario;
        private System.Windows.Forms.DataGridView dataGridViewFichas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiarBusquedaFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMascota;
        private System.Windows.Forms.DataGridViewButtonColumn Ver;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnEditarPerfil;
    }
}