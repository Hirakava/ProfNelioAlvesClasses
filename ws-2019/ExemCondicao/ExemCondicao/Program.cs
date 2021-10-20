using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace ExemCondicao
{
    class Program
    {
        static void Main(string[] args)
        {
            double Soma, Nota1, Nota2;

            Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Soma = Nota1 + Nota2;

            Console.WriteLine("NOTA FINAL = " + Soma.ToString("F1", CultureInfo.InvariantCulture));

            if (Soma < 60.0)
            {
                Console.WriteLine("REPROVADO");
            }

        }
    }
}
