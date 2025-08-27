using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno");

            int nota1 = int.Parse(Console.ReadLine());

            while (nota1 < 0 || nota1 > 10) {
                Console.WriteLine("Nota invalida");
                nota1 = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Digite a segunda nota do aluno");
            int nota2 = int.Parse(Console.ReadLine());

            while (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Nota invalida");
                nota2 = int.Parse(Console.ReadLine());
            }

            int media = (nota1 + nota2) / 2;
            Console.WriteLine("A sua media é: " +  media);


        }
    }
}