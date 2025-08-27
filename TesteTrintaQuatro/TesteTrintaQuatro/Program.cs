using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int tempoInicial = horaInicial * 60 + minutoInicial;
            int tempoFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (tempoInicial < tempoFinal)
            {
                duracao = tempoFinal - tempoInicial;
            }
            else
            {
                duracao = (24 * 60 - tempoInicial) + tempoFinal;
            }

            int valorHoras = duracao / 60;
            int valorMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + valorHoras + " HORA(S) E " + valorMinutos + " MINUTO(S)");
        }
    }
}