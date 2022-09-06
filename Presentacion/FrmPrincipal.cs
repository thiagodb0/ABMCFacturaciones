using ABMC_Carreras.Presentacion;
using ABMC_Carreras.Reportes;
using ABMC_Carreras.Reportes.Facturas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMC_Facturacion.Presentacion
{
    public partial class FrmPrincipal : Form
    {

        //Profe, necesitaria una solucion porque no pude encontrar la forma de acceder al valor seleccionado en un data grid para realizar la baja
        //Tambien sigo con el mismo problema a la hora de realizar una insercion,
        //ya que se insertan 3 maestros y ningun detalle, me serviria si usted encuentra el problema, muchas gracias
       


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturacion frm = new FrmFacturacion();
            frm.ShowDialog();
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulos frm = new FrmArticulos();
            frm.ShowDialog();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulosReport frm = new FrmArticulosReport();
            frm.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFactReport frm = new FrmFactReport();
            frm.ShowDialog();
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void darBajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBaja frm = new FrmBaja();
            frm.ShowDialog();
        }
    }
}
