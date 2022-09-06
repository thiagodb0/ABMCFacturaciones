using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMC_Facturacion
{
    internal class Forma_pago
    {

        private int id_forma { get; set; }
        private string descripcion { get; set; }

        //Constructores

        public Forma_pago (int id_forma, string descripcion)
        {
            this.id_forma = id_forma;
            this.descripcion = descripcion;
        }

        public Forma_pago()
        {
            this.id_forma = 0;
            this.descripcion = string.Empty;
        }

        //Metodos


        public override string ToString()
        {
            return descripcion;
        }

    }
}
