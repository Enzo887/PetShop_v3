namespace LoginPetShop_v1.Administracion
{
    partial class UC_ConfigurarAlertas
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
            this.tboxEscribirNombreAlerta = new System.Windows.Forms.TextBox();
            this.lblNombreAlerta = new System.Windows.Forms.Label();
            this.btnCrearAlerta = new System.Windows.Forms.Button();
            this.pickerFechaAlerta = new System.Windows.Forms.DateTimePicker();
            this.lblProgramarAlertas = new System.Windows.Forms.Label();
            this.checkListAsignarRolAlerta = new System.Windows.Forms.CheckedListBox();
            this.lblAsignarAlertaRol = new System.Windows.Forms.Label();
            this.btnEditarAlerta = new System.Windows.Forms.Button();
            this.btnEliminarAlerta = new System.Windows.Forms.Button();
            this.lblConfigAlertasTitulo = new System.Windows.Forms.Label();
            this.gridHistorialAlertas = new System.Windows.Forms.DataGridView();
            this.lblHistorialAlertas = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Nombre_alerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_alerta_programada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol_asignado_alerta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorialAlertas)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxEscribirNombreAlerta
            // 
            this.tboxEscribirNombreAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEscribirNombreAlerta.Location = new System.Drawing.Point(31, 60);
            this.tboxEscribirNombreAlerta.Name = "tboxEscribirNombreAlerta";
            this.tboxEscribirNombreAlerta.Size = new System.Drawing.Size(199, 23);
            this.tboxEscribirNombreAlerta.TabIndex = 0;
            // 
            // lblNombreAlerta
            // 
            this.lblNombreAlerta.AutoSize = true;
            this.lblNombreAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAlerta.Location = new System.Drawing.Point(28, 40);
            this.lblNombreAlerta.Name = "lblNombreAlerta";
            this.lblNombreAlerta.Size = new System.Drawing.Size(202, 17);
            this.lblNombreAlerta.TabIndex = 1;
            this.lblNombreAlerta.Text = "Escriba el nombre de la alerta";
            // 
            // btnCrearAlerta
            // 
            this.btnCrearAlerta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAlerta.Location = new System.Drawing.Point(460, 340);
            this.btnCrearAlerta.Name = "btnCrearAlerta";
            this.btnCrearAlerta.Size = new System.Drawing.Size(114, 32);
            this.btnCrearAlerta.TabIndex = 2;
            this.btnCrearAlerta.Text = "Crear alerta";
            this.btnCrearAlerta.UseVisualStyleBackColor = false;
            // 
            // pickerFechaAlerta
            // 
            this.pickerFechaAlerta.CalendarFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerFechaAlerta.Location = new System.Drawing.Point(31, 118);
            this.pickerFechaAlerta.Name = "pickerFechaAlerta";
            this.pickerFechaAlerta.Size = new System.Drawing.Size(199, 20);
            this.pickerFechaAlerta.TabIndex = 3;
            // 
            // lblProgramarAlertas
            // 
            this.lblProgramarAlertas.AutoSize = true;
            this.lblProgramarAlertas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramarAlertas.Location = new System.Drawing.Point(28, 98);
            this.lblProgramarAlertas.Name = "lblProgramarAlertas";
            this.lblProgramarAlertas.Size = new System.Drawing.Size(206, 17);
            this.lblProgramarAlertas.TabIndex = 4;
            this.lblProgramarAlertas.Text = "Seleccione fecha programada";
            // 
            // checkListAsignarRolAlerta
            // 
            this.checkListAsignarRolAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListAsignarRolAlerta.FormattingEnabled = true;
            this.checkListAsignarRolAlerta.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor",
            "Veterinario"});
            this.checkListAsignarRolAlerta.Location = new System.Drawing.Point(375, 60);
            this.checkListAsignarRolAlerta.Name = "checkListAsignarRolAlerta";
            this.checkListAsignarRolAlerta.Size = new System.Drawing.Size(199, 76);
            this.checkListAsignarRolAlerta.TabIndex = 5;
            // 
            // lblAsignarAlertaRol
            // 
            this.lblAsignarAlertaRol.AutoSize = true;
            this.lblAsignarAlertaRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignarAlertaRol.Location = new System.Drawing.Point(372, 40);
            this.lblAsignarAlertaRol.Name = "lblAsignarAlertaRol";
            this.lblAsignarAlertaRol.Size = new System.Drawing.Size(149, 17);
            this.lblAsignarAlertaRol.TabIndex = 6;
            this.lblAsignarAlertaRol.Text = "Asignar alerta a rol/es";
            // 
            // btnEditarAlerta
            // 
            this.btnEditarAlerta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAlerta.Location = new System.Drawing.Point(460, 259);
            this.btnEditarAlerta.Name = "btnEditarAlerta";
            this.btnEditarAlerta.Size = new System.Drawing.Size(114, 32);
            this.btnEditarAlerta.TabIndex = 7;
            this.btnEditarAlerta.Text = "Editar alerta";
            this.btnEditarAlerta.UseVisualStyleBackColor = false;
            // 
            // btnEliminarAlerta
            // 
            this.btnEliminarAlerta.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAlerta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlerta.Location = new System.Drawing.Point(460, 297);
            this.btnEliminarAlerta.Name = "btnEliminarAlerta";
            this.btnEliminarAlerta.Size = new System.Drawing.Size(114, 32);
            this.btnEliminarAlerta.TabIndex = 8;
            this.btnEliminarAlerta.Text = "Eliminar alerta";
            this.btnEliminarAlerta.UseVisualStyleBackColor = false;
            // 
            // lblConfigAlertasTitulo
            // 
            this.lblConfigAlertasTitulo.AutoSize = true;
            this.lblConfigAlertasTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigAlertasTitulo.Location = new System.Drawing.Point(3, 10);
            this.lblConfigAlertasTitulo.Name = "lblConfigAlertasTitulo";
            this.lblConfigAlertasTitulo.Size = new System.Drawing.Size(200, 19);
            this.lblConfigAlertasTitulo.TabIndex = 9;
            this.lblConfigAlertasTitulo.Text = "Configuracion de alertas";
            // 
            // gridHistorialAlertas
            // 
            this.gridHistorialAlertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistorialAlertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_alerta,
            this.fecha_alerta_programada,
            this.rol_asignado_alerta});
            this.gridHistorialAlertas.Location = new System.Drawing.Point(31, 249);
            this.gridHistorialAlertas.Name = "gridHistorialAlertas";
            this.gridHistorialAlertas.Size = new System.Drawing.Size(345, 150);
            this.gridHistorialAlertas.TabIndex = 10;
            // 
            // lblHistorialAlertas
            // 
            this.lblHistorialAlertas.AutoSize = true;
            this.lblHistorialAlertas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorialAlertas.Location = new System.Drawing.Point(151, 200);
            this.lblHistorialAlertas.Name = "lblHistorialAlertas";
            this.lblHistorialAlertas.Size = new System.Drawing.Size(126, 17);
            this.lblHistorialAlertas.TabIndex = 11;
            this.lblHistorialAlertas.Text = "Historial de alertas";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(31, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 23);
            this.textBox1.TabIndex = 12;
            // 
            // Nombre_alerta
            // 
            this.Nombre_alerta.HeaderText = "Nombre alerta";
            this.Nombre_alerta.Name = "Nombre_alerta";
            // 
            // fecha_alerta_programada
            // 
            this.fecha_alerta_programada.HeaderText = "Fecha programada";
            this.fecha_alerta_programada.Name = "fecha_alerta_programada";
            // 
            // rol_asignado_alerta
            // 
            this.rol_asignado_alerta.HeaderText = "Rol/es asignado/s";
            this.rol_asignado_alerta.Name = "rol_asignado_alerta";
            // 
            // UC_ConfigurarAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHistorialAlertas);
            this.Controls.Add(this.gridHistorialAlertas);
            this.Controls.Add(this.lblConfigAlertasTitulo);
            this.Controls.Add(this.btnEliminarAlerta);
            this.Controls.Add(this.btnEditarAlerta);
            this.Controls.Add(this.lblAsignarAlertaRol);
            this.Controls.Add(this.checkListAsignarRolAlerta);
            this.Controls.Add(this.lblProgramarAlertas);
            this.Controls.Add(this.pickerFechaAlerta);
            this.Controls.Add(this.btnCrearAlerta);
            this.Controls.Add(this.lblNombreAlerta);
            this.Controls.Add(this.tboxEscribirNombreAlerta);
            this.Name = "UC_ConfigurarAlertas";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.gridHistorialAlertas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxEscribirNombreAlerta;
        private System.Windows.Forms.Label lblNombreAlerta;
        private System.Windows.Forms.Button btnCrearAlerta;
        private System.Windows.Forms.DateTimePicker pickerFechaAlerta;
        private System.Windows.Forms.Label lblProgramarAlertas;
        private System.Windows.Forms.CheckedListBox checkListAsignarRolAlerta;
        private System.Windows.Forms.Label lblAsignarAlertaRol;
        private System.Windows.Forms.Button btnEditarAlerta;
        private System.Windows.Forms.Button btnEliminarAlerta;
        private System.Windows.Forms.Label lblConfigAlertasTitulo;
        private System.Windows.Forms.DataGridView gridHistorialAlertas;
        private System.Windows.Forms.Label lblHistorialAlertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_alerta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_alerta_programada;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol_asignado_alerta;
        private System.Windows.Forms.TextBox textBox1;
    }
}
