using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ABMC_Facturacion
{
    public partial class FrmFacturacion : Form
    {


        DbHelper oBD;
        private Factura nueva;

        //Profe estuvo intentando resolverlo pero no logro encontrar porque no inserta los detalles e inserta 3 veces la factura
        // su ayuda me seria muy util, gracias. Aguardo su correccion


        public FrmFacturacion()
        {
            InitializeComponent();
            oBD = new DbHelper();
            nueva = new Factura();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtpFecha.Text = DateTime.Today.ToString();
            TxtCliente.Text = "Consumidor Final";
            CboFormaPago.SelectedValue = -1;
            CboArticulo.SelectedValue = -1;
            cargarCombo(CboArticulo, "consultar_articulos");
            cargarCombo(CboFormaPago, "SP_CONS_FORMAPAG");
        }

        //Metodos

        public void prox_factura()
        {
            try

            {

                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = @"Data Source=localhost;Initial Catalog=factura_prog1;Integrated Security=True";
                cnn.Open();
                SqlCommand cmd = new SqlCommand("prox_fact", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@next", SqlDbType.Int);
                param.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int next = Convert.ToInt32(param.Value);
                LblFact.Text = next.ToString();
                cnn.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Error de datos", "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }


        private void GuardarPresupuesto()
        {

            nueva.cliente = TxtCliente.Text;
            nueva.forma_pago = Convert.ToInt32(CboFormaPago.SelectedValue);
            nueva.fecha = Convert.ToDateTime(DtpFecha.Text);

            if (oBD.ConfirmarPresupuesto(nueva))
            {
                MessageBox.Show("Presupuesto registrado", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar el presupuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

    


        private void cargarCombo(ComboBox combo, string SP)
        {
            DataTable tabla = oBD.consultarBD(SP);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cargarGrid()
        {
            if (CboArticulo.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar un articulo", "Control",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (TxtCantidad.Text.Equals(string.Empty) || !int.TryParse(TxtCantidad.Text, out _))
            {
                MessageBox.Show("Debe ingresar un valor numerico!",
                "Control", MessageBoxButtons.OK,
                 MessageBoxIcon.Exclamation);
                return;

            }

            DataRowView item = (DataRowView)CboArticulo.SelectedItem;
            int cod_prod = Convert.ToInt32(item.Row.ItemArray[0]);
            string descripcion = item.Row.ItemArray[1].ToString();
            double precio = Convert.ToDouble(item.Row.ItemArray[2]);
            Articulo a = new Articulo(cod_prod, descripcion, precio);
            int cantidad = Convert.ToInt32(TxtCantidad.Text);
            Detalle d = new Detalle( a, cantidad);
            nueva.agregarDetalle(d);
            
            DgvDetalle.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1],
              item.Row.ItemArray[2]});
            TxtSubtotal.Text = Convert.ToString(d.calcularSubtotal());
            TxtTotal.Text = Convert.ToString(nueva.CalcularTotal());
            

         }


        
       


        //Metodos de evento

        private void BtnProx_Click(object sender, EventArgs e)
        {

            prox_factura();
      
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Lbl_NroFact_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            cargarGrid();
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (TxtCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un cliente!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (DgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GuardarPresupuesto();
        }
    }
}
