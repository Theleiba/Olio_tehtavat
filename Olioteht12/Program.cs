using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbas = new int[5];
            Console.WriteLine("Anna luku ");
            numbas[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku ");
            numbas[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku ");
            numbas[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku ");
            numbas[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna luku ");
            numbas[4] = int.Parse(Console.ReadLine());
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(numbas[i]);
            }
        }
    }
}
