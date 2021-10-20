using System;

namespace Uri1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int X,Soma=0;

            X = int.Parse(Console.ReadLine());

            while (X != 0) {

                if (X % 2 != 0)
                {
                    X = X + 1;
                }                
                Soma = X + X + 2 + X + 4 + X + 6 + X + 8;
                Console.WriteLine(Soma);
                X = int.Parse(Console.ReadLine());


            }
            
        }
    }
}
