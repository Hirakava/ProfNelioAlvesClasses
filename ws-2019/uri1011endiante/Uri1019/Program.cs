using System;

namespace Uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Horas, Minutos, Segundos, Resto;
            
            N = int.Parse(Console.ReadLine());
            Horas = N / 3600;
            Resto = N % 3600;
            Minutos = Resto / 60;
            Segundos = Resto % 60;

            Console.WriteLine(+ Horas + ":" + Minutos + ":" + Segundos);
        }
    }
}
