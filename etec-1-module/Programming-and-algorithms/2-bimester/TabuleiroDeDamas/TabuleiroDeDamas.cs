using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroDeDamas
{
    class TabuleiroDeDamas
    {
        static void Main(string[] args)
        {
            char[,] tabuleiro = new char[8, 8];

  
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i < 3) && (i % 2 == 0 ? j % 2 != 0 : j % 2 == 0))
                        tabuleiro[i, j] = '0';
                    else if ((i > 4) && (i % 2 == 0 ? j % 2 != 0 : j % 2 == 0))
                        tabuleiro[i, j] = '*';
                    else
                        tabuleiro[i, j] = ' ';
                }
            }

         
            Console.WriteLine("Tabuleiro de Damas Inicial:");
            Console.WriteLine("  +---+---+---+---+---+---+---+---+");
            for (int i = 0; i < 8; i++)
            {
                Console.Write((i + 1) + " |");
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" " + tabuleiro[i, j] + " |");
                }
                Console.WriteLine();
                Console.WriteLine("  +---+---+---+---+---+---+---+---+");
            }

            
            Console.WriteLine("    a   b   c   d   e   f   g   h");
            Console.ReadKey();
        }
    }
}
