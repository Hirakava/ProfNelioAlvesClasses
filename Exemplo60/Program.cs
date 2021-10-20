using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo60
{
    class Program
    {
        static void Main(string[] args) {
            int N;
            N = int.Parse(Console.ReadLine());
            string[] vet = new string[N];

            for (int i = 0; i < N; i++) {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos:");
            for (int i = 0; i < N; i++) {
                Console.WriteLine(vet[i]);    
            }
            Console.ReadLine();
        }
    }
}
