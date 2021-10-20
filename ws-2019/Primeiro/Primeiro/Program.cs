using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.WriteLine("Ola Mundo!");
            Console.Write("Bom dia!");
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F2"));
            Console.WriteLine(x.ToString("F4"));
            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("RESULTADO = " +x);
            Console.WriteLine("O Valor do Troco é " + x + " Reais ");
            Console.WriteLine("O Valor do Troco é " + x.ToString("F2") + " Reais ");

            Console.WriteLine();
            Console.WriteLine("A Paciente " + z + " tem " + y + " anos e é do Sexo: " + w);

            Console.ReadLine();

        }
    }
}
