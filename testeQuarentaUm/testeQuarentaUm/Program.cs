using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo do produto que voce mais gosta");
            int num = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int disel = 0;

            while (num != 4) {
                if (num == 1) {
                    alcool = alcool + 1;
                }
                else if (num == 2)
                {
                    gasolina += 1;
                }
                else if (num == 3)
                {
                    disel += 1;
                }
                
                if (num > 4) {
                    Console.WriteLine("Voce digitou um numero invalido, tente novamente");
                }
                num = int.Parse(Console.ReadLine());
                

            }
            Console.WriteLine("Muito obrigado");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("gasolina: "+ gasolina);
            Console.WriteLine("Disel: " + disel);
        }
    }
}