using System;
using System.Globalization;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {
            double ValorAPagar, ValorUnitarioVet1, ValorUnitarioVet2, SubtotalPeca1, SubtotalPeca2 ;
            int CodigoPecaVet1, CodigoPecaVet2, QuantidadePecaVet1, QuantidadePecaVet2;

            string[] Vetor1 = Console.ReadLine().Split(' ');
            string[] Vetor2 = Console.ReadLine().Split(' ');
            
            CodigoPecaVet1 = int.Parse(Vetor1[0]);
            QuantidadePecaVet1 = int.Parse(Vetor1[1]);
            ValorUnitarioVet1 = double.Parse(Vetor1[2], CultureInfo.InvariantCulture);
            SubtotalPeca1 = QuantidadePecaVet1 * ValorUnitarioVet1;

            CodigoPecaVet2 = int.Parse(Vetor2[0]);
            QuantidadePecaVet2 = int.Parse(Vetor2[1]);
            ValorUnitarioVet2 = double.Parse(Vetor2[2], CultureInfo.InvariantCulture);
            SubtotalPeca2 = QuantidadePecaVet2 * ValorUnitarioVet2;


            ValorAPagar = SubtotalPeca1 + SubtotalPeca2;
           
            Console.WriteLine("VALOR A PAGAR: R$ " + ValorAPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
