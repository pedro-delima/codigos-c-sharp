using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor que voce tem: ");
            int valor = int.Parse(Console.ReadLine());

            double cedulaCem = valor / 100;

            valor = valor % 100;

            double cedulaCinquenta = valor / 50;
            valor = valor % 50;

            double cedulaVinte = valor / 20;
            valor = valor % 20;

            double cedulaDez = valor / 10;
            valor = valor % 10;

            double cedulaCinco = valor / 5;
            valor = valor % 5;

            double cedulaDois = valor / 2;
            valor = valor % 2;

            Console.WriteLine(cedulaCem + "Nota (s) de R$ 100,00");
            Console.WriteLine(cedulaCinquenta + "Nota (s) de R$ 50,00");
            Console.WriteLine(cedulaVinte + "Nota (s) de R$ 20,00");
            Console.WriteLine(cedulaDez + "Nota (s) de R$ 10,00");
            Console.WriteLine(cedulaCinco + "Nota (s) de R$ 5,00");
            Console.WriteLine(cedulaDois + "Nota (s) de R$ 2,00");

        }
    }
}