using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o codigo do produto, quantas unidades e preço do produto: (na mesma linha)");
            String[] n1 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(n1[0]);
            int unidades1 = int.Parse(n1[1]);
            double valor1 = double.Parse(n1[2]);

            Console.WriteLine("Informe o codigo do segundo produto, a unidade do segundo produto, e o valor da unidade do segundo produto: ");
            String[] n2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(n2[0]);
            int unidades2 = int.Parse(n2[1]);
            double valor2 = double.Parse(n2[2]);

            double calc = unidades1 * valor1 + unidades2 * valor2;
            Console.WriteLine("O valor final a ser pago é " + calc);
            








        }
    }
}