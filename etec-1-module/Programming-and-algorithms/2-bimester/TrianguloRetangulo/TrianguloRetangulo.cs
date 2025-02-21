using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloRetangulo
{
    class TrianguloRetangulo
    {
        static void Main(string[] args)
        {
            char[,] triangulo = new char[6, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    triangulo[i, j] = ' ';
                }
            }

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    triangulo[i, j] = '*';
                }
            }

            Console.WriteLine("Triângulo Retângulo:");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(triangulo[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
