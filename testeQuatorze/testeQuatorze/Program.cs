using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o total de km percorridos: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de litros gastos");
            double litros = double.Parse(Console.ReadLine());

            double calc = km / litros;
            Console.WriteLine(calc + "Km/1");
        }
    }
}