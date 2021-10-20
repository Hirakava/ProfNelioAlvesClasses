using System;
using System.Threading;

namespace Uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string Palavra1, Palavra2, Palavra3;

            Palavra1 = (Console.ReadLine());
            Palavra2 = (Console.ReadLine());
            Palavra3 = (Console.ReadLine());

            if (Palavra1 == "vertebrado")
            {
                if (Palavra2 == "ave")
                {
                    if (Palavra3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else
                {
                    if (Palavra3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else
            {
                if (Palavra2 == "inseto")
                {
                    if (Palavra3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else
                {
                    if (Palavra3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else
                    {
                        Console.WriteLine("minhoca");
                    }

                }
            }
        }          
        
    }
}
