using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a receita:");
            float rc = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a despesa:");
            float ds = float.Parse(Console.ReadLine());

            if(rc > ds)
            {
                Console.WriteLine("A empresa esta com LUCRO:)");
            }else
            {
                Console.WriteLine("A empresa esta com PREjUIZO!!!");
            }
            Console.ReadLine();
        }
    }
}
