using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    class Piramide
    {
        static void Main(string[] args)
        {
            int altura = 5;

            for (int i = 1; i <= altura; i++)
            {
                for (int j = 0; j < altura - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < (2 * i - 1); k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
