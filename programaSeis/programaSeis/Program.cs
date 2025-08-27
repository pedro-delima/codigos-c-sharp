using System;

namespace Curso { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Voce não pode votar");

            } else if (idade < 18 || idade > 69) { 
        
                Console.WriteLine("Voto opcional");
            } else if (idade >= 18)
            {
                Console.WriteLine("voto obrigatorio");
            }

        }
    }
}