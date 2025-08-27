using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] num = Console.ReadLine().Split(' ');
            x = int.Parse(num[0]);
            y = int.Parse(num[1]);
            
            while (x != y)
            {
                if (x < y)
                {
                    Console.WriteLine("Crecente");
                }
                else if (x > y)
                {
                    Console.WriteLine("Decrecente");
                }
                num = Console.ReadLine().Split(' ');
                x = int.Parse(num[0]);
                y = int.Parse(num[1]);
            }
        }
    }
}