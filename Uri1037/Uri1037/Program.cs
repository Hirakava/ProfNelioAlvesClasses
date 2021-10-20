using System;
using System.Globalization;

namespace Uri1037
{
    class Program
    {
        static void Main(string[] args)
        {
            float Valor;

            Valor=float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (Valor >= 0.0 && Valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (Valor >= 25.0 && Valor <= 50.0)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (Valor >= 50.0 && Valor <= 75.0)
            {
                Console.WriteLine("Intervalor [50,75]");
            }
            else if(Valor >= 75.0 && Valor <= 100)
            {
                Console.WriteLine("Intervalo [75,100]");
            }
            else 
            {
                Console.WriteLine("Fora de Intervalo");
            }
               


        }
    }
}
