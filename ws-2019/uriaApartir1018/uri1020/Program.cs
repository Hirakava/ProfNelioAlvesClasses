using System;
using System.Diagnostics.Tracing;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int RestoAnos, Anos, Meses, Dias, Idade;
            Idade = int.Parse(Console.ReadLine());

            Anos = Idade / 365;
            RestoAnos = Idade % 365;
            Meses = RestoAnos / 30;
            Dias=RestoAnos % 30;
                      
            Console.WriteLine(Anos +" ano(s)");
            Console.WriteLine(Meses +" mes(es)");
            Console.WriteLine(Dias +" dia(s)");
        }
    }
}
