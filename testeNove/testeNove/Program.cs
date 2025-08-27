using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int fun = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine());

            double salario = horas * preco;

            Console.WriteLine("Numero: " + fun);
            Console.WriteLine("salario: " + salario);
        }
    }
}