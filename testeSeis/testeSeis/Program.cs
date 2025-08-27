using System;
using System.Net.Http.Headers;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a primeira nota do aluno: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota do aluno: ");
            double b = double.Parse(Console.ReadLine());

            double media = (a + b) / 2 ;
            Console.WriteLine("a media do aluno é " + media);
        }
    }
}