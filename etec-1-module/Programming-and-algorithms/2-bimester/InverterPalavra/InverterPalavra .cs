using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterPalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();
            char[] letras = palavra.ToCharArray();

            string palavraInvertida = "";

            for(int i = letras.Length - 1; i>= 0; i--)
            {
                palavraInvertida += letras[i];
            }
            Console.WriteLine($"O inverso de: {palavra} é {palavraInvertida}");

            Console.ReadKey();
        }
    }
}
