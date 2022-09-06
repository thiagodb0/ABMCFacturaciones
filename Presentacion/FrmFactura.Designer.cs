namespace ABMC_Facturacion
{
    partial class FrmFacturacion
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
            this.components = new System.ComponentModel.Container();
            this.DgvDetalle = new System.Windows.Forms.DataGridView();
            this.ClmnCod_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.CboArticulo = new System.Windows.Forms.ComboBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            this.Lbl_FormPag = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.CboFormaPago = new System.Windows.Forms.ComboBox();
            this.BtnProx = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.LblProxFact = new System.Windows.Forms.Label();
            this.LblFact = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDetalle
            // 
            this.DgvDetalle.AllowUserToAddRows = false;
            this.DgvDetalle.AllowUserToDeleteRows = false;
            this.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnCod_articulo,
            this.ClmnDescripcion,
            this.ClmnPrecio,
            this.ClmnAcciones});
            this.DgvDetalle.Location = new System.Drawing.Point(30, 246);
            this.DgvDetalle.Name = "DgvDetalle";
            this.DgvDetalle.ReadOnly = true;
            this.DgvDetalle.RowHeadersWidth = 51;
            this.DgvDetalle.RowTemplate.Height = 24;
            this.DgvDetalle.Size = new System.Drawing.Size(710, 150);
            this.DgvDetalle.TabIndex = 3;
            this.DgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClmnCod_articulo
            // 
            this.ClmnCod_articulo.HeaderText = "Codigo";
            this.ClmnCod_articulo.MinimumWidth = 6;
            this.ClmnCod_articulo.Name = "ClmnCod_articulo";
            this.ClmnCod_articulo.ReadOnly = true;
            this.ClmnCod_articulo.Visible = false;
            this.ClmnCod_articulo.Width = 125;
            // 
            // ClmnDescripcion
            // 
            this.ClmnDescripcion.HeaderText = "Descripcion";
            this.ClmnDescripcion.MinimumWidth = 6;
            this.ClmnDescripcion.Name = "ClmnDescripcion";
            this.ClmnDescripcion.ReadOnly = true;
            this.ClmnDescripcion.Width = 350;
            // 
            // ClmnPrecio
            // 
            this.ClmnPrecio.HeaderText = "Precio";
            this.ClmnPrecio.MinimumWidth = 6;
            this.ClmnPrecio.Name = "ClmnPrecio";
            this.ClmnPrecio.ReadOnly = true;
            this.ClmnPrecio.Width = 180;
            // 
            // ClmnAcciones
            // 
            this.ClmnAcciones.HeaderText = "Accion";
            this.ClmnAcciones.MinimumWidth = 6;
            this.ClmnAcciones.Name = "ClmnAcciones";
            this.ClmnAcciones.ReadOnly = true;
            this.ClmnAcciones.Width = 125;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(499, 217);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(75, 23);
            this.BtnCargar.TabIndex = 4;
            this.BtnCargar.Text = "Cargar";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // CboArticulo
            // 
            this.CboArticulo.FormattingEnabled = true;
            this.CboArticulo.Location = new System.Drawing.Point(35, 217);
            this.CboArticulo.Name = "CboArticulo";
            this.CboArticulo.Size = new System.Drawing.Size(275, 24);
            this.CboArticulo.TabIndex = 5;
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(336, 37);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(238, 22);
            this.DtpFecha.TabIndex = 6;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(214, 39);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(45, 16);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(214, 102);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(48, 16);
            this.LblCliente.TabIndex = 9;
            this.LblCliente.Text = "Cliente";
            // 
            // Lbl_FormPag
            // 
            this.Lbl_FormPag.AutoSize = true;
            this.Lbl_FormPag.Location = new System.Drawing.Point(214, 171);
            this.Lbl_FormPag.Name = "Lbl_FormPag";
            this.Lbl_FormPag.Size = new System.Drawing.Size(100, 16);
            this.Lbl_FormPag.TabIndex = 10;
            this.Lbl_FormPag.Text = "Forma de pago";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(336, 102);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(238, 22);
            this.TxtCliente.TabIndex = 11;
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Location = new System.Drawing.Point(336, 168);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(238, 24);
            this.CboFormaPago.TabIndex = 12;
            // 
            // BtnProx
            // 
            this.BtnProx.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProx.Location = new System.Drawing.Point(11, 23);
            this.BtnProx.Name = "BtnProx";
            this.BtnProx.Size = new System.Drawing.Size(130, 34);
            this.BtnProx.TabIndex = 13;
            this.BtnProx.Text = "Factura N°";
            this.BtnProx.UseVisualStyleBackColor = true;
            this.BtnProx.Click += new System.EventHandler(this.BtnProx_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(353, 219);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 22);
            this.TxtCantidad.TabIndex = 15;
            // 
            // LblProxFact
            // 
            this.LblProxFact.AutoSize = true;
            this.LblProxFact.Location = new System.Drawing.Point(149, 37);
            this.LblProxFact.Name = "LblProxFact";
            this.LblProxFact.Size = new System.Drawing.Size(0, 16);
            this.LblProxFact.TabIndex = 16;
            // 
            // LblFact
            // 
            this.LblFact.AutoSize = true;
            this.LblFact.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFact.Location = new System.Drawing.Point(148, 29);
            this.LblFact.Name = "LblFact";
            this.LblFact.Size = new System.Drawing.Size(20, 24);
            this.LblFact.TabIndex = 17;
            this.LblFact.Text = "0";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(414, 416);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.TxtSubtotal.TabIndex = 18;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubtotal.Location = new System.Drawing.Point(311, 414);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(97, 24);
            this.LblSubtotal.TabIndex = 19;
            this.LblSubtotal.Text = "Subtotal $";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(537, 414);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(69, 24);
            this.LblTotal.TabIndex = 21;
            this.LblTotal.Text = "Total $";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(640, 416);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 22);
            this.TxtTotal.TabIndex = 20;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(30, 415);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 22;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(137, 415);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar.TabIndex = 23;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.LblSubtotal);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.LblFact);
            this.Controls.Add(this.LblProxFact);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnProx);
            this.Controls.Add(this.CboFormaPago);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.Lbl_FormPag);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.CboArticulo);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.DgvDetalle);
            this.Name = "FrmFacturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DgvDetalle;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.ComboBox CboArticulo;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label Lbl_FormPag;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.ComboBox CboFormaPago;
        private System.Windows.Forms.Button BtnProx;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label LblProxFact;
        public System.Windows.Forms.Label LblFact;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnCod_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmnPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn ClmnAcciones;
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.Label LblSubtotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}

