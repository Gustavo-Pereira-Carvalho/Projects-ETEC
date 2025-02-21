using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio11
{
    class Exercicio11
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quiz de par ideal");
            Console.WriteLine("Escolha umas das opções");
           
            Console.WriteLine("Escolha uma das estações do ano: ");    
            Console.WriteLine("1- primavera / 2- verão / 3- outono / 4- inverno");
            int est = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Escolha uma das opções de tipo de viagem: ");
            Console.WriteLine("1- cidade / 2- campo  / 3- praia  / 4- radical / 5-cruzeiro / 6- resort");
            int vg = int.Parse(Console.ReadLine());
         

            Console.WriteLine("Qual genero você prefere");
            Console.WriteLine("f, m");
            string gn = Console.ReadLine();


            int soma = est + vg;
            if (soma == 2 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: João");
            }
            if (soma == 3 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Felipe");
            }
            if(soma == 4 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Jonas");
            }
            if (soma == 5 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Pedro");
            }
            if(soma == 6 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Vitor");
            }
            if(soma == 7 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Gustavo");
            }
            if(soma == 8 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Luiz");
            }
            if(soma == 9 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Marcos");
            }
            if(soma == 10 && gn == "m")
            {
                Console.WriteLine("Seu par ideal é: Rafael");
            }
            if(soma == 1 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Maria");
            }
            if(soma == 2 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Carla");
            }
            if(soma == 3 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Amamnda");
            }
            if(soma == 4 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Carina");
            }
            if(soma == 5 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Vitoria");
            }
            if(soma == 6 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Larissa");
            }
            if(soma == 7 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Eduarda");
            }
            if(soma == 8 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Talita");
            }
            if(soma == 9 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Mirela");
            }
            if(soma == 10 && gn == "f")
            {
                Console.WriteLine("Seu par ideal é: Rafaela");
            }
            Console.ReadKey();
        }
    }
}
