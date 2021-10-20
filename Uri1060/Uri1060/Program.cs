using System;
using System.Globalization;

namespace Uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double VUm, VDois, VTres, VQuatro, VCinco, VSeis, ValPos=0;

            VUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VQuatro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VCinco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VSeis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (VUm > 0.0) {
                ValPos = ValPos + 1;
            }
            if (VDois > 0.0) {
                ValPos = ValPos + 1;
            }
            if (VTres > 0.0){
                ValPos = ValPos + 1;
            }
            if (VQuatro > 0.0) {
                ValPos = ValPos + 1;
            }
            if (VCinco > 0.0) {
                ValPos = ValPos + 1;
            }
            if (VSeis > 0.0) {
                ValPos = ValPos + 1;
            }
            Console.WriteLine(ValPos + " valores positivos");
        }
    }
}
