using System;

namespace uri1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int HorasT, MinT, HoraIni, MinIni, HoraFim, MinFim,TmpIni, TmpFim, Duracao, TmpMin, TmpHora;

            string[] vet = Console.ReadLine().Split(' ');
            HoraIni = int.Parse(vet[0]);
            MinIni = int.Parse(vet[1]);
            HoraFim = int.Parse(vet[2]);
            MinFim = int.Parse(vet[3]);

            TmpIni = HoraIni * 60 + MinIni;
            TmpFim = HoraFim*60 + MinFim;

            if (TmpIni < TmpFim)
            {
                Duracao = TmpFim - TmpIni;
            }
            else {
                Duracao = (24 * 60 - TmpIni) + TmpFim;
            }

            TmpHora = Duracao / 60;
            TmpMin = Duracao % 60;

            Console.WriteLine("O JOGO DUROU " + TmpHora + " HORA(S) E " + TmpMin + " MINUTO(S)");
        }
    }
}
