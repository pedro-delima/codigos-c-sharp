using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vet;
            vet = new int[N];

            string[] vet2 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vet2[i]);
            }

            int maior = vet[0];
            

            for (int i = 1;i < N; i++)
            {
                if (vet[i] > maior)
                {
                    maior = vet[i];

                }
            }
            Console.WriteLine(maior);

        }
    }
}
