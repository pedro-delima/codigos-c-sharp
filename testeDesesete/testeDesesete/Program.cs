using System;
using System.Formats.Asn1;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retangolo: ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura do retangulo: ");
            double largura = double.Parse(Console.ReadLine());

            double area = altura * largura;
            double perimetro = 2 * altura + 2 * largura;
            double diagonal = Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimetro = " + perimetro);
            Console.WriteLine("Diagonal = " + diagonal);
          
        }
    }
}