using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vet;
            int N = int.Parse(Console.ReadLine());
            vet = new int[N];



            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(Console.ReadLine()); 
            }

            for (int i = 0;i < N; i++)
            {
                Console.WriteLine(vet[i]); 
            }

        }
    }
}