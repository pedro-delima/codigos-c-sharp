using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu salario: ");
            double salario = int.Parse(Console.ReadLine());


            double percentual;
            
            

            if (salario <= 400)
            {
                percentual = 15.0;
                
            }
            else if (salario <= 800)
            {
                percentual = 12.0;


            }
            else if (salario <= 1200)
            {
                percentual = 10.0;

            } 
            else if (salario <= 2000)
            {
                percentual = 7.0;

            }
            else if (salario > 2000)
            {
                percentual = 4.0;

            }

            double reajuste = salario * percentual / 100.0;
            double novoSalario = salario + reajuste;
            Console.WriteLine("Novo salario: " + novoSalario);
            Console.WriteLine("Reajuste ganho" + reajuste);
            Console.WriteLine("Em percentual: " + percentual);

            



        }
    }
}