using System;
using System.Globalization;

namespace DT
{
    class Prgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senhaInformada = int.Parse(Console.ReadLine());

            while (senhaInformada != 2002)
            {

                if (senhaInformada != 2002)
                {
                    Console.WriteLine("Senha Invalida");

                }
                else
                {
                    Console.WriteLine("Acesso Permitido");
                }
                Console.WriteLine("Digite outra senha:");
                senhaInformada = int.Parse(Console.ReadLine());
            }
        }
    }
}