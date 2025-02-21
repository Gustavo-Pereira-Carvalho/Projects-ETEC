using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palíndrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] letras = palavra.ToCharArray();

            string palavraInvertida = "";

            for (int i = letras.Length-1; i >= 0; i--)
            {
                palavraInvertida += letras[i];
            }
            if(palavraInvertida == palavra)
            {
                Console.WriteLine($"A palavra {palavra} é um palindrome");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} nao é um palindrome");
            }

            Console.ReadKey();


        }
    }
}
