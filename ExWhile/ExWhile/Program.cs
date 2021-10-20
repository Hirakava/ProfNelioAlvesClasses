using System;
using System.Globalization;

namespace ExWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double Idade, Soma=0.0, Media;
            int Cont = 0;

            Idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            while (Idade >= 0) {
                Soma = Soma + Idade;
                Cont = Cont + 1;
                Idade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            if (Cont == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else {
                Media = Soma / Cont;
                Console.WriteLine(Media.ToString("F2",CultureInfo.InvariantCulture));
            }
            
        }
    }
}
