using System;

namespace Teste
{
       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o comprimento: ");
            double comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do metro quadrado: ");
            double preco = double.Parse(Console.ReadLine());

            double area = largura * comprimento;
            Console.WriteLine("a area do terreno é: " + area + " Metros quadrados");

            double valor = preco * area;
            Console.WriteLine("O valor do terreno é " + valor + " reais");

        }
    }
}