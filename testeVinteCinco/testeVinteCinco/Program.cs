﻿using System;

namespace Curso
{
    class Program { 
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);
            int C = int.Parse(vet[2]);
            int D = int.Parse(vet[3]);



            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
    }
    }
}
