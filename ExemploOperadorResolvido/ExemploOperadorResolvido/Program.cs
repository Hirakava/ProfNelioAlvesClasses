using System;
using System.Globalization;

namespace ExemploOperadorResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            int Minutos;
            double ValExcedente;

            Minutos = int.Parse(Console.ReadLine());
            if (Minutos <= 100){
                Console.WriteLine("Valor a Pagar: R$ 50.00");
            }
            else {
                ValExcedente = (((Minutos - 100)*2.00)+50.00);

                Console.WriteLine("Valor a Pagar: R$ " + ValExcedente.ToString("F2",CultureInfo.InvariantCulture));
            }
            
        }
    }
}
