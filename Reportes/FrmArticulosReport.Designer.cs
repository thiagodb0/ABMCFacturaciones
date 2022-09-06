namespace ABMC_Carreras.Reportes
{
    partial class FrmArticulosReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsArticulos = new ABMC_Carreras.Reportes.DsArticulos();
            this.dsArticulosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dsArticulosTableAdapter = new ABMC_Carreras.Reportes.DsArticulosTableAdapters.DsArticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TblArticulos";
            reportDataSource1.Value = this.dsArticulosBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ABMC_Carreras.Reportes.RptArticulos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(942, 538);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dsArticulosBindingSource
            // 
            this.dsArticulosBindingSource.DataSource = this.dsArticulos;
            this.dsArticulosBindingSource.Position = 0;
            // 
            // dsArticulos
            // 
            this.dsArticulos.DataSetName = "DsArticulos";
            this.dsArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dsArticulosBindingSource1
            // 
            this.dsArticulosBindingSource1.DataMember = "DsArticulos";
            this.dsArticulosBindingSource1.DataSource = this.dsArticulosBindingSource;
            // 
            // dsArticulosTableAdapter
            // 
            this.dsArticulosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmArticulosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 538);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmArticulosReport";
            this.Text = "FrmArticulos";
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsArticulosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dsArticulosBindingSource;
        private DsArticulos dsArticulos;
        private System.Windows.Forms.BindingSource dsArticulosBindingSource1;
        private DsArticulosTableAdapters.DsArticulosTableAdapter dsArticulosTableAdapter;
    }
}