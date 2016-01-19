using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht8
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1, luku2, luku3;
            Console.WriteLine("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());
            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                    Console.WriteLine("Suurin luku on " + luku1);
                else if (luku3 > luku1)
                    Console.WriteLine("Suurin luku on " + luku3);
                else
                    Console.WriteLine("Suurin luku on " + luku1);
            }
            else if (luku2 > luku3)
            {
                if (luku2 > luku1)
                    Console.WriteLine("Suurin luku on " + luku2);
                else if (luku1 > luku2)
                    Console.WriteLine("Suurin luku on " + luku1);
                else
                    Console.WriteLine("Suurin luku on " + luku2);
            }
            else if (luku3 > luku1)
            {
                if (luku3 > luku2)
                    Console.WriteLine("Suurin luku on " + luku3);
                else
                    Console.WriteLine("Suurin luku on " + luku3);
            }
        }
    }
}
