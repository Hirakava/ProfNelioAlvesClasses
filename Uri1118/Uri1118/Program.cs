using System;
using System.Globalization;

namespace Uri1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double NUm, NDois, NMedia, NovCal=1;

            while (NovCal == 1) {         
                NUm=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                while (NUm < 0.0 || NUm > 10.0) {
                    Console.WriteLine("nota invalida");
                    NUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                NDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (NDois < 0.0 || NDois > 10.0) {
                    Console.WriteLine("nota invalida");
                    NDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                NMedia = (NUm + NDois) / 2;
                Console.WriteLine(NMedia.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("1-sim 2-nao");
                NovCal = int.Parse(Console.ReadLine());

                while (NovCal != 1 && NovCal != 2) {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    NovCal = int.Parse(Console.ReadLine());
                }

            }  
                       
        }

    }
}
