using System;
using System.Globalization;
using System.Numerics;

namespace Curso {

    class Program
    {
        static void Main(string[] args) {


            Console.WriteLine("Informe o valor do raio");
            double raio = double.Parse(Console.ReadLine());

            double areaC = 3.14159265358979323846 * Math.Pow(raio, 2);

            Console.WriteLine("x = " + areaC);


        }
    }
}
