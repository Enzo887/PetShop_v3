namespace LoginPetShop_v1
{
    partial class formInicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tboxUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxClave = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panelContenedorLogin = new System.Windows.Forms.Panel();
            this.lblPetShopTitulo = new System.Windows.Forms.Label();
            this.chBoxMostrarContraseña = new System.Windows.Forms.CheckBox();
            this.panelContenedorLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tboxUsuario
            // 
            this.tboxUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tboxUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUsuario.Location = new System.Drawing.Point(82, 63);
            this.tboxUsuario.Name = "tboxUsuario";
            this.tboxUsuario.Size = new System.Drawing.Size(124, 23);
            this.tboxUsuario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxClave
            // 
            this.tboxClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tboxClave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxClave.Location = new System.Drawing.Point(82, 122);
            this.tboxClave.Name = "tboxClave";
            this.tboxClave.PasswordChar = '*';
            this.tboxClave.Size = new System.Drawing.Size(124, 23);
            this.tboxClave.TabIndex = 3;
            this.tboxClave.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.Location = new System.Drawing.Point(82, 184);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(124, 36);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(82, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 36);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panelContenedorLogin
            // 
            this.panelContenedorLogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContenedorLogin.Controls.Add(this.chBoxMostrarContraseña);
            this.panelContenedorLogin.Controls.Add(this.btnIniciarSesion);
            this.panelContenedorLogin.Controls.Add(this.btnCancelar);
            this.panelContenedorLogin.Controls.Add(this.label1);
            this.panelContenedorLogin.Controls.Add(this.tboxUsuario);
            this.panelContenedorLogin.Controls.Add(this.tboxClave);
            this.panelContenedorLogin.Controls.Add(this.label2);
            this.panelContenedorLogin.Location = new System.Drawing.Point(245, 79);
            this.panelContenedorLogin.Name = "panelContenedorLogin";
            this.panelContenedorLogin.Size = new System.Drawing.Size(284, 319);
            this.panelContenedorLogin.TabIndex = 6;
            // 
            // lblPetShopTitulo
            // 
            this.lblPetShopTitulo.AutoSize = true;
            this.lblPetShopTitulo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetShopTitulo.Location = new System.Drawing.Point(321, 18);
            this.lblPetShopTitulo.Name = "lblPetShopTitulo";
            this.lblPetShopTitulo.Size = new System.Drawing.Size(119, 32);
            this.lblPetShopTitulo.TabIndex = 7;
            this.lblPetShopTitulo.Text = "PetShop";
            // 
            // chBoxMostrarContraseña
            // 
            this.chBoxMostrarContraseña.AutoSize = true;
            this.chBoxMostrarContraseña.Location = new System.Drawing.Point(83, 151);
            this.chBoxMostrarContraseña.Name = "chBoxMostrarContraseña";
            this.chBoxMostrarContraseña.Size = new System.Drawing.Size(118, 17);
            this.chBoxMostrarContraseña.TabIndex = 66;
            this.chBoxMostrarContraseña.Text = "Mostrar Contraseña";
            this.chBoxMostrarContraseña.UseVisualStyleBackColor = true;
            this.chBoxMostrarContraseña.CheckedChanged += new System.EventHandler(this.chBoxMostrarContraseña_CheckedChanged);
            // 
            // formInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPetShopTitulo);
            this.Controls.Add(this.panelContenedorLogin);
            this.Name = "formInicio";
            this.Text = "Form1";
            this.panelContenedorLogin.ResumeLayout(false);
            this.panelContenedorLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxClave;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel panelContenedorLogin;
        private System.Windows.Forms.Label lblPetShopTitulo;
        private System.Windows.Forms.CheckBox chBoxMostrarContraseña;
    }
}

