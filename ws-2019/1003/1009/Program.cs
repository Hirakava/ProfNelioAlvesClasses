using System;
using System.Globalization;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string Vendedor;
            double TotalFuncionario, SalarioFixo, TotalDeVendas;

            Vendedor = Console.ReadLine();
            SalarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TotalFuncionario = SalarioFixo + (TotalDeVendas*0.15);

            Console.WriteLine("TOTAL = R$ " + TotalFuncionario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
