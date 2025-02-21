using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int[,] Tabuleiro = new int[10, 10];
            int menor = 100, maior = 0;
            string posicaoMenor = ""; string posicaoMaior = "";
            Console.WriteLine("  |  0 |  1 |  2 |  3 |  4 |  5 |  6 |  7 |  8 |  9 |");
            Console.WriteLine("  ---------------------------------------------------");
            for (int x = 0; x < 10; x++)
            {
                Console.Write(x + " | ");
                for (int y = 0; y < 10; y++)
                {
                    Tabuleiro[x, y] = gerador.Next(10, 100);
                    Console.Write(Tabuleiro[x, y] + " | ");
                    if (Tabuleiro[x, y] > maior)
                    {
                        maior = Tabuleiro[x, y];
                        posicaoMaior = x + "," + y;
                    }
                    if (Tabuleiro[x, y] < menor)
                    {
                        menor = Tabuleiro[x, y];
                        posicaoMenor = x + "," + y;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("  ---------------------------------------------------");
            }
            Console.WriteLine("Menor valor encontrado foi " + menor + " na posição " + posicaoMenor);
            Console.WriteLine("Maior valor encontrado foi " + maior + " na posição " + posicaoMaior);
            Console.ReadKey();
        }
    }
}
