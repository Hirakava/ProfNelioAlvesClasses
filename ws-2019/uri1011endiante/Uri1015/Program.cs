using System;
using System.Globalization;
using System.Numerics;

namespace Uri1015
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Distancia, Xa, Xb, Ya, Yb;

            String[] Vetor1 = Console.ReadLine().Split(' ');
            Xa = double.Parse(Vetor1[0],CultureInfo.InvariantCulture);
            Ya = double.Parse(Vetor1[1],CultureInfo.InvariantCulture);

            String[] Vetor2 = Console.ReadLine().Split(' ');
            Xb = double.Parse(Vetor2[0],CultureInfo.InvariantCulture);
            Yb = double.Parse(Vetor2[1],CultureInfo.InvariantCulture);

            Distancia = Math.Sqrt((Math.Pow((Xb - Xa),2) + (Math.Pow((Yb - Ya),2))));
            
            Console.WriteLine(Distancia.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
