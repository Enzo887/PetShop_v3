namespace LoginPetShop_v1.Administracion
{
    partial class UC_EditarRol
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
            this.lblEditarRol = new System.Windows.Forms.Label();
            this.comboxSelectRolEditar = new System.Windows.Forms.ComboBox();
            this.checkListPermisos = new System.Windows.Forms.CheckedListBox();
            this.btnGuardarCambiosEditarRol = new System.Windows.Forms.Button();
            this.btnEliminarRol = new System.Windows.Forms.Button();
            this.btnSalirEditarRol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditarRol
            // 
            this.lblEditarRol.AutoSize = true;
            this.lblEditarRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarRol.Location = new System.Drawing.Point(12, 9);
            this.lblEditarRol.Name = "lblEditarRol";
            this.lblEditarRol.Size = new System.Drawing.Size(75, 19);
            this.lblEditarRol.TabIndex = 0;
            this.lblEditarRol.Text = "Editar rol";
            // 
            // comboxSelectRolEditar
            // 
            this.comboxSelectRolEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxSelectRolEditar.FormattingEnabled = true;
            this.comboxSelectRolEditar.Items.AddRange(new object[] {
            "Administrador",
            "Gerente",
            "Vendedor",
            "Veterinario"});
            this.comboxSelectRolEditar.Location = new System.Drawing.Point(16, 64);
            this.comboxSelectRolEditar.Name = "comboxSelectRolEditar";
            this.comboxSelectRolEditar.Size = new System.Drawing.Size(174, 25);
            this.comboxSelectRolEditar.TabIndex = 1;
            this.comboxSelectRolEditar.Text = "Seleccione rol a editar";
            // 
            // checkListPermisos
            // 
            this.checkListPermisos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkListPermisos.FormattingEnabled = true;
            this.checkListPermisos.Items.AddRange(new object[] {
            "Permiso 1",
            "Permiso 2",
            "Permiso 3",
            "Permiso 4",
            "Permiso 5",
            "Permiso 6",
            "Permiso 7",
            "Permiso 8",
            "Permiso 9 ",
            "Permiso 10"});
            this.checkListPermisos.Location = new System.Drawing.Point(272, 64);
            this.checkListPermisos.Name = "checkListPermisos";
            this.checkListPermisos.Size = new System.Drawing.Size(288, 304);
            this.checkListPermisos.TabIndex = 2;
            // 
            // btnGuardarCambiosEditarRol
            // 
            this.btnGuardarCambiosEditarRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCambiosEditarRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambiosEditarRol.Location = new System.Drawing.Point(179, 397);
            this.btnGuardarCambiosEditarRol.Name = "btnGuardarCambiosEditarRol";
            this.btnGuardarCambiosEditarRol.Size = new System.Drawing.Size(132, 38);
            this.btnGuardarCambiosEditarRol.TabIndex = 3;
            this.btnGuardarCambiosEditarRol.Text = "Guardar cambios";
            this.btnGuardarCambiosEditarRol.UseVisualStyleBackColor = false;
            // 
            // btnEliminarRol
            // 
            this.btnEliminarRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarRol.Location = new System.Drawing.Point(317, 397);
            this.btnEliminarRol.Name = "btnEliminarRol";
            this.btnEliminarRol.Size = new System.Drawing.Size(132, 38);
            this.btnEliminarRol.TabIndex = 4;
            this.btnEliminarRol.Text = "Eliminar rol";
            this.btnEliminarRol.UseVisualStyleBackColor = false;
            // 
            // btnSalirEditarRol
            // 
            this.btnSalirEditarRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSalirEditarRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirEditarRol.Location = new System.Drawing.Point(455, 397);
            this.btnSalirEditarRol.Name = "btnSalirEditarRol";
            this.btnSalirEditarRol.Size = new System.Drawing.Size(132, 38);
            this.btnSalirEditarRol.TabIndex = 5;
            this.btnSalirEditarRol.Text = "Salir";
            this.btnSalirEditarRol.UseVisualStyleBackColor = false;
            // 
            // UC_EditarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.btnSalirEditarRol);
            this.Controls.Add(this.btnEliminarRol);
            this.Controls.Add(this.btnGuardarCambiosEditarRol);
            this.Controls.Add(this.checkListPermisos);
            this.Controls.Add(this.comboxSelectRolEditar);
            this.Controls.Add(this.lblEditarRol);
            this.Name = "UC_EditarRol";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEditarRol;
        private System.Windows.Forms.ComboBox comboxSelectRolEditar;
        private System.Windows.Forms.CheckedListBox checkListPermisos;
        private System.Windows.Forms.Button btnGuardarCambiosEditarRol;
        private System.Windows.Forms.Button btnEliminarRol;
        private System.Windows.Forms.Button btnSalirEditarRol;
    }
}
