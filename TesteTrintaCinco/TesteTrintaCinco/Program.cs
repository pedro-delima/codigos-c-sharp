using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string C1 = Console.ReadLine();
            string C2 = Console.ReadLine();
            string C3 = Console.ReadLine();

            if (C1 == "vertebrado")
            {
                if (C2 == "ave")
                {
                    if (C3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (C3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (C2 == "mamifero")
                {
                    if (C3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (C3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
                
            } else if (C1 == "invertebrado")
            {
                if (C2 == "inseto")
                {
                    if (C3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (C3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (C2 == "anelideo")
                {
                    if (C3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (C3 == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}