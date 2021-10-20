using System;
using System.Globalization;

namespace uri1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double SalFunc, NovoSal, ReajGanho, Perc;

            SalFunc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (SalFunc <= 400.00)
            {
                Perc = 15.00;
            }
            else if (SalFunc <= 800.00)
            {
                Perc = 12.00;
            }
            else if (SalFunc <= 1200.00)
            {
                Perc = 10.00;
            }
            else if (SalFunc <= 2000.00)
            {
                Perc = 7.00;
            }
            else {
                Perc = 4.00;
            }


            ReajGanho = SalFunc * Perc / 100.0;
            NovoSal = SalFunc + ReajGanho;
             

            Console.WriteLine("Novo salario: " + NovoSal.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + ReajGanho.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + Perc + " %");
        }
    }
}
