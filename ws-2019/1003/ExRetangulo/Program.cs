using System;
using System.Globalization;

namespace ExRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double B, Altura, Area, Perimetro, Diagonal;

            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Area = B * Altura;
            Perimetro = (2*B) + (Altura*2);
            Diagonal = Math.Sqrt((Math.Pow(B, 2.0))+(Math.Pow(Altura, 2.0)));

            Console.WriteLine("AREA = " + Area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + Perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + Diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
