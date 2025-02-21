using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabarito
{
    class Gabarito
    {
        static void Main(string[] args)
        {
            char[] gabarito = new char[10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                gabarito[i] = (char)rnd.Next('a', 'f');
            }

            int[,] respostas = new int[100, 10];

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    respostas[i, j] = rnd.Next(1, 6);
                }
            }

            int[] pontuacao = new int[100];

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (gabarito[j] == (char)(respostas[i, j] + 'a' - 1))
                    {
                        pontuacao[i]++;
                    }
                }
            }

            Console.WriteLine("Gabarito:");
            foreach (var resposta in gabarito)
            {
                Console.Write(resposta + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Pontuação dos Alunos:");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Aluno " + (i + 1) + ": " + pontuacao[i] + " pontos");
            }
            Console.ReadKey();
        }
    }
}
