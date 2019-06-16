using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA10_EX2
{
    class Program
    {
        public struct Aluno//cria estrutura aluno
        {
            public int mat;//VARIAVEL DENTRO DE ALUNO EM PUBLICO
            public string nome;//VARIAVEL DENTRO DE ALUNO EM PUBLICO
            public float[] nota;//VARIAVEL DENTRO DE ALUNO EM PUBLICO
            public float media;//VARIAVEL DENTRO DE ALUNO EM PUBLICO
        }
        static void Main(string[] args)
        {
            Aluno alu;//CRIA OBJETO ALU COM DEFINIÇOES DA STRUC ALUNO
            float soma = 0;//SOMA
            alu.nota = new float[3];//CRIA A NOTA EM VETOR
            int i;
            Console.WriteLine("Digite o nome do aluno: ");
            alu.nome = Console.ReadLine();//SETA EM ALU NOME O NOME
            Console.WriteLine("Digite a matricula do aluno: ");
            alu.mat = int.Parse(Console.ReadLine());//SETA MATRICULA
            for (i = 0; i < 3; i++)//ESTRUTURA DE REPETICAO PARA PREENCHER VETOR NOTA
            {
                Console.WriteLine("Digite a nota " + (i + 1) + ": ");//
                alu.nota[i] = float.Parse(Console.ReadLine());//LE AS NOTAS DIGITADAS E GUARDA NO VETOR
                soma += alu.nota[i];//SOMA TUDO
            }
            alu.media = soma / 3;//FAZ A MEDIA
            Console.WriteLine("O aluno {0} matricula {1} teve media {2}!", alu.nome,
           alu.mat, alu.media);//MOSTRA A MEDIA NA TELA USANDO A ORDEM
            Console.ReadKey();//ESPERA KEY
        }
    }
}
