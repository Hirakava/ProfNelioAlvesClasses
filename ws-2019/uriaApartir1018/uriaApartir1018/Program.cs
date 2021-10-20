using System;
using System.Xml;

namespace uriaApartir1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int RestoDois, RestoCinco, RestoDez, RestoVinte, RestoCinquenta, N, NotaCem, NotaCinquenta, NotaVinte, NotaDez, NotaCinco, NotaDois, NotaUm, RestoCem;

            N = int.Parse(Console.ReadLine());
           
            NotaCem=N/100;
            RestoCem=N%100;
            NotaCinquenta=RestoCem/50;
            RestoCinquenta=RestoCem%50;
            NotaVinte=RestoCinquenta/20;
            RestoVinte=RestoCinquenta%20;
            NotaDez=RestoVinte/10;
            RestoDez=RestoVinte%10;
            NotaCinco=RestoDez/5;
            RestoCinco=RestoDez%5;
            NotaDois=RestoCinco/2;
            RestoDois=RestoCinco%2;
            NotaUm=RestoDois/1;
            
            Console.WriteLine(N);
            Console.WriteLine(NotaCem +" nota(s) de R$ 100,00");
            Console.WriteLine(NotaCinquenta +" nota(s) de R$ 50,00");
            Console.WriteLine(NotaVinte +" nota(s) de R$ 20,00");
            Console.WriteLine(NotaDez +" nota(s) de R$ 10,00");
            Console.WriteLine(NotaCinco +" nota(s) de R$ 5,00");
            Console.WriteLine(NotaDois +" nota(s) de R$ 2,00");
            Console.WriteLine(NotaUm +" nota(s) de R$ 1,00");
        }
    }
}
