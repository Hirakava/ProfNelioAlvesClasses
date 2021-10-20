using System;

namespace Uri1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num,Ndois,Ntres,Nquatro, Ncinco, pares=0, impares=0, positivos=0, negativos=0;

            Num = int.Parse(Console.ReadLine());
            Ndois = int.Parse(Console.ReadLine());
            Ntres = int.Parse(Console.ReadLine());
            Nquatro = int.Parse(Console.ReadLine());
            Ncinco = int.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                pares++;
            }
            else {
                impares++;
            }
            if (Num > 0) {
                positivos++;
            }
            else if (Num<0){
                negativos++;
            }

            if (Ndois % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (Ndois > 0)
            {
                positivos++;
            }
            else if (Ndois<0)
            {
                negativos++;
            }
            if (Ntres % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (Ntres > 0)
            {
                positivos++;
            }
            else if (Ntres<0)
            {
                negativos++;
            }
            if (Nquatro % 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (Nquatro > 0)
            {
                positivos++;
            }
            else if (Nquatro<0)
            {
                negativos++;
            }
            
            if (Ncinco% 2 == 0)
            {
                pares++;
            }
            else
            {
                impares++;
            }
            if (Ncinco > 0)
            {
                positivos++;
            }
            else if (Ncinco<0)
            {
                negativos++;
            }

            Console.WriteLine(pares + " valor(es) par(es)");
            Console.WriteLine(impares + " valor(es) impar(es)");
            Console.WriteLine(positivos + " valor(es) positivo(s)");
            Console.WriteLine(negativos + " valor(es) negativo(s)");                

            
        }
    }
}