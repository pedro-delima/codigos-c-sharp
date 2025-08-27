using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o tempo em segundos ");
            int segundos = int.Parse(Console.ReadLine());
            int segundoRes = segundos % 60;
            int minutos = segundos / 60;
            int horas = minutos / 60;
            Console.WriteLine(horas + ":" + minutos + ":" + segundoRes);
        }
    }
}