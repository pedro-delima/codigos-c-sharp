using System;
using System.Globalization;

namespace DT
{
    class Prgram
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double x1 = double.Parse(input[0]);
            double y1 = double.Parse(input[1]);

            input = Console.ReadLine().Split(' ');
            double x2 = double.Parse(input[0]);
            double y2 = double.Parse(input[1]);

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(distance.ToString("F4"));
        }
    }
}