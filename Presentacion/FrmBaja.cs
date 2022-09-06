using ABMC_Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ABMC_Carreras.Presentacion
{
    public partial class FrmBaja : Form
    {
        DbHelper oBD;
        public FrmBaja()
        {
            InitializeComponent();
            oBD = new DbHelper();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FrmBaja_Load(object sender, EventArgs e)
        {
            DataTable tabla = oBD.consultarBD("sp_cons_fact");
            DgvFacturas.DataSource = tabla;
        }

        private void BtnBaja_Click(object sender, EventArgs e)
        {

            //oBD.darBaja(Convert.ToInt32(DgvFacturas.Rows[0]));
           
        }

        
    }
}
