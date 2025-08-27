using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int[,] mat;
            N = int.Parse(Console.ReadLine());
            mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);

                }
            }
            Console.WriteLine("Diagonal Principal: ");
            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(mat[i,i] + " ");
            }

            int conta = 0;
            for (int i = 0; i<N ; i++) {
                for (int j=0; j < N ; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        conta++;
                    }
                }
            }
            Console.WriteLine("Negativos: " + conta);
        }
    }
}