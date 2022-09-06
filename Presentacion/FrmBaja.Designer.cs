namespace ABMC_Carreras.Presentacion
{
    partial class FrmBaja
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
            this.components = new System.ComponentModel.Container();
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            this.LblIndicacBaja = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.dtsFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsFacturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.AllowUserToAddRows = false;
            this.DgvFacturas.AllowUserToDeleteRows = false;
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(5, 62);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.ReadOnly = true;
            this.DgvFacturas.RowHeadersWidth = 51;
            this.DgvFacturas.RowTemplate.Height = 24;
            this.DgvFacturas.Size = new System.Drawing.Size(792, 331);
            this.DgvFacturas.TabIndex = 0;
            this.DgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(349, 399);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(134, 53);
            this.BtnBaja.TabIndex = 1;
            this.BtnBaja.Text = "Dar Baja";
            this.BtnBaja.UseVisualStyleBackColor = true;
            this.BtnBaja.Click += new System.EventHandler(this.BtnBaja_Click);
            // 
            // BtnCancelar2
            // 
            this.BtnCancelar2.Location = new System.Drawing.Point(703, 415);
            this.BtnCancelar2.Name = "BtnCancelar2";
            this.BtnCancelar2.Size = new System.Drawing.Size(75, 23);
            this.BtnCancelar2.TabIndex = 2;
            this.BtnCancelar2.Text = "Cancelar";
            this.BtnCancelar2.UseVisualStyleBackColor = true;
            // 
            // LblIndicacBaja
            // 
            this.LblIndicacBaja.AutoSize = true;
            this.LblIndicacBaja.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIndicacBaja.Location = new System.Drawing.Point(13, 13);
            this.LblIndicacBaja.Name = "LblIndicacBaja";
            this.LblIndicacBaja.Size = new System.Drawing.Size(539, 27);
            this.LblIndicacBaja.TabIndex = 3;
            this.LblIndicacBaja.Text = "Presione sobre el N° de factra que desea dar de baja";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = global::ABMC_Carreras.Properties.Resources.Diseño_sin_título;
            this.BtnActualizar.Location = new System.Drawing.Point(504, 405);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(48, 43);
            this.BtnActualizar.TabIndex = 4;
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // FrmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.LblIndicacBaja);
            this.Controls.Add(this.BtnCancelar2);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.DgvFacturas);
            this.Name = "FrmBaja";
            this.Text = "FrmBaja";
            this.Load += new System.EventHandler(this.FrmBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsFacturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dtsFacturasBindingSource;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnCancelar2;
        public System.Windows.Forms.DataGridView DgvFacturas;
        private System.Windows.Forms.Label LblIndicacBaja;
        private System.Windows.Forms.Button BtnActualizar;
    }
}