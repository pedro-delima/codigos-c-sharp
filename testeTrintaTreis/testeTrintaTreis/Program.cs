using System;

namespace Curso { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor dos lados do triangulo: ");
            string[] lado = Console.ReadLine().Split(' ');
            double a = double.Parse(lado[0]);
            double b = double.Parse(lado[1]);
            double c = double.Parse(lado[2]);

            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else if ()
            {

            }
        }
    }
}
