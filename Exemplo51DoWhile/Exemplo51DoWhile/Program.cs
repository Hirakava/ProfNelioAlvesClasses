using System;
using System.Globalization;


namespace Exemplo51DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            char repetir='s';

            do
            {
                Console.Write("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja Repetir (s/n)? ");
                Console.WriteLine("");
                repetir = char.Parse(Console.ReadLine());
            }
            while (repetir == 's');
            Console.ReadLine();
        }
    }
}
