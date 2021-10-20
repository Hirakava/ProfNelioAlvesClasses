using System;

namespace Uri1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, Maior, Meio, Menor;

            string[] vet = Console.ReadLine().Split(' ');

            A = int.Parse(vet[0]);
            B = int.Parse(vet[1]);
            C = int.Parse(vet[2]);

            if (A > B && A > C) {
                if (B > C)
                {
                    Maior = A;
                    Meio = B;
                    Menor = C;
                }
                else {
                    Maior = A;
                    Meio = C;
                    Menor = B;
                }
            }
            else
                {
                if (B > A && B > C)
                {
                    if (A > C)
                    {
                        Maior = B;
                        Meio = A;
                        Menor = C;
                    }
                    else
                    {
                        Maior = B;
                        Meio = C;
                        Menor = A;
                    }
                }
                else
                {
                    if (A > B)
                    {
                        Maior = C;
                        Meio = A;
                        Menor = B;
                    }
                    else
                    {
                        Maior = C;
                        Meio = B;
                        Menor = A;
                    }
                }
                
            }
            Console.WriteLine(Menor);
            Console.WriteLine(Meio);
            Console.WriteLine(Maior);
            Console.WriteLine();
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
