using System;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int MaiorAB, Maior, A, B, C;
            

            string [] Vetor = Console.ReadLine().Split(' ');
            A = int.Parse(Vetor[0]);
            B = int.Parse(Vetor[1]);
            C = int.Parse(Vetor[2]);

            MaiorAB = (A+B+Math.Abs(A-B))/2;
           
            Maior = (MaiorAB+C+Math.Abs(MaiorAB-C))/2;

            Console.WriteLine(+ Maior + " eh o maior");
        }
    }
}
