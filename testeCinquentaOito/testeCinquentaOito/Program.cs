using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N  = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] vet2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vet2[i]);
            }
            for (int i = 0;i < N; i++)
            {
                int media = vet[i] / N;
                Console.WriteLine(media);
            }

            
            ;
        }
    }
}