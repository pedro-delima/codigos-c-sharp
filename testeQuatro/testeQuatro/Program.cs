using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("digite outro numero");
            int b = int.Parse(Console.ReadLine());

            int x = a + b;
            Console.WriteLine("A soma antre " + a + " e " + b + " é " + x);


        }
    }
}