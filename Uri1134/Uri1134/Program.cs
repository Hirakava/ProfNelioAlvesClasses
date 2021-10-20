using System;

namespace Uri1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodCo, Alco=0, Gaso=0, Diesel=0;

            CodCo = int.Parse(Console.ReadLine());

            while (CodCo != 4) {
                if (CodCo == 1)
                {
                    Alco = Alco + 1;
                }
                else if (CodCo == 2)
                {
                    Gaso = Gaso + 1;
                }
                else if (CodCo == 3) {
                    Diesel = Diesel + 1;
                }
                CodCo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + Alco);
            Console.WriteLine("Gasolina: " + Gaso);
            Console.WriteLine("Diesel: " + Diesel);
        }
    }
}
