using System;
using System.Numerics;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine());
            double vendas = double.Parse(Console.ReadLine());

           double bonus = vendas * 0.15;
            double valorfinal = salario + bonus;
            Console.WriteLine("Total = " + valorfinal);
        }
    }
}
