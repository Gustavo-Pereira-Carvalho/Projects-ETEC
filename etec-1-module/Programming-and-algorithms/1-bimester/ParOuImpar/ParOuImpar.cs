using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    class ParOuImpar
    {
        static void Main(string[] args)
        {
            int pontosUsuario = 0;
            int pontosComputador = 0;
            Random gerador = new Random();
            
            while (true)
            {
                int num1 = gerador.Next(1, 100);
                int num2 = num1 % 2;

                Console.Clear();
                Console.WriteLine("\nescolha: \n1-par \n2-impar \n0-sair");
                int resposta = int.Parse(Console.ReadLine());
                if (resposta == 0)
                {
                    Console.WriteLine("Obrigado por jogar! Até logo!");
                    break;
                }
                if(resposta == 1 && num2 == 0)
                {
                    Console.WriteLine($"\nParabéns! \nO número sorteado {num1} é par!!");
                    pontosUsuario++;
                   
                }
                else if (resposta == 1 && num2 != 0)
                {
                    Console.WriteLine($"\nVocê errou!. O número sorteado foi {num1}.");
                    pontosComputador++;
                }

                if (resposta == 2 && num2 != 0)
                {
                    Console.WriteLine($"\nParabéns! \nO número sorteado {num1} é impar!!");
                    pontosUsuario++;
  
                }
                else if(resposta == 2 && num2 == 0)
                {
                    Console.WriteLine($"\nVocê errou!. O número sorteado foi {num1}.");
                    pontosComputador++;
                }
                Console.WriteLine($"Placar - Você: {pontosUsuario} | Computador: {pontosComputador}");
            }
        }
    }
}
