using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main(string[] args)
        {

            Random gerador = new Random();
            int opPc = gerador.Next(1, 4);

            Console.WriteLine("Escolha: \n1-Pedra\n2-Papel\n3-Tesoura");
            int op = int.Parse(Console.ReadLine());

            //Descubra quem ganhou o jogo, sabendo que:
            // 1 - Pedra ganha de Tesoura
            // 2 - Papel ganha de Pedra
            // 3 - Tesoura ganha de Papel

            if(opPc == 1 && op == 1)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("empate");
            }
            if(opPc == 1 && op == 2)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi você");
            }
            if(opPc == 1 && op == 3)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi pc");
            }
            if(opPc == 2 && op == 1)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi pc");
            }
            if(opPc == 2 && op == 2)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("empate");
            }
            if(opPc == 2 && op == 3)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi você");
            }
            if(opPc == 3 && op == 1)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi você");
            }
            if(opPc == 3 && op == 2)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("O ganhador foi pc");
            }
            if(opPc == 3 && op == 3)
            {
                Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
                Console.WriteLine("empate");
            }
            Console.ReadKey();




            //Console.WriteLine("O PC escolheu " + opPc + " e você escolheu " + op);
            //Console.WriteLine("O ganhador foi ");


        }
    }
}
