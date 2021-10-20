using System;

namespace Uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int res = n * i;
                Console.WriteLine(i + "X" + n + " = " + res);                
            }
            Console.ReadLine();
        }
    }
}
