using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
           int N = int.Parse(Console.ReadLine());
           int[] vet = new int[N];
           int[] vet2 = new int[N];

            string[] vet3 = Console.ReadLine().Split(' ');
            string[] vet4 = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(vet3[i]);
                vet2[i] = int.Parse(vet4[i]);
            }

            for (int i = 0;i < N; i++)
            {
                int soma = vet[i] + vet2[i];
                Console.WriteLine(soma);
            }
            
        }
    }
}