using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int[,] tabuleiro = new int[8, 8];

            for(int x = 0; x<8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    tabuleiro[x, y] = gerador.Next(1, 10);
                    Console.Write($"|{tabuleiro[x, y]}|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
