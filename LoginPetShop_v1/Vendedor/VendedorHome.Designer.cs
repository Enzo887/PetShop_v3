namespace LoginPetShop_v1.Vendedor
{
    partial class VendedorHome
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
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnGestionarStock = new System.Windows.Forms.Button();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.margenTop = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLateral.Controls.Add(this.btnGestionarStock);
            this.panelLateral.Controls.Add(this.btnRegistrarVenta);
            this.panelLateral.Controls.Add(this.margenTop);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 450);
            this.panelLateral.TabIndex = 1;
            // 
            // btnGestionarStock
            // 
            this.btnGestionarStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarStock.Location = new System.Drawing.Point(0, 147);
            this.btnGestionarStock.Name = "btnGestionarStock";
            this.btnGestionarStock.Size = new System.Drawing.Size(200, 47);
            this.btnGestionarStock.TabIndex = 2;
            this.btnGestionarStock.Text = "Gestionar Stock";
            this.btnGestionarStock.UseVisualStyleBackColor = true;
            this.btnGestionarStock.Click += new System.EventHandler(this.btnGestionarStock_Click);
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(0, 100);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(200, 47);
            this.btnRegistrarVenta.TabIndex = 1;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // margenTop
            // 
            this.margenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.margenTop.Location = new System.Drawing.Point(0, 0);
            this.margenTop.Name = "margenTop";
            this.margenTop.Size = new System.Drawing.Size(200, 100);
            this.margenTop.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 450);
            this.panelContenedor.TabIndex = 2;
            // 
            // VendedorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Name = "VendedorHome";
            this.Text = "VendedorHome";
            this.panelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnGestionarStock;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Panel margenTop;
        private System.Windows.Forms.Panel panelContenedor;
    }
}