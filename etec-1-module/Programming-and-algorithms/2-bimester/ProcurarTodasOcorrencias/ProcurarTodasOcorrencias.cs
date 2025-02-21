using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurarTodasOcorrencias
{
    class ProcurarTodasOcorrencias
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

            Console.WriteLine("Digite um valor para procurar no array:");
            int valor = int.Parse(Console.ReadLine());

            List<int> posicoes = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    posicoes.Add(i);
                }
            }

            if (posicoes.Count > 0)
            {
                Console.WriteLine("Valor encontrado nas posições: " + string.Join(", ", posicoes));
            }
            else
            {
                Console.WriteLine("Valor não encontrado no array.");
            }
            Console.ReadKey();
        }
    }
}
