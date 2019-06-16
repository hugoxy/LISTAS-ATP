using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c;
            int j = 0, i = 0;
            Console.WriteLine("Qual a quantidade linhas da sua matriz?");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a quantidade colunas da sua matriz?");
            c = int.Parse(Console.ReadLine());
            int[,] nums = new int[l, c];

            for (i = 0; i < l; i++)
            {
                for (j = 0; j < c; j++)
                {
                    Console.WriteLine("Digite um numero:");
                    nums[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n Os valores da matriz são:");
            for (i = 0; i < l; i++)
            {

                Console.Write("\n");
                for (j = 0; j < c; j++)
                {
                    Console.Write(nums[i, j] + "|");
                }
            }
            Console.WriteLine("\nValores maiores que 15 e menores que 25:");
            for (i = 0; i <l; i++)
            {
                for (j = 0; j < c; j++)
                {
                    if (nums[i, j] > 15 && nums[i, j] < 25)
                    {
                        Console.Write(nums[i, j] + "|");
                    }
                }
               
            }
            Console.ReadKey();
        }
    }
}
