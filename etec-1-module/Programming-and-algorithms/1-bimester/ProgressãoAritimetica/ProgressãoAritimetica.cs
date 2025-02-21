using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressãoAritimetica
{
    class ProgressãoAritimetica
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o termo: ");
            int termo = int.Parse(Console.ReadLine());

            Console.Write("Digite a razão: ");
            int razao = int.Parse(Console.ReadLine());

            Console.Write("Digite o limite: ");
            int limite = int.Parse(Console.ReadLine());

            Console.Write($"{termo}, ");
            for (int i = termo; i <= limite; i++)
            {
                int termoAtual = termo + (i - 1) * razao;
                Console.Write($"{termoAtual}, ");
            }
            Console.ReadKey();
      
        }
    }
}
