using System;
using System.Runtime.InteropServices;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o horario de inicio e termino do jogo (na mesma linha)");
            string[] valores = Console.ReadLine().Split(' ');
            int horarioInicio = int.Parse(valores[0]);
            int horarioFinal = int.Parse(valores[1]);

            int duracao;

            if (horarioInicio < horarioFinal)
            {
                duracao = horarioFinal - horarioInicio;
            }
            else
            {
                duracao = 24 - horarioInicio + horarioFinal;
            }

            Console.WriteLine("O jogo durou " +  duracao + "hora (s)");

        }
    }
}