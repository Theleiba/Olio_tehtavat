using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht3
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            int summa;
            int karvo;
            Console.WriteLine("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());
            summa = luku1 + luku2 + luku3;
            karvo = summa / 3;
            Console.WriteLine("Lukujen summa on: " + summa + " ja keskiarvo on: " + karvo);
        }
    }
}
