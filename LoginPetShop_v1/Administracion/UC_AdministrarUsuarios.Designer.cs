namespace LoginPetShop_v1.Administracion
{
    partial class UC_AdministrarUsuarios
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.tboxNombreUsuarioCrear = new System.Windows.Forms.TextBox();
            this.tboxApellidoUsuarioCrear = new System.Windows.Forms.TextBox();
            this.tboxNUsuarioCrear = new System.Windows.Forms.TextBox();
            this.tboxContraseñaUsuarioCrear = new System.Windows.Forms.TextBox();
            this.lblNombreUsuarioCrear = new System.Windows.Forms.Label();
            this.lblApellidoUsuarioCrear = new System.Windows.Forms.Label();
            this.lblNUsuarioCrear = new System.Windows.Forms.Label();
            this.lblContraseñaUsuarioCrear = new System.Windows.Forms.Label();
            this.comboxSeleccionRolNuevoUsuario = new System.Windows.Forms.ComboBox();
            this.tboxBuscarUsuario = new System.Windows.Forms.TextBox();
            this.DGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEditarUsuario = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblVerUsuarios = new System.Windows.Forms.Label();
            this.lblAdministrarUsuarios = new System.Windows.Forms.Label();
            this.lblDniUsuario = new System.Windows.Forms.Label();
            this.tboxDniUsuario = new System.Windows.Forms.TextBox();
            this.btnBorrarBusqueda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(177, 330);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(115, 31);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // tboxNombreUsuarioCrear
            // 
            this.tboxNombreUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreUsuarioCrear.Location = new System.Drawing.Point(3, 82);
            this.tboxNombreUsuarioCrear.Name = "tboxNombreUsuarioCrear";
            this.tboxNombreUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxNombreUsuarioCrear.TabIndex = 3;
            // 
            // tboxApellidoUsuarioCrear
            // 
            this.tboxApellidoUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoUsuarioCrear.Location = new System.Drawing.Point(3, 133);
            this.tboxApellidoUsuarioCrear.Name = "tboxApellidoUsuarioCrear";
            this.tboxApellidoUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxApellidoUsuarioCrear.TabIndex = 4;
            // 
            // tboxNUsuarioCrear
            // 
            this.tboxNUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNUsuarioCrear.Location = new System.Drawing.Point(3, 186);
            this.tboxNUsuarioCrear.Name = "tboxNUsuarioCrear";
            this.tboxNUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxNUsuarioCrear.TabIndex = 5;
            // 
            // tboxContraseñaUsuarioCrear
            // 
            this.tboxContraseñaUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxContraseñaUsuarioCrear.Location = new System.Drawing.Point(3, 236);
            this.tboxContraseñaUsuarioCrear.Name = "tboxContraseñaUsuarioCrear";
            this.tboxContraseñaUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxContraseñaUsuarioCrear.TabIndex = 6;
            // 
            // lblNombreUsuarioCrear
            // 
            this.lblNombreUsuarioCrear.AutoSize = true;
            this.lblNombreUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioCrear.Location = new System.Drawing.Point(3, 63);
            this.lblNombreUsuarioCrear.Name = "lblNombreUsuarioCrear";
            this.lblNombreUsuarioCrear.Size = new System.Drawing.Size(61, 17);
            this.lblNombreUsuarioCrear.TabIndex = 7;
            this.lblNombreUsuarioCrear.Text = "Nombre";
            // 
            // lblApellidoUsuarioCrear
            // 
            this.lblApellidoUsuarioCrear.AutoSize = true;
            this.lblApellidoUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuarioCrear.Location = new System.Drawing.Point(3, 113);
            this.lblApellidoUsuarioCrear.Name = "lblApellidoUsuarioCrear";
            this.lblApellidoUsuarioCrear.Size = new System.Drawing.Size(61, 17);
            this.lblApellidoUsuarioCrear.TabIndex = 8;
            this.lblApellidoUsuarioCrear.Text = "Apellido";
            // 
            // lblNUsuarioCrear
            // 
            this.lblNUsuarioCrear.AutoSize = true;
            this.lblNUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNUsuarioCrear.Location = new System.Drawing.Point(3, 166);
            this.lblNUsuarioCrear.Name = "lblNUsuarioCrear";
            this.lblNUsuarioCrear.Size = new System.Drawing.Size(132, 17);
            this.lblNUsuarioCrear.TabIndex = 9;
            this.lblNUsuarioCrear.Text = "Nombre de usuario";
            // 
            // lblContraseñaUsuarioCrear
            // 
            this.lblContraseñaUsuarioCrear.AutoSize = true;
            this.lblContraseñaUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseñaUsuarioCrear.Location = new System.Drawing.Point(3, 216);
            this.lblContraseñaUsuarioCrear.Name = "lblContraseñaUsuarioCrear";
            this.lblContraseñaUsuarioCrear.Size = new System.Drawing.Size(84, 17);
            this.lblContraseñaUsuarioCrear.TabIndex = 10;
            this.lblContraseñaUsuarioCrear.Text = "Contraseña";
            // 
            // comboxSeleccionRolNuevoUsuario
            // 
            this.comboxSeleccionRolNuevoUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxSeleccionRolNuevoUsuario.FormattingEnabled = true;
            this.comboxSeleccionRolNuevoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Veterinario",
            "Vendedor"});
            this.comboxSeleccionRolNuevoUsuario.Location = new System.Drawing.Point(3, 334);
            this.comboxSeleccionRolNuevoUsuario.Name = "comboxSeleccionRolNuevoUsuario";
            this.comboxSeleccionRolNuevoUsuario.Size = new System.Drawing.Size(136, 25);
            this.comboxSeleccionRolNuevoUsuario.TabIndex = 11;
            this.comboxSeleccionRolNuevoUsuario.Text = "Rol a ocupar";
            // 
            // tboxBuscarUsuario
            // 
            this.tboxBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBuscarUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tboxBuscarUsuario.Location = new System.Drawing.Point(177, 63);
            this.tboxBuscarUsuario.Name = "tboxBuscarUsuario";
            this.tboxBuscarUsuario.Size = new System.Drawing.Size(369, 23);
            this.tboxBuscarUsuario.TabIndex = 12;
            this.tboxBuscarUsuario.Text = "\"Buscar por \"ID\" o \"Nombre de usuario\"";
            this.tboxBuscarUsuario.TextChanged += new System.EventHandler(this.tboxBuscarUsuario_TextChanged);
            this.tboxBuscarUsuario.Enter += new System.EventHandler(this.tBoxBuscarUsuario_Enter);
            this.tboxBuscarUsuario.Leave += new System.EventHandler(this.tBoxBuscarUsuario_Leave);
            // 
            // DGridViewUsuarios
            // 
            this.DGridViewUsuarios.AllowUserToAddRows = false;
            this.DGridViewUsuarios.AllowUserToDeleteRows = false;
            this.DGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGridViewUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cNUsuario,
            this.cNombre,
            this.cApellido,
            this.cRolUsuario,
            this.cEditarUsuario});
            this.DGridViewUsuarios.Location = new System.Drawing.Point(177, 108);
            this.DGridViewUsuarios.Name = "DGridViewUsuarios";
            this.DGridViewUsuarios.ReadOnly = true;
            this.DGridViewUsuarios.RowHeadersVisible = false;
            this.DGridViewUsuarios.Size = new System.Drawing.Size(405, 170);
            this.DGridViewUsuarios.TabIndex = 13;
            this.DGridViewUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridViewUsuarios_CellClick);
            this.DGridViewUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGridViewUsuarios_CellContentClick);
            // 
            // cID
            // 
            this.cID.HeaderText = "ID";
            this.cID.Name = "cID";
            this.cID.ReadOnly = true;
            this.cID.Width = 50;
            // 
            // cNUsuario
            // 
            this.cNUsuario.HeaderText = "Nombre Usuario";
            this.cNUsuario.Name = "cNUsuario";
            this.cNUsuario.ReadOnly = true;
            this.cNUsuario.Width = 75;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            this.cNombre.Width = 75;
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.Name = "cApellido";
            this.cApellido.ReadOnly = true;
            this.cApellido.Width = 75;
            // 
            // cRolUsuario
            // 
            this.cRolUsuario.HeaderText = "Rol";
            this.cRolUsuario.Name = "cRolUsuario";
            this.cRolUsuario.ReadOnly = true;
            this.cRolUsuario.Width = 75;
            // 
            // cEditarUsuario
            // 
            this.cEditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cEditarUsuario.HeaderText = "";
            this.cEditarUsuario.Name = "cEditarUsuario";
            this.cEditarUsuario.ReadOnly = true;
            this.cEditarUsuario.Text = "Editar";
            this.cEditarUsuario.UseColumnTextForButtonValue = true;
            this.cEditarUsuario.Width = 50;
            // 
            // lblVerUsuarios
            // 
            this.lblVerUsuarios.AutoSize = true;
            this.lblVerUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerUsuarios.Location = new System.Drawing.Point(174, 37);
            this.lblVerUsuarios.Name = "lblVerUsuarios";
            this.lblVerUsuarios.Size = new System.Drawing.Size(122, 17);
            this.lblVerUsuarios.TabIndex = 14;
            this.lblVerUsuarios.Text = "Visualizar usuarios";
            // 
            // lblAdministrarUsuarios
            // 
            this.lblAdministrarUsuarios.AutoSize = true;
            this.lblAdministrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarUsuarios.Location = new System.Drawing.Point(3, 10);
            this.lblAdministrarUsuarios.Name = "lblAdministrarUsuarios";
            this.lblAdministrarUsuarios.Size = new System.Drawing.Size(217, 19);
            this.lblAdministrarUsuarios.TabIndex = 15;
            this.lblAdministrarUsuarios.Text = "Administracion de usuarios";
            // 
            // lblDniUsuario
            // 
            this.lblDniUsuario.AutoSize = true;
            this.lblDniUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniUsuario.Location = new System.Drawing.Point(3, 270);
            this.lblDniUsuario.Name = "lblDniUsuario";
            this.lblDniUsuario.Size = new System.Drawing.Size(31, 17);
            this.lblDniUsuario.TabIndex = 17;
            this.lblDniUsuario.Text = "DNI";
            // 
            // tboxDniUsuario
            // 
            this.tboxDniUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDniUsuario.Location = new System.Drawing.Point(3, 290);
            this.tboxDniUsuario.Name = "tboxDniUsuario";
            this.tboxDniUsuario.Size = new System.Drawing.Size(136, 23);
            this.tboxDniUsuario.TabIndex = 16;
            // 
            // btnBorrarBusqueda
            // 
            this.btnBorrarBusqueda.Location = new System.Drawing.Point(552, 63);
            this.btnBorrarBusqueda.Name = "btnBorrarBusqueda";
            this.btnBorrarBusqueda.Size = new System.Drawing.Size(30, 23);
            this.btnBorrarBusqueda.TabIndex = 18;
            this.btnBorrarBusqueda.Text = "X";
            this.btnBorrarBusqueda.UseVisualStyleBackColor = true;
            this.btnBorrarBusqueda.Click += new System.EventHandler(this.btnBorrarBusqueda_Click);
            // 
            // UC_AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnBorrarBusqueda);
            this.Controls.Add(this.lblDniUsuario);
            this.Controls.Add(this.tboxDniUsuario);
            this.Controls.Add(this.lblAdministrarUsuarios);
            this.Controls.Add(this.lblVerUsuarios);
            this.Controls.Add(this.DGridViewUsuarios);
            this.Controls.Add(this.tboxBuscarUsuario);
            this.Controls.Add(this.comboxSeleccionRolNuevoUsuario);
            this.Controls.Add(this.lblContraseñaUsuarioCrear);
            this.Controls.Add(this.lblNUsuarioCrear);
            this.Controls.Add(this.lblApellidoUsuarioCrear);
            this.Controls.Add(this.lblNombreUsuarioCrear);
            this.Controls.Add(this.tboxContraseñaUsuarioCrear);
            this.Controls.Add(this.tboxNUsuarioCrear);
            this.Controls.Add(this.tboxApellidoUsuarioCrear);
            this.Controls.Add(this.tboxNombreUsuarioCrear);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "UC_AdministrarUsuarios";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.DGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.TextBox tboxNombreUsuarioCrear;
        private System.Windows.Forms.TextBox tboxApellidoUsuarioCrear;
        private System.Windows.Forms.TextBox tboxNUsuarioCrear;
        private System.Windows.Forms.TextBox tboxContraseñaUsuarioCrear;
        private System.Windows.Forms.Label lblNombreUsuarioCrear;
        private System.Windows.Forms.Label lblApellidoUsuarioCrear;
        private System.Windows.Forms.Label lblNUsuarioCrear;
        private System.Windows.Forms.Label lblContraseñaUsuarioCrear;
        private System.Windows.Forms.ComboBox comboxSeleccionRolNuevoUsuario;
        private System.Windows.Forms.TextBox tboxBuscarUsuario;
        private System.Windows.Forms.DataGridView DGridViewUsuarios;
        private System.Windows.Forms.Label lblVerUsuarios;
        private System.Windows.Forms.Label lblAdministrarUsuarios;
        private System.Windows.Forms.Label lblDniUsuario;
        private System.Windows.Forms.TextBox tboxDniUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRolUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn cEditarUsuario;
        private System.Windows.Forms.Button btnBorrarBusqueda;
    }
}
