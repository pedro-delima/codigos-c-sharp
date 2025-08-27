using System;

namespace Curso
{
    class Program
    {
        public static int ReadLine { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro numero: ");
            int b = int.Parse(Console.ReadLine());

            int mult = a * b;
            Console.WriteLine("A multiplicação entre " + a + " e " + b + " é " + mult);

        }
    }
}
