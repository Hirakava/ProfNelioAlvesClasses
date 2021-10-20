using System;

namespace Uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, i, conIn=0, conOut=0;

            n = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    conIn = conIn + 1;
                }
                else 
                {
                    conOut = conOut + 1;
                }                
            }
            Console.WriteLine(conIn + " in");
            Console.WriteLine(conOut + " out");
            Console.ReadLine();
        }
    }
}
