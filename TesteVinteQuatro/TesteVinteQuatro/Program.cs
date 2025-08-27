using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tempo em minutos que voce passou no telefone");
            int num = int.Parse(Console.ReadLine());

            if (num <= 100) {
                Console.WriteLine("Valor a ser pago: 50 reais");
            } else if (num > 100)
            {
                int calc = num - 100;
                int tempo = calc * 2;
                int valor = 50 + tempo;

                Console.WriteLine("Valor a ser pago: " + valor + " reais");
            }
        }
    }
}