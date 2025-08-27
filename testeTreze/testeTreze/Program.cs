using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros: ");

            string[] n1 = Console.ReadLine().Split(' ');
            
            double a = double.Parse(n1[0]);
            double b = double.Parse(n1[1]);
            double c = double.Parse(n1[2]);

            double atriangulo = a * c / 2;
            double acirculo = 3.14159 * Math.Pow(c, 2);
            double atrapezio = (a + b) * c / 2;
            double aquadrado = Math.Pow(b, 2);
            double aretangulo = a * b;

            Console.WriteLine("Triangulo: " + atriangulo);
            Console.WriteLine("Circulo: " + acirculo);
            Console.WriteLine("Trapezio: " + atrapezio);
            Console.WriteLine("Quadrado: " + aquadrado);
            Console.WriteLine("Retangulo: " + aretangulo);
        }
    }
}