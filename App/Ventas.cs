using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class Ventas
    {
        public class Venta
        {
            public int id { get; set; }
            public string cliente { get; set; }
            public string fecha { get; set; }
            public int cantidad { get; set; }
        }

        public static List<Venta> getListaVentas()
        {
            List<Venta> lista = new List<Venta>() 
            { 
                new Venta(){ id=1, cliente="raul", cantidad=20, fecha="12/05/2013"},
                new Venta(){ id=2, cliente="andres", cantidad=12, fecha="05/11/2013"},
                new Venta(){ id=3, cliente="pato", cantidad=50, fecha="22/02/2013"},
            };

            return lista;
        }


    }
}
