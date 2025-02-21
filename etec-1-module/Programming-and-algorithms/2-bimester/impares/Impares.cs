using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impares
{
    class Impares
    {
        static void Main(string[] args)
        {
            int[] impares = new int[10];
            Random gerador = new Random();

            for (int i = 0; i < impares.Length;)
            {
                int n = gerador.Next(1, 10000);
                if (n % 2 == 1)
                {
                    impares[i] = n;

                    Console.WriteLine("impares [" + i + "]" + n);
                    i++;
                }


            }
            Console.ReadKey();


        }
    }
}