using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            int res = op.Sumar(10, 20);
            int res2 = op.Restar(100, 30);

            Console.WriteLine("Suma: {0} - Resta: {1}",res, res2);
            Console.ReadKey();

        }
    }
}
