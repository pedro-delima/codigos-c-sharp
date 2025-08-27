using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double calc = (4.0 / 3.0) * 3.14159 * Math.Pow(raio, 3);
            Console.WriteLine("O volume da esfera é: " + calc);
        }
    }
}