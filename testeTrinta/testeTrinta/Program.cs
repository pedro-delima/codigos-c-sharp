using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            double N1 = double.Parse(Console.ReadLine());

            if (N1 < 0 || N1 > 100) {
                Console.WriteLine("Fora de intervalo");
            }
            else if (N1 >= 0 || N1 <= 25)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (N1 >= 75 || N1 <= 100)
            {
                Console.WriteLine("Intervalo (75.100]");
            }
        }
    }
}