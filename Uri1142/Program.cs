using System;

namespace Uri1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, inicio = 1, i, segundo=0, terceiro=0;

            n = int.Parse(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                
                segundo = inicio + 1;
                terceiro = inicio + 2;
                Console.WriteLine(inicio + " " + segundo + " " + terceiro + " PUM");
                inicio = inicio + 4;
            }
            Console.ReadLine();
        }
    }
}
