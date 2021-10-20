using System;
using System.Globalization;
using System.Security.Authentication;

namespace Uri1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Perimetro, Area;

            string[] vet = Console.ReadLine().Split(' ');

            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1],CultureInfo.InvariantCulture);
            C = double.Parse(vet[2],CultureInfo.InvariantCulture);

            if (A < B + C && B < A + C && C < A + B)
            {
                Perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + Perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                Area = ((A + B) * C) / 2;
                Console.WriteLine("Area = " + Area.ToString("F1", CultureInfo.InvariantCulture));
            }


        }
    }
}
