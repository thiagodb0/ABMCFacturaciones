﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Carreras.Reportes
{
    public partial class FrmArticulosReport : Form
    {
        public FrmArticulosReport()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsArticulos._DsArticulos' Puede moverla o quitarla según sea necesario.
            this.dsArticulosTableAdapter.Fill(this.dsArticulos._DsArticulos);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
