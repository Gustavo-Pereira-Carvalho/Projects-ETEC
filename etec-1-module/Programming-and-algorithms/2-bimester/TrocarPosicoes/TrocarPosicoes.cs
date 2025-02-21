using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocarPosicoes
{
    class TrocarPosicoes
    {
        static void Main(string[] args)
        {
            int[] array = new int[16];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            Console.WriteLine("Array original:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 8; i++)
            {
                int temp = array[i];
                array[i] = array[8 + i];
                array[8 + i] = temp;
            }

            Console.WriteLine("Array após troca de posições:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
