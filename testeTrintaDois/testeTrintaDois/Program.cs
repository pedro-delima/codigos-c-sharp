using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite as coordenadas de x e y");
            string[] coordenadas = Console.ReadLine().Split(' ');
            double x = double.Parse(coordenadas[0]);
            double y = double.Parse(coordenadas[1]);

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Terceiro quadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Segundo quadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Quarto quadrante");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Primeiro quadrante");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}