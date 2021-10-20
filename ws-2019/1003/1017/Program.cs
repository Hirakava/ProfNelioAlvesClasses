using System;
using System.Globalization;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int HorasGasta,VelocidadeMedia, ConsumoMedio;
            Double QdeLitros;
            ConsumoMedio = 12;

            HorasGasta = int.Parse(Console.ReadLine());
            VelocidadeMedia = int.Parse(Console.ReadLine());
            QdeLitros = (double)(HorasGasta * VelocidadeMedia) / ConsumoMedio;


            Console.WriteLine(QdeLitros.ToString("F3",CultureInfo.InvariantCulture));
        }
    }
}
