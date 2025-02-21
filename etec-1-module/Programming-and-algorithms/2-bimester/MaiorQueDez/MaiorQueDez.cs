using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorQueDez
{
    class MaiorQueDez
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[6, 6];
            Random random = new Random();
            int countMaiorQueDez = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                    if (matriz[i, j] > 10)
                    {
                        countMaiorQueDez += 1;
                    }
                }
            }

            Console.WriteLine("Matriz 6x6:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nNúmero de valores maiores que 10: {countMaiorQueDez}");
            Console.ReadKey();
        }
    }
}
