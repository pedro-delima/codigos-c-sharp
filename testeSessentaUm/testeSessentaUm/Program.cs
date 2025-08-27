using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite quantas passoas serao cadastradas");
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
                
                
            }
            int maiorIdade = idade[0];
            int posicaoIdade = 0;
             
            for (int i = 0;i < N; i++)
            {
                if (idade[i] > maiorIdade)
                {
                    maiorIdade = idade[i];
                    posicaoIdade = i;
                }
            }
            Console.WriteLine("Pessoa mais velha: " + nome[posicaoIdade]);
        }
    }
}