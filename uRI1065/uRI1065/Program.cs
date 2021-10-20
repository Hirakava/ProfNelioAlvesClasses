using System;

namespace uRI1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int VUm, VDois, VTres, VQuatro, VCinco, Cont = 0;

            VUm = int.Parse(Console.ReadLine());
            VDois = int.Parse(Console.ReadLine());
            VTres = int.Parse(Console.ReadLine());
            VQuatro = int.Parse(Console.ReadLine());
            VCinco  = int.Parse(Console.ReadLine());

            if (VUm % 2 == 0) {
                Cont = Cont + 1;
            }
            if (VDois % 2 == 0) {
                Cont = Cont + 1;
            }
            if (VTres % 2 == 0) {
                Cont = Cont + 1;
            }
            if (VQuatro % 2 == 0) {
                Cont = Cont + 1;
            }
            if (VCinco % 2 ==0) {
                Cont = Cont + 1;
            }
               
            Console.WriteLine(Cont + " valores pares");
        }
    }
}
