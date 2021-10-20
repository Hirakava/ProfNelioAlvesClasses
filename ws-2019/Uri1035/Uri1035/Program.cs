using System;

namespace Uri1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, SomaCD, SomaAB;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);
            D = int.Parse(vet[3]);

            SomaCD = C + D;
            SomaAB = A + B;

            if (B > C && D > A)
            {
                if (SomaCD > SomaAB)
                {
                    if (C > 0 && D > 0)
                    {
                        if (A % 2 == 0)
                        {
                            Console.WriteLine("Valores aceitos");
                        }
                        else
                        {
                            Console.WriteLine("Valores nao aceitos");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valores nao aceitos");
                    }
                }
                else
                {
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            

        }
    }
}