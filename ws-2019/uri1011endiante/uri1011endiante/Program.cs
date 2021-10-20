using System;
using System.Globalization;

namespace uri1011endiante
{
    class Program
    {
        static void Main(string[] args)
        {
            Double Vol, RaioEsfera, Pi;
            Pi = 3.14159;

            RaioEsfera = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Vol = ((4.0/3.0)*Pi) * Math.Pow(RaioEsfera, 3.0);

            Console.WriteLine("VOLUME = " + Vol.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
