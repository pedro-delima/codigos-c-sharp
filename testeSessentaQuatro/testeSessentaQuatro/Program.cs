using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int M = int.Parse(s[0]);
            int N = int.Parse(s[1]);
            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int conta = 0;
            Console.WriteLine("Valores negativos: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {

                    if (mat[i, j] < 0)
                    {
                        Console.WriteLine(mat[i, j]);
                    }
                }

            }
            
        }
    }
}