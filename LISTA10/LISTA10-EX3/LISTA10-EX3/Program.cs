using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA10_EX3
{
    class Program
    {
        struct Empregado//DECLARA ESTRUTURA 
        {
            public int mat;//DECLARA VARIAVEL DENTRO DA ESTRUTURA EM PUBLICO
            public string nome;//DECLARA VARIAVEL DENTRO DA ESTRUTURA EM PUBLICO
            public double salario;//DECLARA VARIAVEL DENTRO DA ESTRUTURA EM PUBLICO
        }
        static void Main(string[] args)
        {
            Empregado[] emp = new Empregado[5];//UM OBJETO COM O VETOR DA ESTRUTURA COM 5 POSICOES 0,1,2.....
            for (int i = 0; i < emp.Length; i++)//ESTRUTURA DE REPETICAO PARA PRENCHER VETOR
            {
                Console.WriteLine("Digite o nome do empregado: ");//
                emp[i].nome = Console.ReadLine();//SETA NOME DA POSICAO +I
                emp[i].mat = (i + 1);//SETA MAT
                Console.WriteLine("Digite o salário do empregado: ");
                emp[i].salario = double.Parse(Console.ReadLine());//SETA SALARIO
            }
            for (int i = 0; i < emp.Length; i++)//ESTRUTURA REPETICAO PARA MOSTRAR NA TELA
            {
                Console.WriteLine("O empregado {0} matricula {1} tem salario {2}!",
               emp[i].nome, emp[i].mat, emp[i].salario);//MOSTRA TODOS EMPREGADOS NA TELA DE UMA MANEIRA DIFERENTE USANDO A SEQUENCIA!
            }
            Console.ReadKey();//LÊ KEY
        }
    }
}
