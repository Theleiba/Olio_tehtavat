using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olioteht13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbas = new int[5];
            int temp;
            int i = 0;
            int j = 1;
            Console.WriteLine("Syötä pisteet ");
            numbas[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä pisteet ");
            numbas[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä pisteet ");
            numbas[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä pisteet ");
            numbas[3] = int.Parse(Console.ReadLine());
            Console.WriteLine("Syötä pisteet ");
            numbas[4] = int.Parse(Console.ReadLine());
            for (int x = 0; x < 5 ; x++)
            {
                if (numbas[i] <= numbas[j])
                {
                    j++;
                }
                else
                {
                    temp = numbas[i];
                    numbas[i] = numbas[j];
                    numbas[j] = temp;
                    i++; j = i--; x--;
                }
                Console.WriteLine("Kierros: " + x);
                /*if (numbas[0] < numbas[1] && numbas[1] < numbas[2] && numbas[2] < numbas[3] && numbas[3] < numbas[4])
                {
                    x = true;
                }*/
            }
            /*for (int k = 0;k < 5;k++)
            {
                Console.WriteLine(numbas[k]);
            }*/
            Console.WriteLine(numbas[1] + numbas[2] + numbas[3]);
            int tama = -1;
            while (tama < 4)
            {
                tama++;
                Console.WriteLine(numbas[tama]);
            }
        }
    }
}
