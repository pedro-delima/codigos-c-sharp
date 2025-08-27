using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int conta;
            for (int i = 1;  i <= 10;  i++)
            {
                conta = i * n;
                Console.WriteLine(i + " x " + n + " = " + conta);

            }
        }
    }
}