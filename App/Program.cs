using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            int res = op.Sumar(10, 20);
            int res2 = op.Restar(100, 30);

            Console.WriteLine("Suma: {0} - Resta: {1}",res, res2);

            consulta("pato");
            Console.ReadKey();


        }

        public static bool consulta(string nombre)
        {
            bool result = false;

            var query = from v in Ventas.getListaVentas()
                        join p in Productos.getListaProductos() on v.id equals p.idVentas
                        where v.cliente == nombre
                        select p.grupo;

            foreach (var item in query)
            {
                Console.WriteLine("Artistas Comprados por Pato: {0}", item);
                if (item.Length > 0)
                {
                    result = true;
                }
            }

            return result;
 
        }


    }
}
