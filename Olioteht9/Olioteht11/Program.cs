using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht11
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            int luku2;
            Console.WriteLine("Anna luku ");
            luku = int.Parse(Console.ReadLine());
            luku2 = luku;
            for (int i = 0;i < luku;i++, luku2 = luku - i)
            {
                for (; luku2 <= luku;luku2++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
