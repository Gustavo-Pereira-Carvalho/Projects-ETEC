using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurarPrimeiraOcorrencia
{
    class ProcurarPrimeiraOcorrencia
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
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

            int posicao = Array.IndexOf(array, valor);

            if (posicao != -1)
            {
                Console.WriteLine("Valor encontrado na posição: " + posicao);
            }
            else
            {
                Console.WriteLine("Valor não encontrado no array.");
            }
            Console.ReadKey();
        }
    }
}
