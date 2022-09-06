using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Facturacion
{
    internal class Articulo
    {

        public int cod_articulo { get; set; }
        public string descripcion { get; set; }
        public double precio_uni { get; set; }

        //Constructores

        public Articulo(int cod_articulo, string descripcion, double precio_uni)
        {
            this.cod_articulo = cod_articulo;
            this.descripcion = descripcion;
            this.precio_uni = precio_uni;
        } 

        public Articulo ()
        {
            this.cod_articulo = 0;
            this.descripcion = string.Empty;
            this.precio_uni = 0;
        }

        //Metodos

        public override string ToString()
        {
            return cod_articulo + " - " + descripcion;
        }
    }
}
