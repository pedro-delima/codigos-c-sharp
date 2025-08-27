using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            int conta = x / y;
            int contares = x % y;


            if (contares != 0) {
                Console.WriteLine("Divisão invalida");
            }
            while (contares != 0) {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
                conta = x / y;
                contares = x % y;
            }
            Console.WriteLine("Resultado: " + conta);


            
        }
    }
}