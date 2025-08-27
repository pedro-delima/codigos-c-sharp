using System;

namespace Curso {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            double idade = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            string nome2 = Console.ReadLine();

            Console.WriteLine("Digite a idade da segunda pessoa: ");
            double idade2 = double.Parse(Console.ReadLine());

            double media = (idade + idade2) / 2;

            Console.WriteLine("A idade media entre " + nome + " e " + nome2 + " é de " + media + " anos");


        }
    }
}

