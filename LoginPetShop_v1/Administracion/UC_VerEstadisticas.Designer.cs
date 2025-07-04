namespace LoginPetShop_v1.Administracion
{
    partial class UC_VerEstadisticas
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
            this.lblVistaGeneralEstadisticas = new System.Windows.Forms.Label();
            this.panelProductosMasVendidos = new System.Windows.Forms.Panel();
            this.dGridViewProductosMasVendidos = new System.Windows.Forms.DataGridView();
            this.lblProductosMasVendidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dGridViewVentasGenerales = new System.Windows.Forms.DataGridView();
            this.lblVentasGenerales = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGridViewStockDisponible = new System.Windows.Forms.DataGridView();
            this.lblStock = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGridViewClientesFrecuentes = new System.Windows.Forms.DataGridView();
            this.lblClientesFrecuentes = new System.Windows.Forms.Label();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelProductosMasVendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductosMasVendidos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVentasGenerales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewStockDisponible)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewClientesFrecuentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVistaGeneralEstadisticas
            // 
            this.lblVistaGeneralEstadisticas.AutoSize = true;
            this.lblVistaGeneralEstadisticas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaGeneralEstadisticas.Location = new System.Drawing.Point(29, 32);
            this.lblVistaGeneralEstadisticas.Name = "lblVistaGeneralEstadisticas";
            this.lblVistaGeneralEstadisticas.Size = new System.Drawing.Size(110, 19);
            this.lblVistaGeneralEstadisticas.TabIndex = 0;
            this.lblVistaGeneralEstadisticas.Text = "Vista general";
            // 
            // panelProductosMasVendidos
            // 
            this.panelProductosMasVendidos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelProductosMasVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductosMasVendidos.Controls.Add(this.dGridViewProductosMasVendidos);
            this.panelProductosMasVendidos.Controls.Add(this.lblProductosMasVendidos);
            this.panelProductosMasVendidos.Location = new System.Drawing.Point(318, 85);
            this.panelProductosMasVendidos.Name = "panelProductosMasVendidos";
            this.panelProductosMasVendidos.Size = new System.Drawing.Size(282, 146);
            this.panelProductosMasVendidos.TabIndex = 5;
            // 
            // dGridViewProductosMasVendidos
            // 
            this.dGridViewProductosMasVendidos.AllowUserToAddRows = false;
            this.dGridViewProductosMasVendidos.AllowUserToDeleteRows = false;
            this.dGridViewProductosMasVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewProductosMasVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Cantidad,
            this.Nombre});
            this.dGridViewProductosMasVendidos.Location = new System.Drawing.Point(4, 14);
            this.dGridViewProductosMasVendidos.Name = "dGridViewProductosMasVendidos";
            this.dGridViewProductosMasVendidos.ReadOnly = true;
            this.dGridViewProductosMasVendidos.RowHeadersVisible = false;
            this.dGridViewProductosMasVendidos.Size = new System.Drawing.Size(273, 127);
            this.dGridViewProductosMasVendidos.TabIndex = 1;
            this.dGridViewProductosMasVendidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGridViewProductosMasVendidos_CellContentClick);
            // 
            // lblProductosMasVendidos
            // 
            this.lblProductosMasVendidos.AutoSize = true;
            this.lblProductosMasVendidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductosMasVendidos.Location = new System.Drawing.Point(67, -1);
            this.lblProductosMasVendidos.Name = "lblProductosMasVendidos";
            this.lblProductosMasVendidos.Size = new System.Drawing.Size(167, 17);
            this.lblProductosMasVendidos.TabIndex = 0;
            this.lblProductosMasVendidos.Text = "Productos mas vendidos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dGridViewVentasGenerales);
            this.panel1.Controls.Add(this.lblVentasGenerales);
            this.panel1.Location = new System.Drawing.Point(8, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 146);
            this.panel1.TabIndex = 8;
            // 
            // dGridViewVentasGenerales
            // 
            this.dGridViewVentasGenerales.AllowUserToAddRows = false;
            this.dGridViewVentasGenerales.AllowUserToDeleteRows = false;
            this.dGridViewVentasGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewVentasGenerales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VentaID,
            this.Fecha,
            this.PrecioTotal});
            this.dGridViewVentasGenerales.Location = new System.Drawing.Point(4, 14);
            this.dGridViewVentasGenerales.Name = "dGridViewVentasGenerales";
            this.dGridViewVentasGenerales.ReadOnly = true;
            this.dGridViewVentasGenerales.RowHeadersVisible = false;
            this.dGridViewVentasGenerales.Size = new System.Drawing.Size(273, 127);
            this.dGridViewVentasGenerales.TabIndex = 1;
            // 
            // lblVentasGenerales
            // 
            this.lblVentasGenerales.AutoSize = true;
            this.lblVentasGenerales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentasGenerales.Location = new System.Drawing.Point(67, -1);
            this.lblVentasGenerales.Name = "lblVentasGenerales";
            this.lblVentasGenerales.Size = new System.Drawing.Size(118, 17);
            this.lblVentasGenerales.TabIndex = 0;
            this.lblVentasGenerales.Text = "Ventas generales";
            this.lblVentasGenerales.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dGridViewStockDisponible);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Location = new System.Drawing.Point(318, 277);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 146);
            this.panel2.TabIndex = 9;
            // 
            // dGridViewStockDisponible
            // 
            this.dGridViewStockDisponible.AllowUserToAddRows = false;
            this.dGridViewStockDisponible.AllowUserToDeleteRows = false;
            this.dGridViewStockDisponible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewStockDisponible.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.NombreProducto,
            this.CantidadProducto});
            this.dGridViewStockDisponible.Location = new System.Drawing.Point(4, 14);
            this.dGridViewStockDisponible.Name = "dGridViewStockDisponible";
            this.dGridViewStockDisponible.ReadOnly = true;
            this.dGridViewStockDisponible.RowHeadersVisible = false;
            this.dGridViewStockDisponible.Size = new System.Drawing.Size(273, 127);
            this.dGridViewStockDisponible.TabIndex = 1;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(67, -1);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(113, 17);
            this.lblStock.TabIndex = 0;
            this.lblStock.Text = "Stock disponible";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dGridViewClientesFrecuentes);
            this.panel3.Controls.Add(this.lblClientesFrecuentes);
            this.panel3.Location = new System.Drawing.Point(8, 277);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 146);
            this.panel3.TabIndex = 6;
            // 
            // dGridViewClientesFrecuentes
            // 
            this.dGridViewClientesFrecuentes.AllowUserToAddRows = false;
            this.dGridViewClientesFrecuentes.AllowUserToDeleteRows = false;
            this.dGridViewClientesFrecuentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGridViewClientesFrecuentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DNI,
            this.NombreCliente,
            this.ApellidoCliente});
            this.dGridViewClientesFrecuentes.Location = new System.Drawing.Point(4, 14);
            this.dGridViewClientesFrecuentes.Name = "dGridViewClientesFrecuentes";
            this.dGridViewClientesFrecuentes.ReadOnly = true;
            this.dGridViewClientesFrecuentes.RowHeadersVisible = false;
            this.dGridViewClientesFrecuentes.Size = new System.Drawing.Size(273, 127);
            this.dGridViewClientesFrecuentes.TabIndex = 1;
            // 
            // lblClientesFrecuentes
            // 
            this.lblClientesFrecuentes.AutoSize = true;
            this.lblClientesFrecuentes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesFrecuentes.Location = new System.Drawing.Point(67, -1);
            this.lblClientesFrecuentes.Name = "lblClientesFrecuentes";
            this.lblClientesFrecuentes.Size = new System.Drawing.Size(129, 17);
            this.lblClientesFrecuentes.TabIndex = 0;
            this.lblClientesFrecuentes.Text = "Clientes frecuentes";
            this.lblClientesFrecuentes.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.Frozen = true;
            this.IdProducto.HeaderText = "Id Producto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Width = 80;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad Vendida";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 110;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 70;
            // 
            // NombreCliente
            // 
            this.NombreCliente.DataPropertyName = "NombreCliente";
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.DataPropertyName = "ApellidoCliente";
            this.ApellidoCliente.HeaderText = "Apellido";
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            // 
            // VentaID
            // 
            this.VentaID.DataPropertyName = "VentaID";
            this.VentaID.HeaderText = "ID Venta";
            this.VentaID.Name = "VentaID";
            this.VentaID.ReadOnly = true;
            this.VentaID.Width = 70;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha de Venta";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.DataPropertyName = "PrecioTotal";
            this.PrecioTotal.HeaderText = "Monto Total";
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "Id Producto";
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 70;
            // 
            // NombreProducto
            // 
            this.NombreProducto.DataPropertyName = "NombreProducto";
            this.NombreProducto.HeaderText = "Nombre";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // CantidadProducto
            // 
            this.CantidadProducto.DataPropertyName = "CantidadProducto";
            this.CantidadProducto.HeaderText = "Stock Actual";
            this.CantidadProducto.Name = "CantidadProducto";
            this.CantidadProducto.ReadOnly = true;
            this.CantidadProducto.Width = 80;
            // 
            // UC_VerEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelProductosMasVendidos);
            this.Controls.Add(this.lblVistaGeneralEstadisticas);
            this.Name = "UC_VerEstadisticas";
            this.Size = new System.Drawing.Size(600, 450);
            this.panelProductosMasVendidos.ResumeLayout(false);
            this.panelProductosMasVendidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewProductosMasVendidos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewVentasGenerales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewStockDisponible)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGridViewClientesFrecuentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVistaGeneralEstadisticas;
        private System.Windows.Forms.Panel panelProductosMasVendidos;
        private System.Windows.Forms.Label lblProductosMasVendidos;
        private System.Windows.Forms.DataGridView dGridViewProductosMasVendidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGridViewVentasGenerales;
        private System.Windows.Forms.Label lblVentasGenerales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGridViewStockDisponible;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dGridViewClientesFrecuentes;
        private System.Windows.Forms.Label lblClientesFrecuentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn VentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadProducto;
    }
}
