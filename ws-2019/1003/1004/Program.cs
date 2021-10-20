using System;

namespace _1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod, valor1, valor2;
            valor1 = int.Parse(Console.ReadLine());
            valor2 = int.Parse(Console.ReadLine());
            prod = valor1 * valor2;

            Console.WriteLine("PROD = " +prod);
        }
    }
}
