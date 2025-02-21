using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeDeSoma
{
    class TesteDeSoma
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int acertos = 0;
            int totalJogadas = 0;
            int jg = -1;

            Console.WriteLine("Bem-vindo ao jogo de soma de dois números! Responda com 0 para sair.");

            int n1 = gerador.Next(1, 10); 
            int n2 = gerador.Next(1, 10);

            while (jg != 0)
            {
                int num1 = gerador.Next(1, 11);
                int num2 = gerador.Next(1, 11);
                int soma = num1 + num2;
                
                
                Console.Write($"Quanto é {num1} + {num2}? (Digite 0 para sair): ");
                int resposta = int.Parse(Console.ReadLine());
                Console.Clear();

                if (resposta == 0)
                {
                    Console.WriteLine("Obrigado por jogar! Até logo!");
                    break;
                }
                 totalJogadas++;

                if (resposta == soma)
                {
                    Console.WriteLine("Parabéns! você acertou!\n " + num1 + "+" + num2 + "=" + soma);

                   acertos++;
                }
                else
                {
                    Console.WriteLine("A Resposta é " + num1 + num2 + ". Tente novamente.");
                }

                double percentualAcertos = (double)acertos / totalJogadas * 100;
                Console.WriteLine($"\nPercentual de acertos: {percentualAcertos:F0}%");
            }
            
            Console.ReadKey();

        }
    }
}
