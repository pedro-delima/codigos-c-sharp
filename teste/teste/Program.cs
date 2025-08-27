using System;
using System.Globalization;

namespace DT
{
    class Program
    {
        static void Main(string[] args)
        {
            double largura, comprimento, valorMetro, area, preco;


            Console.Write("Digite a largura do terreno em metros: ");
            largura = double.Parse(Console.ReadLine());


            Console.Write("Digite o comprimento do terreno em metros: ");
            comprimento = double.Parse(Console.ReadLine());


            Console.Write("Digite o valor do metro quadrado em reais: ");
            valorMetro = double.Parse(Console.ReadLine());


            area = largura * comprimento;


            preco = area * valorMetro;


            Console.WriteLine("A área do terreno é {0:F2} m2", area);
            Console.WriteLine("O preço do terreno é {0:F2} reais", preco);
        }
    }
}
