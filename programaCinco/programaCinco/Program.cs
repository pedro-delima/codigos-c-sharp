using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite sua nota no primeiro semestre: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua nota no segundo semestre: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2) / 2;

            if (media < 7) {
                Console.WriteLine("Voce está de recuperação = (");
            } else {
                Console.WriteLine("parabens, Voce passou de ano = ) ");
            }
        }
    }
}