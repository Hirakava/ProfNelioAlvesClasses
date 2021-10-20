using System;

namespace Uri1153
{
    class Program
    {
        static void Main(string[] args)
        {
            double i,n, fato;
            n = int.Parse(Console.ReadLine());

            fato=n;

            for (i=n-1; i>= 1; i--)
            {                
                fato = fato * i;                                
            }
            Console.WriteLine($"{fato}");
            
        }
    }
}
