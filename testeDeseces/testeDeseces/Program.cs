using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a distancia em Km");
            int km = int.Parse(Console.ReadLine());
            double calc = km / 30.0;
            double tempo = calc * 60;
            Console.WriteLine(tempo +  " minutos");

        }
    }
}