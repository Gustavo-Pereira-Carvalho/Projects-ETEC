using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares
{
    class Pares
    {
        static void Main(string[] args)
        {
            int[] array = new int[40];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            Console.WriteLine("Array gerado:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            int contadorPares = 0;

            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    contadorPares++;
                }
            }

            Console.WriteLine("Número de valores pares no array: " + contadorPares);
            Console.ReadKey();
        }
    }
}
