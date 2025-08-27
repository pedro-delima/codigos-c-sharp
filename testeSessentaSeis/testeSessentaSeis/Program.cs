using System;
using System;

class Program
{
    static void Main()
    {
        // Ler o número N
        Console.Write("Digite o valor de N: ");
        int n = int.Parse(Console.ReadLine());

        // Ler a matriz
        int[,] matriz = new int[n, n];
        Console.WriteLine($"Digite os elementos da matriz {n}x{n}:");
        for (int i = 0; i < n; i++)
        {
            string[] linha = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                matriz[i, j] = int.Parse(linha[j]);
            }
        }

        // Calcular a soma das linhas
        int[] resultado = SomaLinhas(matriz, n);

        // Imprimir o resultado
        Console.WriteLine("Soma dos elementos de cada linha:");
        foreach (int soma in resultado)
        {
            Console.WriteLine(soma);
        }
    }