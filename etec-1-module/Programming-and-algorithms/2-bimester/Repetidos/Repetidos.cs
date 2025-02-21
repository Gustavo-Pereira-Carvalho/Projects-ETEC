using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetidos
{
    class Repetidos
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); // Números aleatórios de 1 a 100
            }

            Console.WriteLine("Array gerado:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Dictionary<int, int> repeticoes = new Dictionary<int, int>();

            foreach (var item in array)
            {
                if (repeticoes.ContainsKey(item))
                {
                    repeticoes[item]++;
                }
                else
                {
                    repeticoes[item] = 1;
                }
            }

            Console.WriteLine("Valores repetidos no array:");
            foreach (var kvp in repeticoes)
            {
                if (kvp.Value > 1)
                {
                    Console.WriteLine($"Valor {kvp.Key} se repete {kvp.Value} vezes.");
                }
            }
            Console.ReadKey();
        }
    }
}
