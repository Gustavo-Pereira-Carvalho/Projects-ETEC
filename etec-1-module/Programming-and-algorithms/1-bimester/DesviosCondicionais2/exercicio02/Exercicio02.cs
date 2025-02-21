using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Exercicio02
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1º nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("2º nota: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("3º nota: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("4º nota: ");
            double n4 = double.Parse(Console.ReadLine());

            double md = (n1 + n2 + n3 + n4) / 4;

            if(md >= 5)
            {
                Console.Write("Aluno Aprovado - média " + md);
            }else if(md >= 3)
            {
                Console.Write("Aluno Recuperação - média " + md);
            }
            else
            {
                Console.WriteLine("Aluno Reprovado - média " + md);
            }
            Console.ReadKey();

        }
    }
}
