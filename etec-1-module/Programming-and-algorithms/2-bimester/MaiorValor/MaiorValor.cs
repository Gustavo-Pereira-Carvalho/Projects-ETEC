using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValor
{
    class MaiorValor
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 10];
            Random random = new Random();

            // Inicializar a matriz e definir valores iniciais para maior e menor
            matriz[0, 0] = random.Next(1, 101);
            int maiorValor = matriz[0, 0];
            int menorValor = matriz[0, 0];
            int linhaMaior = 0, colunaMaior = 0;
            int linhaMenor = 0, colunaMenor = 0;

            // Preenchendo a matriz e encontrando o maior e menor valor
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (!(i == 0 && j == 0))
                    {
                        matriz[i, j] = random.Next(1, 101);
                    }

                    if (matriz[i, j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                    if (matriz[i, j] < menorValor)
                    {
                        menorValor = matriz[i, j];
                        linhaMenor = i;
                        colunaMenor = j;
                    }
                }
            }

            // Exibindo a matriz
            Console.WriteLine("Matriz 10x10:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Exibindo o maior e menor valor e suas posições
            Console.WriteLine($"\nMaior valor: {maiorValor} na posição: Linha {linhaMaior + 1}, Coluna {colunaMaior + 1}");
            Console.WriteLine($"Menor valor: {menorValor} na posição: Linha {linhaMenor + 1}, Coluna {colunaMenor + 1}");
            Console.ReadKey();
        }
    }
}
