using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());
            int calc = 0;
            int soma = 0;
            int media = 0;

            while (idade > 0)
            {
                soma += idade;
                calc += 1;
                idade = int.Parse(Console.ReadLine());
                
            }
            media = soma / calc;
            Console.WriteLine(media);
        }
    }
}