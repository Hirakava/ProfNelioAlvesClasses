using System;
using System.Globalization;

namespace ExemploResolvido01b
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, NotaFinal;

            Nota1=double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            NotaFinal = Nota1 + Nota2;
            if (NotaFinal <= 60.00)
            {
                Console.WriteLine("NOTA FINAL = " + NotaFinal);
                Console.WriteLine("REPROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + NotaFinal.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
