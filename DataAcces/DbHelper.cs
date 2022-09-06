using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ABMC_Facturacion
{
    internal class DbHelper
    {

        SqlConnection cnn = new SqlConnection(@"Data Source=localhost;Initial Catalog=factura_prog1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader lector;

        private void conectar()
        {
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;

        }

        private void desconectar()
        {
            cnn.Close();
        }

        public DataTable consultarBD(string nombreSp)
        {
            DataTable tabla = new DataTable();

            conectar();
            cmd.CommandText = nombreSp;
            tabla.Load(cmd.ExecuteReader());
            desconectar();
            return tabla;
        }

        public void enviarSentencia(string sqlQuery)
        {
            conectar();
            cmd.CommandText = sqlQuery;
            cmd.ExecuteNonQuery();
            desconectar();
        }


        public bool ConfirmarPresupuesto(Factura oFactura)
        {
            bool ok = true;

            SqlCommand cmd = new SqlCommand();
            SqlTransaction trs = null;

            try
            {
                cnn.Open();
                trs = cnn.BeginTransaction();
                cmd.Transaction = trs;
                cmd.Connection = cnn;
                cmd.CommandText = "SP_INSERTAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@forma_pago", oFactura.forma_pago);
                cmd.Parameters.AddWithValue("@cliente", oFactura.cliente);
                cmd.Parameters.AddWithValue("@total", oFactura.CalcularTotal());

                //parámetro de salida:
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@presupuesto_nro";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int presupuestoNro = (int)pOut.Value;

                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (Detalle item in oFactura.Detalles)
                {
                    cmdDetalle = new SqlCommand();
                    cmdDetalle.Transaction = trs;
                    cmdDetalle.Connection = cnn;
                    cmdDetalle.CommandText = "insertar_detalle";
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_factura", presupuestoNro);
                    cmdDetalle.Parameters.AddWithValue("@cod_articulo", item.articulo.cod_articulo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", item.cantidad);
                    cmd.ExecuteNonQuery();


                    detalleNro++;
                }

                trs.Commit();
                return ok;

            }
                catch (Exception)
            {
                trs.Rollback();
                ok = false;
            }
            finally
            {
                if (cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return ok;
        }

       
        public void darBaja(int nro)
        {
            cmd.CommandText = "sp_dar_baja";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nro_fact",nro);
            cmd.ExecuteNonQuery();


        }



    }

    }
    

