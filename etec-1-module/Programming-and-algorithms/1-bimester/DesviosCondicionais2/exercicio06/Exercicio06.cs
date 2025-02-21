using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    class Exercicio06
    {
        static void Main(string[] args)
        {
            Console.WriteLine("valor do ingresso: ");
            double ventrada = double.Parse(Console.ReadLine());
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Estudadante? (sim ou nao): ");
            string estudante = Console.ReadLine();

            double entrada =  ventrada / 2;

            if(idade <= 12 || idade >= 65 || estudante == "sim")
            {
                Console.WriteLine("O valor do ingresso é R$ " + entrada);
            }
            else
            {
                Console.WriteLine("O valor do ingresso é R$" + ventrada);
            }
            Console.ReadKey();


        }
    }
}
