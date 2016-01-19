using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht7
{
    class Program
    {
        static void Main(string[] args)
        {
            int vuosi;
            Console.WriteLine("Anna vuosi: ");
            vuosi = int.Parse(Console.ReadLine());
            if (vuosi % 4 == 0)
            {
                if (vuosi % 100 == 0)
                {
                    if (vuosi % 400 == 0)
                        Console.WriteLine("Vuosi on karkausvuosi.");
                    else
                        Console.WriteLine("Vuosi ei ole karkausvuosi.");
                }
                else
                    Console.WriteLine("Vuosi on karkausvuosi.");
            }
            else
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
        }
    }
}
