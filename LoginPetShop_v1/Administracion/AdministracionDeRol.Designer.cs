namespace LoginPetShop_v1.Administracion
{
    partial class AdministracionDeRol
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
            this.btnAñadirRol = new System.Windows.Forms.Button();
            this.lblEdicionDeRol = new System.Windows.Forms.Label();
            this.lblPermisosTit = new System.Windows.Forms.Label();
            this.btnEditarRol = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblCrearRol = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAñadirRol
            // 
            this.btnAñadirRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAñadirRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirRol.Location = new System.Drawing.Point(315, 405);
            this.btnAñadirRol.Name = "btnAñadirRol";
            this.btnAñadirRol.Size = new System.Drawing.Size(114, 29);
            this.btnAñadirRol.TabIndex = 14;
            this.btnAñadirRol.Text = "Crear Rol";
            this.btnAñadirRol.UseVisualStyleBackColor = false;
            // 
            // lblEdicionDeRol
            // 
            this.lblEdicionDeRol.AutoSize = true;
            this.lblEdicionDeRol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdicionDeRol.Location = new System.Drawing.Point(192, 50);
            this.lblEdicionDeRol.Name = "lblEdicionDeRol";
            this.lblEdicionDeRol.Size = new System.Drawing.Size(190, 19);
            this.lblEdicionDeRol.TabIndex = 8;
            this.lblEdicionDeRol.Text = "Administracion de roles";
            // 
            // lblPermisosTit
            // 
            this.lblPermisosTit.AutoSize = true;
            this.lblPermisosTit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisosTit.Location = new System.Drawing.Point(15, 210);
            this.lblPermisosTit.Name = "lblPermisosTit";
            this.lblPermisosTit.Size = new System.Drawing.Size(63, 16);
            this.lblPermisosTit.TabIndex = 16;
            this.lblPermisosTit.Text = "Permisos";
            // 
            // btnEditarRol
            // 
            this.btnEditarRol.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarRol.Location = new System.Drawing.Point(459, 405);
            this.btnEditarRol.Name = "btnEditarRol";
            this.btnEditarRol.Size = new System.Drawing.Size(114, 29);
            this.btnEditarRol.TabIndex = 17;
            this.btnEditarRol.Text = "Editar Rol";
            this.btnEditarRol.UseVisualStyleBackColor = false;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
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
            this.checkedListBox1.Location = new System.Drawing.Point(19, 232);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(198, 202);
            this.checkedListBox1.TabIndex = 18;
            // 
            // lblCrearRol
            // 
            this.lblCrearRol.AutoSize = true;
            this.lblCrearRol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrearRol.Location = new System.Drawing.Point(15, 117);
            this.lblCrearRol.Name = "lblCrearRol";
            this.lblCrearRol.Size = new System.Drawing.Size(164, 16);
            this.lblCrearRol.TabIndex = 19;
            this.lblCrearRol.Text = "Asigne un nombre al rol";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 20;
            // 
            // AdministracionDeRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCrearRol);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.btnEditarRol);
            this.Controls.Add(this.lblPermisosTit);
            this.Controls.Add(this.btnAñadirRol);
            this.Controls.Add(this.lblEdicionDeRol);
            this.Name = "AdministracionDeRol";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAñadirRol;
        private System.Windows.Forms.Label lblEdicionDeRol;
        private System.Windows.Forms.Label lblPermisosTit;
        private System.Windows.Forms.Button btnEditarRol;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblCrearRol;
        private System.Windows.Forms.TextBox textBox1;
    }
}
