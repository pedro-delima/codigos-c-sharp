using System;

using System;
using System.Globalization;

namespace DT
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int M, N;
            int i, j;
            int sum;

            Console.Write("Digite o número de linhas: ");
            M = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas: ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];
            int[] mod = new int[M];

            Console.WriteLine("\nDigite os elementos da matriz:");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("Elemento [" + i + "][" + j + "]: ");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < N; i++)
            {
                sum = 0;
                for (j = 0; j < N; j++)
                {
                    sum += mat[i, j];
                }
                mod[i] = sum;
            }
            Console.WriteLine("Vetor de modo gerado:");

            for (i = 0; i < M; i++)
            {
                Console.WriteLine("Elemento [" + i + "]: " + mod[i]);
            }

        }
    }
}