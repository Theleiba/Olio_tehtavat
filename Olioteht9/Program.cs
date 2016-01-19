using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht9
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;
            int summa = 0;
            while (luku != 0)
            {
                Console.WriteLine("Anna Luku ");
                luku = int.Parse(Console.ReadLine());
                summa = luku + summa;
            }
            Console.WriteLine("Lukujen summa on " + summa);
        }
    }
}
