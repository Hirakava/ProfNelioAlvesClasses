using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExVet01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int QdeElemento = int.Parse(Console.ReadLine());

            double[] vet = new double[QdeElemento]; 
                           
            string[] valores =   Console.ReadLine().Split(' ');
            
            for (int i = 0; i < QdeElemento; i++) { 
                vet[i]=double.Parse(valores[i],CultureInfo.InvariantCulture);  //converteu o vetor de string em double
            }

            double ElMaior = vet[0];
            int ElPosMaior = 0;

            for (int i = 1; i < QdeElemento; i++) {
                if (vet[i] > ElMaior) {
                    ElMaior = vet[i];
                    ElPosMaior = i;
                }            
            }

            Console.WriteLine(ElMaior.ToString("F1",CultureInfo.InvariantCulture));
            Console.WriteLine(ElPosMaior);
            Console.ReadLine();
        }
    }
}
