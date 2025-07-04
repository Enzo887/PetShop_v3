namespace LoginPetShop_v1.Administracion
{
    partial class AdminInicio
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
            this.panelLateralAdmin = new System.Windows.Forms.Panel();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.panelTopAdmin = new System.Windows.Forms.Panel();
            this.lblAdminTitulo = new System.Windows.Forms.Label();
            this.panelContenedorAdmin = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEditarPerfil = new System.Windows.Forms.Button();
            this.panelLateralAdmin.SuspendLayout();
            this.panelTopAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateralAdmin
            // 
            this.panelLateralAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateralAdmin.Controls.Add(this.btnGestionarUsuarios);
            this.panelLateralAdmin.Controls.Add(this.btnVerEstadisticas);
            this.panelLateralAdmin.Controls.Add(this.panelTopAdmin);
            this.panelLateralAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLateralAdmin.Name = "panelLateralAdmin";
            this.panelLateralAdmin.Size = new System.Drawing.Size(200, 450);
            this.panelLateralAdmin.TabIndex = 0;
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.White;
            this.btnGestionarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 186);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(200, 65);
            this.btnGestionarUsuarios.TabIndex = 4;
            this.btnGestionarUsuarios.Text = "Administrar usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.BackColor = System.Drawing.Color.White;
            this.btnVerEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstadisticas.Location = new System.Drawing.Point(0, 121);
            this.btnVerEstadisticas.Name = "btnVerEstadisticas";
            this.btnVerEstadisticas.Size = new System.Drawing.Size(200, 65);
            this.btnVerEstadisticas.TabIndex = 3;
            this.btnVerEstadisticas.Text = "Ver Estadisticas";
            this.btnVerEstadisticas.UseVisualStyleBackColor = false;
            this.btnVerEstadisticas.Click += new System.EventHandler(this.btnVerEstadisticas_Click);
            // 
            // panelTopAdmin
            // 
            this.panelTopAdmin.Controls.Add(this.btnCerrarSesion);
            this.panelTopAdmin.Controls.Add(this.btnEditarPerfil);
            this.panelTopAdmin.Controls.Add(this.lblAdminTitulo);
            this.panelTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelTopAdmin.Name = "panelTopAdmin";
            this.panelTopAdmin.Size = new System.Drawing.Size(200, 121);
            this.panelTopAdmin.TabIndex = 0;
            // 
            // lblAdminTitulo
            // 
            this.lblAdminTitulo.AutoSize = true;
            this.lblAdminTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitulo.Location = new System.Drawing.Point(3, 9);
            this.lblAdminTitulo.Name = "lblAdminTitulo";
            this.lblAdminTitulo.Size = new System.Drawing.Size(118, 19);
            this.lblAdminTitulo.TabIndex = 0;
            this.lblAdminTitulo.Text = "Administrador";
            // 
            // panelContenedorAdmin
            // 
            this.panelContenedorAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContenedorAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorAdmin.Location = new System.Drawing.Point(200, 0);
            this.panelContenedorAdmin.Name = "panelContenedorAdmin";
            this.panelContenedorAdmin.Size = new System.Drawing.Size(600, 450);
            this.panelContenedorAdmin.TabIndex = 1;
            this.panelContenedorAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorAdmin_Paint);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSesion.Location = new System.Drawing.Point(7, 84);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(97, 23);
            this.btnCerrarSesion.TabIndex = 5;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnEditarPerfil
            // 
            this.btnEditarPerfil.BackColor = System.Drawing.Color.White;
            this.btnEditarPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarPerfil.Location = new System.Drawing.Point(7, 45);
            this.btnEditarPerfil.Name = "btnEditarPerfil";
            this.btnEditarPerfil.Size = new System.Drawing.Size(97, 23);
            this.btnEditarPerfil.TabIndex = 4;
            this.btnEditarPerfil.Text = "Editar perfil";
            this.btnEditarPerfil.UseVisualStyleBackColor = false;
            this.btnEditarPerfil.Click += new System.EventHandler(this.btnEditarPerfil_Click);
            // 
            // AdminInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorAdmin);
            this.Controls.Add(this.panelLateralAdmin);
            this.Name = "AdminInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInicio";
            this.panelLateralAdmin.ResumeLayout(false);
            this.panelTopAdmin.ResumeLayout(false);
            this.panelTopAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateralAdmin;
        private System.Windows.Forms.Panel panelContenedorAdmin;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.Panel panelTopAdmin;
        private System.Windows.Forms.Label lblAdminTitulo;
        private System.Windows.Forms.Button btnGestionarUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnEditarPerfil;
    }
}