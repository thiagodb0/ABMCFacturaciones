using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Carreras.Reportes.Facturas
{
    public partial class FrmFactReport : Form
    {
        public FrmFactReport()
        {
            InitializeComponent();
        }

        private void FrmFactReport_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        //Metodos


      
          

    }
}
