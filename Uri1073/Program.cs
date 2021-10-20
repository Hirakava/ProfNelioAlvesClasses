using System;

namespace Uri1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, quadrado;
            n = int.Parse(Console.ReadLine());

            for ( i = 2; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    quadrado = i * i;
                    Console.WriteLine(i + "^2=" + quadrado);
                }
            }            
        }
    }
}
