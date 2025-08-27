using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa  ?");
            int quartos = int.Parse(Console.ReadLine());


            Console.WriteLine("entre com o preço de um produto");
            double produto = double.Parse(Console.ReadLine());


            Console.WriteLine("Entre seu ultimo nome, idade e altura (mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');



            Console.WriteLine("Seu nome completo é: " + nome);
            Console.WriteLine("Você tem: " + quartos + " quartos");
            Console.WriteLine("O preço do produto é: " + produto + " reais");
            Console.WriteLine("O seu ultimo nome é: " + dados[0]);
            Console.WriteLine("A sua idade é: " + dados[1]);
            Console.WriteLine("A sua altura é:" + dados[2]);
        }
    }
} 