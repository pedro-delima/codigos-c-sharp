using System;
using System.Net.Http.Headers;
using System.Xml.Linq;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite suas notas durante o ano: ");
            string[] notas = Console.ReadLine().Split(' ');
            double nota1 = double.Parse(notas[0]);
            double nota2 = double.Parse(notas[1]);
            double nota3 = double.Parse(notas[2]);
            double nota4 = double.Parse(notas[3]);
            
            double media = nota1 * 2 + nota2 * 3 + nota3 * 4 + nota4 * 1;
            double mediaf = media / 10;

            if (mediaf <= 5)
            {
                Console.WriteLine("Aluno reprovado");
            }
            else if (mediaf > 5 && mediaf < 6.9)
            {
                Console.WriteLine("Aluno em exame");
                Console.WriteLine("Digite a nota do exame: ");
                double exame = double.Parse(Console.ReadLine());
                double mediafe = (mediaf + exame) / 2;
                Console.WriteLine(mediafe);
                if (mediafe < 5) {
                    Console.WriteLine("Aluno reprovado");

                }
                else
                {
                    {
                        Console.WriteLine("Aluno aprovado");
                    }
                }
            }
            else
            {
                Console.WriteLine("aluno aprovado");
            }
            Console.WriteLine("Media final: " + mediaf);

        }
    }
}