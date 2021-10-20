using System;

namespace uRI1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                double segundo = Math.Pow(i,2);
                double terceiro = Math.Pow(i, 3);
                double quarto = segundo + 1;
                double quinto = terceiro + 1;
                Console.WriteLine($"{i} {segundo} {terceiro}");
                Console.WriteLine($"{i} {quarto} {quinto}");
            }
            Console.ReadLine();
        }
    }
}
