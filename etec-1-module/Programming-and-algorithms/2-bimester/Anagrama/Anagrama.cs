using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrama
{
    class Anagrama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira palavra:");
            string palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palavra:");
            string palavra2 = Console.ReadLine();

            if(palavra1.Length != palavra2.Length)
            {
                Console.WriteLine($"as palavras {palavra1} e {palavra2} nao são anagramas");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                char[] letras1 = palavra1.ToLower().ToCharArray();
                char[] letras2 = palavra2.ToLower().ToCharArray();

                Array.Sort(letras1);
                Array.Sort(letras2);

                for (int i = 0; i < letras1.Length; i++)
                {
                    if (letras1[i] != letras2[i])
                    {
                        Console.WriteLine($"as palavras {palavra1} e {palavra2} nao são anagramas");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                   
                }
                Console.WriteLine($"as palavras {palavra1} e {palavra2} são anagramas");
                Console.ReadKey();
                Environment.Exit(0);
            }
            

        }
    }
}
