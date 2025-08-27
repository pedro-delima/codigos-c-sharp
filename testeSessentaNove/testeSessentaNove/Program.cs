using System;
using System.Globalization;

namespace DT
{
    class Prgram
    {
        public static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[,] matriz = new double[N, N];
            double soma = 0;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matriz[i, j] = double.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0)
                    {
                        soma += matriz[i, j];
                    }
                }
            }

            Console.WriteLine("Soma: " + soma.ToString("F1"));

            int linha = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[linha - 1, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            int coluna = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, coluna - 1].ToString("F1") + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.Write(matriz[i, i].ToString("F1") + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = Math.Pow(matriz[i, j], 2);
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(matriz[i, j].ToString("F1") + " ");
                }
                Console.WriteLine();
            }
        }
    }
}