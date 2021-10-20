using System;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int Grem, Inter, Jogo, Grenal, ContGrem, ContInter, Empat;

            Jogo = 1;
            Grenal = 0;
            ContGrem = 0;
            ContInter = 0;
            Empat = 0;

            while (Jogo == 1) {

                string[] vet = (Console.ReadLine().Split());
                Inter = int.Parse(vet[0]);
                Grem = int.Parse(vet[1]);

                if (Grem > Inter)
                {
                    ContGrem=ContGrem+1;
                }
                else if (Inter > Grem)
                {
                    ContInter=ContInter+1;
                }
                else {
                    Empat=Empat+1;
                }
                Grenal=ContInter+ContGrem+Empat;
                               
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                Jogo = int.Parse(Console.ReadLine());
            } 

            Console.WriteLine(Grenal + " grenais");
            Console.WriteLine("Inter:" + ContInter);
            Console.WriteLine("Gremio:" + ContGrem);
            Console.WriteLine("Empates:" + Empat);
            if (ContInter > ContGrem)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else {
                Console.WriteLine("Gremio venceu mais");
            }

        }
    }
}
