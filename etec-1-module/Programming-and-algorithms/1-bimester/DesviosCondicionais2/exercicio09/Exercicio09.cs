using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    class Exercicio09
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sexo: ");
            string sx = Console.ReadLine();

            if (sx == "masculino")
            {
                Console.WriteLine("Idade: ");
                int id = int.Parse(Console.ReadLine());

                if (id >= 20 && id <= 25 && id <= 65)
                {
                    Console.WriteLine("classe social: ");
                    string cl = Console.ReadLine();

                    if (cl == "a" || cl == "b")
                    {
                        Console.WriteLine("Nivel superior (concluido ou nao): ");
                        string nv = Console.ReadLine();

                        if(nv == "concluido")
                        {
                            Console.WriteLine("Há quantos meses comprou o produto: ");
                            int ms = int.Parse(Console.ReadLine());

                            if(ms >=6 && ms <= 12)
                            {
                                Console.WriteLine("APTO");
                            }
                            else
                            {
                                Console.WriteLine("Fora da faixa pesquisada");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Fora da faixa pesquisada");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Fora da faixa pesquisada");
                    }
                }
                else
                {
                    Console.WriteLine("Fora da faixa pesquisada");
                }


            }
            Console.ReadKey();
        }
    }
}
