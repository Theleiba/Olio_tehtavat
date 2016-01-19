using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ika;
            Console.WriteLine("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine());
            if (ika < 18)
                Console.WriteLine("Alaikäinen");
            else if (ika >= 18 && ika <= 65)
                Console.WriteLine("Aikuinen");
            else if (ika > 65)
                Console.WriteLine("Seniori");
        }
    }
}
