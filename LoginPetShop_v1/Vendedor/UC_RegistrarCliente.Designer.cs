namespace LoginPetShop_v1.Vendedor
{
    partial class UC_RegistrarCliente
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
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblDniUsuario = new System.Windows.Forms.Label();
            this.tboxDniUsuario = new System.Windows.Forms.TextBox();
            this.lblAdministrarUsuarios = new System.Windows.Forms.Label();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxBuscarUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellidoUsuarioCrear = new System.Windows.Forms.Label();
            this.lblNombreUsuarioCrear = new System.Windows.Forms.Label();
            this.tboxTelefono = new System.Windows.Forms.TextBox();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.tboxApellidoUsuarioCrear = new System.Windows.Forms.TextBox();
            this.tboxNombreUsuarioCrear = new System.Windows.Forms.TextBox();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(422, 186);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarCliente.TabIndex = 36;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // lblDniUsuario
            // 
            this.lblDniUsuario.AutoSize = true;
            this.lblDniUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniUsuario.Location = new System.Drawing.Point(73, 104);
            this.lblDniUsuario.Name = "lblDniUsuario";
            this.lblDniUsuario.Size = new System.Drawing.Size(31, 17);
            this.lblDniUsuario.TabIndex = 35;
            this.lblDniUsuario.Text = "DNI";
            // 
            // tboxDniUsuario
            // 
            this.tboxDniUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxDniUsuario.Location = new System.Drawing.Point(73, 124);
            this.tboxDniUsuario.Name = "tboxDniUsuario";
            this.tboxDniUsuario.Size = new System.Drawing.Size(136, 23);
            this.tboxDniUsuario.TabIndex = 34;
            // 
            // lblAdministrarUsuarios
            // 
            this.lblAdministrarUsuarios.AutoSize = true;
            this.lblAdministrarUsuarios.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrarUsuarios.Location = new System.Drawing.Point(58, 11);
            this.lblAdministrarUsuarios.Name = "lblAdministrarUsuarios";
            this.lblAdministrarUsuarios.Size = new System.Drawing.Size(151, 19);
            this.lblAdministrarUsuarios.TabIndex = 33;
            this.lblAdministrarUsuarios.Text = "Registro de Cliente";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.Location = new System.Drawing.Point(70, 165);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(99, 17);
            this.lblBuscarCliente.TabIndex = 32;
            this.lblBuscarCliente.Text = "Buscar Cliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNombre,
            this.cApellido,
            this.DNI});
            this.dataGridView1.Location = new System.Drawing.Point(73, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 170);
            this.dataGridView1.TabIndex = 31;
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
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // tboxBuscarUsuario
            // 
            this.tboxBuscarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBuscarUsuario.Location = new System.Drawing.Point(73, 186);
            this.tboxBuscarUsuario.Name = "tboxBuscarUsuario";
            this.tboxBuscarUsuario.Size = new System.Drawing.Size(343, 23);
            this.tboxBuscarUsuario.TabIndex = 30;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(228, 104);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(62, 17);
            this.lblTelefono.TabIndex = 29;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(382, 49);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 17);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email";
            // 
            // lblApellidoUsuarioCrear
            // 
            this.lblApellidoUsuarioCrear.AutoSize = true;
            this.lblApellidoUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuarioCrear.Location = new System.Drawing.Point(228, 49);
            this.lblApellidoUsuarioCrear.Name = "lblApellidoUsuarioCrear";
            this.lblApellidoUsuarioCrear.Size = new System.Drawing.Size(61, 17);
            this.lblApellidoUsuarioCrear.TabIndex = 27;
            this.lblApellidoUsuarioCrear.Text = "Apellido";
            // 
            // lblNombreUsuarioCrear
            // 
            this.lblNombreUsuarioCrear.AutoSize = true;
            this.lblNombreUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuarioCrear.Location = new System.Drawing.Point(73, 50);
            this.lblNombreUsuarioCrear.Name = "lblNombreUsuarioCrear";
            this.lblNombreUsuarioCrear.Size = new System.Drawing.Size(61, 17);
            this.lblNombreUsuarioCrear.TabIndex = 26;
            this.lblNombreUsuarioCrear.Text = "Nombre";
            // 
            // tboxTelefono
            // 
            this.tboxTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTelefono.Location = new System.Drawing.Point(228, 124);
            this.tboxTelefono.Name = "tboxTelefono";
            this.tboxTelefono.Size = new System.Drawing.Size(136, 23);
            this.tboxTelefono.TabIndex = 25;
            // 
            // tboxEmail
            // 
            this.tboxEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEmail.Location = new System.Drawing.Point(385, 69);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(136, 23);
            this.tboxEmail.TabIndex = 24;
            // 
            // tboxApellidoUsuarioCrear
            // 
            this.tboxApellidoUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxApellidoUsuarioCrear.Location = new System.Drawing.Point(231, 69);
            this.tboxApellidoUsuarioCrear.Name = "tboxApellidoUsuarioCrear";
            this.tboxApellidoUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxApellidoUsuarioCrear.TabIndex = 23;
            // 
            // tboxNombreUsuarioCrear
            // 
            this.tboxNombreUsuarioCrear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNombreUsuarioCrear.Location = new System.Drawing.Point(73, 69);
            this.tboxNombreUsuarioCrear.Name = "tboxNombreUsuarioCrear";
            this.tboxNombreUsuarioCrear.Size = new System.Drawing.Size(136, 23);
            this.tboxNombreUsuarioCrear.TabIndex = 22;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUsuario.Location = new System.Drawing.Point(398, 391);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(119, 32);
            this.btnEliminarUsuario.TabIndex = 21;
            this.btnEliminarUsuario.Text = "Eliminar usuario";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarUsuario.Location = new System.Drawing.Point(258, 391);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(119, 32);
            this.btnEditarUsuario.TabIndex = 20;
            this.btnEditarUsuario.Text = "Editar usuario";
            this.btnEditarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.Location = new System.Drawing.Point(385, 119);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(136, 32);
            this.btnCrearUsuario.TabIndex = 19;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            // 
            // UC_RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.lblDniUsuario);
            this.Controls.Add(this.tboxDniUsuario);
            this.Controls.Add(this.lblAdministrarUsuarios);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tboxBuscarUsuario);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellidoUsuarioCrear);
            this.Controls.Add(this.lblNombreUsuarioCrear);
            this.Controls.Add(this.tboxTelefono);
            this.Controls.Add(this.tboxEmail);
            this.Controls.Add(this.tboxApellidoUsuarioCrear);
            this.Controls.Add(this.tboxNombreUsuarioCrear);
            this.Controls.Add(this.btnEliminarUsuario);
            this.Controls.Add(this.btnEditarUsuario);
            this.Controls.Add(this.btnCrearUsuario);
            this.Name = "UC_RegistrarCliente";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblDniUsuario;
        private System.Windows.Forms.TextBox tboxDniUsuario;
        private System.Windows.Forms.Label lblAdministrarUsuarios;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.TextBox tboxBuscarUsuario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellidoUsuarioCrear;
        private System.Windows.Forms.Label lblNombreUsuarioCrear;
        private System.Windows.Forms.TextBox tboxTelefono;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.TextBox tboxApellidoUsuarioCrear;
        private System.Windows.Forms.TextBox tboxNombreUsuarioCrear;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.Button btnCrearUsuario;
    }
}
