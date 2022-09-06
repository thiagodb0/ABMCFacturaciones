namespace ABMC_Facturacion.Presentacion
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darBajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articuloToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // articuloToolStripMenuItem
            // 
            this.articuloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.articuloToolStripMenuItem.Name = "articuloToolStripMenuItem";
            this.articuloToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.articuloToolStripMenuItem.Text = "Articulo";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.cargarToolStripMenuItem.Text = "Cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.consultarToolStripMenuItem1,
            this.cambiosToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
            this.consultarToolStripMenuItem1.Text = "Consultar";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darBajaToolStripMenuItem,
            this.modificaToolStripMenuItem});
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            // 
            // darBajaToolStripMenuItem
            // 
            this.darBajaToolStripMenuItem.Name = "darBajaToolStripMenuItem";
            this.darBajaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darBajaToolStripMenuItem.Text = "Dar Baja";
            this.darBajaToolStripMenuItem.Click += new System.EventHandler(this.darBajaToolStripMenuItem_Click);
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificaToolStripMenuItem.Text = "Modificar";
            this.modificaToolStripMenuItem.Click += new System.EventHandler(this.modificaToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articuloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darBajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
    }
}