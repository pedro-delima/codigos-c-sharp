using System;
using System.Runtime.Serialization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int menor = x;
            int maior = y;

            if (x > y)
            {
                menor = y;
                maior = x;
            }

            int conta = 0;
            int i = menor;
            while (i <= maior) { 
            if (i % 13 != 0)
                {
                    conta += i;
                }
            i++;
            }
            Console.WriteLine(conta);
        }
    }
}