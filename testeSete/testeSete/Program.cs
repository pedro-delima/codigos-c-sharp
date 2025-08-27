using System;

namespace Curso 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua nota parcial: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digte a nota global: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("digite sua nota de trabalho: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            Console.WriteLine("sua media é: " + media);
        }
    }
}
