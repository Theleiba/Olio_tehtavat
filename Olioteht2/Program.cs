using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.WriteLine("Anna pistemäärä");
            luku = int.Parse(Console.ReadLine());
            if (luku == 0 || luku == 1)
                Console.WriteLine("Numerosi on 0.");
            else if (luku == 2 || luku == 3)
                Console.WriteLine("Numerosi on 1.");
            else if (luku == 4 || luku == 5)
                Console.WriteLine("Numerosi on 2.");
            else if (luku == 6 || luku == 7)
                Console.WriteLine("Numerosi on 3.");
            else if (luku == 8 || luku == 9)
                Console.WriteLine("Numerosi on 4.");
            else if (luku == 10 || luku == 12)
                Console.WriteLine("Numerosi on 5.");
            else
                Console.WriteLine("Antamasi pistemäärä ei ole soveltuva.");
        }
    }
}
