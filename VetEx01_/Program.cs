using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace VetEx01_
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
            
            string[] valores = Console.ReadLine().Split(' ');

                for (int i = 0; i < N; i++) {
                    vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    vet[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);
                }
                
                double maior = vet[0];
                int posicaoMaior = 0;

                for (int i = 1; i < N; i++) {
                    if (vet[i]) > maior) {
                         maior = vet[i];
                            posicaoMaior = i;
                    }
                }          
        
                Console.WriteLine(maior.ToString("F1", Cultureinfo.InvariantCulture));
                Console.WriteLine(posicaoMaior);
        }
    }
}
