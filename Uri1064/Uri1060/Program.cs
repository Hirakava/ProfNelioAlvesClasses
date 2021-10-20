using System;
using System.Globalization;

namespace Uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double VUm, VDois, VTres, VQuatro, VCinco, VSeis, ValPos=0.0, MedValPos, Soma=0.0;

            VUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VQuatro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VCinco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VSeis = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (VUm > 0.0) {
                ValPos = ValPos + 1;
                Soma = Soma + VUm;
            }
            if (VDois > 0.0) {
                ValPos = ValPos + 1;
                Soma = Soma + VDois;
            }
            if (VTres > 0.0){
                ValPos = ValPos + 1;
                Soma = Soma + VTres;
            }
            if (VQuatro > 0.0) {
                ValPos = ValPos + 1;
                Soma = Soma + VQuatro;
            }
            if (VCinco > 0.0) {
                ValPos = ValPos + 1;
                Soma = Soma + VCinco;
            }
            if (VSeis > 0.0) {
                ValPos = ValPos + 1;
                Soma = Soma + VSeis;
            }
            MedValPos = Soma / ValPos;
            Console.WriteLine(ValPos + " valores positivos");
            Console.WriteLine(MedValPos.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
