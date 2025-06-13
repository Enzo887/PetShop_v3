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
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRolUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVerUsuarios = new System.Windows.Forms.Label();
            this.lblAdministrarUsuarios = new System.Windows.Forms.Label();
            this.lblDniUsuario = new System.Windows.Forms.Label();
            this.tboxDniUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(322, 403);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(126, 32);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(193, 403);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(126, 32);
            this.btnEditarUsuario.TabIndex = 1;
            this.btnEditarUsuario.Text = "Editar usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(454, 403);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(126, 32);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
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
            this.tboxBuscarUsuario.Location = new System.Drawing.Point(153, 187);
            this.tboxBuscarUsuario.Name = "tboxBuscarUsuario";
            this.tboxBuscarUsuario.Size = new System.Drawing.Size(444, 23);
            this.tboxBuscarUsuario.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApellido,
            this.cNUsuario,
            this.cRolUsuario});
            this.dataGridView1.Location = new System.Drawing.Point(153, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 170);
            this.dataGridView1.TabIndex = 13;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "Nombre";
            this.cNombre.Name = "cNombre";
            // 
            // cApellido
            // 
            this.cApellido.HeaderText = "Apellido";
            this.cApellido.Name = "cApellido";
            // 
            // cNUsuario
            // 
            this.cNUsuario.HeaderText = "Nombre Usuario";
            this.cNUsuario.Name = "cNUsuario";
            // 
            // cRolUsuario
            // 
            this.cRolUsuario.HeaderText = "Rol";
            this.cRolUsuario.Name = "cRolUsuario";
            // 
            // lblVerUsuarios
            // 
            this.lblVerUsuarios.AutoSize = true;
            this.lblVerUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerUsuarios.Location = new System.Drawing.Point(150, 166);
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
            // UC_AdministrarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.lblDniUsuario);
            this.Controls.Add(this.tboxDniUsuario);
            this.Controls.Add(this.lblAdministrarUsuarios);
            this.Controls.Add(this.lblVerUsuarios);
            this.Controls.Add(this.dataGridView1);
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
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "UC_AdministrarUsuarios";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRolUsuario;
        private System.Windows.Forms.Label lblVerUsuarios;
        private System.Windows.Forms.Label lblAdministrarUsuarios;
        private System.Windows.Forms.Label lblDniUsuario;
        private System.Windows.Forms.TextBox tboxDniUsuario;
    }
}
