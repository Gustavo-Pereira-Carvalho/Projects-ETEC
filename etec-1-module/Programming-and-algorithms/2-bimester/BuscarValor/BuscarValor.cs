using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarValor
{
    class BuscarValor
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[20, 20];
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            Console.WriteLine("Matriz 20x20:");
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nInforme um valor para buscar na matriz:");
            int valor = int.Parse(Console.ReadLine());
            bool encontrado = false;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (matriz[i, j] == valor)
                    {
                        Console.WriteLine($"Valor {valor} encontrado na posição: Linha {i + 1}, Coluna {j + 1}");
                        encontrado = true;
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"Valor {valor} não encontrado na matriz.");
            }
            Console.ReadKey();
        }
    }
}
