using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0, c = 0, mul;
            int[,] matriz = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            for (l = 0; l < 4; l++)
            {
                for (c = 0; c < 4; c++)
                {
                    Console.WriteLine("Digite um numero:");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Qual o numero voce deseja multiplicar a matriz:");
            mul = int.Parse(Console.ReadLine());

            for (l = 0; l < 4; l++)
            {
                for (c = 0; c < 4; c++)
                {
                    matriz2[l, c] = matriz[l, c] * mul;
                }
            }

            for (l = 0; l < 4; l++)
            {
                for (c = 0; c < 4; c++)
                {
                    Console.Write(matriz2[l, c] + "|");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}