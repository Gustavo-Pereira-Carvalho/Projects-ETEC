using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Diagonal
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[8, 8];
            Random random = new Random();
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                    if (i == j)
                    {
                        somaDiagonalPrincipal += matriz[i, j];
                    }
                    if (i + j == 7)
                    {
                        somaDiagonalSecundaria += matriz[i, j];
                    }
                }
            }

            Console.WriteLine("Matriz 8x8:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nSoma da Diagonal Principal: {somaDiagonalPrincipal}");
            Console.WriteLine($"Soma da Diagonal Secundária: {somaDiagonalSecundaria}");
            Console.ReadKey();
        }
    }
}
