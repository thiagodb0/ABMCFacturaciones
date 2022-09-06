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
            this.dtsFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DgvFacturas = new System.Windows.Forms.DataGridView();
            this.BtnBaja = new System.Windows.Forms.Button();
            this.BtnCancelar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtsFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvFacturas
            // 
            this.DgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFacturas.Location = new System.Drawing.Point(4, 13);
            this.DgvFacturas.Name = "DgvFacturas";
            this.DgvFacturas.RowHeadersWidth = 51;
            this.DgvFacturas.RowTemplate.Height = 24;
            this.DgvFacturas.Size = new System.Drawing.Size(792, 331);
            this.DgvFacturas.TabIndex = 0;
            this.DgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnBaja
            // 
            this.BtnBaja.Location = new System.Drawing.Point(353, 385);
            this.BtnBaja.Name = "BtnBaja";
            this.BtnBaja.Size = new System.Drawing.Size(141, 53);
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
            // FrmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar2);
            this.Controls.Add(this.BtnBaja);
            this.Controls.Add(this.DgvFacturas);
            this.Name = "FrmBaja";
            this.Text = "FrmBaja";
            this.Load += new System.EventHandler(this.FrmBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtsFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dtsFacturasBindingSource;
        private System.Windows.Forms.Button BtnBaja;
        private System.Windows.Forms.Button BtnCancelar2;
        public System.Windows.Forms.DataGridView DgvFacturas;
    }
}