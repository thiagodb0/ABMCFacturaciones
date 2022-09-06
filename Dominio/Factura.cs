using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Facturacion
{
    internal class Factura
    {

        public int nro_factura { get; set; }
        public DateTime fecha { get; set; }
        public int forma_pago { get; set; }
        public string cliente { get; set; }

        public List<Detalle> Detalles { get; set; }

        public Factura(int nro_factura, DateTime fecha, int forma_pago, string cliente)
        {
            this.nro_factura = nro_factura;
            this.fecha = fecha;
            this.forma_pago = forma_pago;
            this.cliente = cliente;
        }

        public Factura()
        {
            this.nro_factura = 0;
            this.fecha = DateTime.Now;
            this.forma_pago = 0;
            this.cliente = string.Empty;
            Detalles = new List<Detalle>();
        }

        //Metodos

        public override string ToString()
        {
            return nro_factura + " - " + fecha + " " + cliente;
        }

        public void agregarDetalle( Detalle d)
        {
           Detalles.Add(d);
        }

        public double CalcularTotal()
        {
            double total = 0;

            foreach (Detalle detalle in Detalles)
            {
                total += detalle.calcularSubtotal();
            }

            return total;
        }

    }
}
