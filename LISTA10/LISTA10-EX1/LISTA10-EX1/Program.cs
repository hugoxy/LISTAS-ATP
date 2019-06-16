using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA10_EX1
{
    class Program
    {
        public struct Aluno//STRUCT ALUNO COM 6 VARIAVEL DENTRO
        {
            public int mat;//DECLARA VARIAVEIS DA STRUCT EM MODO PUBLIC
            public string nome;//DECLARA VARIAVEIS DA STRUCT EM MODO PUBLIC
            public double nota1, nota2, nota3, media;//DECLARA VARIAVEIS DA STRUCT EM MODO PUBLIC
        }
        static void Main(string[] args)
        {
            Aluno alu1;//CHAMA STRUC ALUNO COM OBJETO ALU1
            alu1.mat = 1;//SETA A VAR MAT DO ALUNO
            alu1.nome = "maria";//SETA NOME
            alu1.nota1 = 10.0;//SETA A NOTA
            Console.WriteLine("O aluno {0} chama {1} e teve nota{2}", alu1.mat,//MOSTRA TUDO NA TELA DE UM MODO DIFERENCIANDO USANDO A ORDEM
           alu1.nome, alu1.nota1);
            Console.ReadKey();//ESPERA KEY
        }
        
    }
}
