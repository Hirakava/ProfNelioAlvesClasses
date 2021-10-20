using System;
using System.Globalization;

namespace ExResolvido03
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome1, Nome2;
            int Idade1, Idade2;
            double IdadeMedia;

            string[] Vetor1 = Console.ReadLine().Split(' ');
            Nome1 = (Vetor1[0]);
            Idade1 = int.Parse(Vetor1[1]);

            string[] Vetor2 = Console.ReadLine().Split(' ');
            Nome2 = (Vetor2[0]);
            Idade2 = int.Parse(Vetor2[1]);

            IdadeMedia = (Idade1 + Idade2) / 2;
            Console.WriteLine("A Idade Média de " + Nome1 + " e " + Nome2 + "são de " + IdadeMedia.ToString("F1", CultureInfo.InvariantCulture) " anos.");
        }
    }
}
