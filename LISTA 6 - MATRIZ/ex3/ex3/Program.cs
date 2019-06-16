using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[8, 6];
            int somapar=0,qtdepar=0;
            double media;

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.WriteLine("Digite um n°:");
                    matriz[l, c] = int.Parse(Console.ReadLine());
                }
            }

            for (int l = 0; l < 8; l++)
            {
                for (int c = 0; c < 6; c++)
                {
                    if (c % 2 == 0)
                    {
                        somapar+=matriz[l, c];
                        qtdepar++;
                    }
                }
            }
            Console.WriteLine("Media dos valores da matriz é:");
            media = somapar/(double)qtdepar;
            Console.WriteLine(+media);
            Console.ReadKey();
        }
    }
}
