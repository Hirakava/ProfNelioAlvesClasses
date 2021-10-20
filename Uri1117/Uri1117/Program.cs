using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace Uri1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double Media, Nota1, Nota2;

            Nota1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            
            while (Nota1 < 0.0 || Nota1 > 10.0) {
                Console.WriteLine("nota invalida");
                Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            while (Nota2 < 0.0 || Nota2 > 10.0) {
                Console.WriteLine("nota invalida");
                Nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            Media = (Nota1 + Nota2) / 2.0;
            Console.WriteLine("media = " + Media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
