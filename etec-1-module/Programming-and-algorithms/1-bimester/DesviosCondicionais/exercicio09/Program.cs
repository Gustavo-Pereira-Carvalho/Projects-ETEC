using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o salário: ");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o prestação: ");
            double prestacao = double.Parse(Console.ReadLine());

            if(salario * 0.3 >= prestacao)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("reprovado");
            }
            Console.ReadKey();
        }
    }
}
