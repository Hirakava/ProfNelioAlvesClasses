using System;
using System.Globalization;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            double Y, ConsumoMedio;
            int X;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ConsumoMedio = (double)X / Y;            

            Console.WriteLine(ConsumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
