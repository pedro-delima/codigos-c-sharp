using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] A;
            int N = int.Parse(Console.ReadLine());
            A = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                A[i] = double.Parse(s[i]);

                
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(A[i] + " ");
                
            }
            Console.WriteLine();

            double soma = 0.0;

            for (int i = 0;i < N;i++)
            {
                soma += A[i];
            }
            double media = soma / N;
            Console.WriteLine(soma);
            Console.WriteLine(media);
        }
    }
}