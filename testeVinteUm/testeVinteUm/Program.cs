using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade em dias: ");
            int idade = int.Parse(Console.ReadLine());

            int anos = idade / 365;
            idade = idade % 365;

            int meses = idade / 30;
            idade = idade % 30;

            Console.WriteLine(anos + " ano (s)");
            Console.WriteLine(meses + " mes (es)");
            Console.WriteLine(idade + " dia (s)");

        }
    }
}