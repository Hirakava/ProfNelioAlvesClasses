using System;

namespace Uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] vet = { 0, 1, 1, 2, 3, 5, 8, 13, 21 };

            for (int i = 0; i < n; i++)
            {
                Console.Write(vet[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
