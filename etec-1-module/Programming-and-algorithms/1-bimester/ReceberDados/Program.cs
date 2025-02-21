using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceberDados
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe seu nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu gênero");
            char genero = char.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua altura ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Você concluiu o ensino médio? (true / false)");
            bool ensinoMédio = bool.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + nome + "\nIdade: " + idade + " anos\nSexo: " + genero + "\nAltura: " + altura + "\nEnsino Médio Concluído: " + ensinoMédio);
            Console.ReadKey();
        }
    }
}
