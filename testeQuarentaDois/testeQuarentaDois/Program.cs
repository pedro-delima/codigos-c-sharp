using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int nome = int.Parse(Console.ReadLine());
            int dado = 0;
            int dado2 = 0;
            double media = 0;
            

            while (nome > 0)
            {
                dado += nome;
                dado2 += 1;
                nome = int.Parse(Console.ReadLine());

            }
            media = dado / dado2;
            Console.WriteLine(media);

        }
    }
}