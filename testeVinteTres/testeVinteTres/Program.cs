﻿using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = int.Parse(num[0]);
            int b = int.Parse(num[1]);
            int c = int.Parse(num[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("Menor: " + a);

            }
            else if (b < a && b < c)
            {
                Console.WriteLine("Menor: " + b);
            }
            else
            {
                Console.WriteLine("Menor: " + c);
            }
        }
    }
}