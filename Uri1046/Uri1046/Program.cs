using System;

namespace Uri1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int HoraIni, HoraFim, DuraJogo;

            string[] vet = (Console.ReadLine().Split());
            HoraIni = int.Parse(vet[0]);
            HoraFim = int.Parse(vet[1]);

            if (HoraIni < HoraFim)
            {
                DuraJogo = HoraFim - HoraIni;
            }
            else {
                DuraJogo = 24 - (HoraIni - HoraFim);
            }

            Console.WriteLine("O JOGO DUROU " + DuraJogo +" HORA(S)");
        }
    }
}
