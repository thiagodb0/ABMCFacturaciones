using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Facturacion
{
    internal class Detalle
    {

        
        
        public Articulo articulo { get; set; }
        public int cantidad { get; set; }

        public Detalle( Articulo articulo, int cantidad)
        {
            this.articulo = articulo;
            this.cantidad = cantidad;
            
        }

        public Detalle()
        {
           
            this.articulo = null;
            this.cantidad = 0;
        }

        //Metodos

        

        public double calcularSubtotal()
        {
            return cantidad * articulo.precio_uni;
        }

    }
}
