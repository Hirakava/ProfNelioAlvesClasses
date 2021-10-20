using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;
            //Declaracao dA MATRIZ
            int[,] A;

            M = int.Parse(Console.ReadLine());
            N = int.Parse(Console.ReadLine());
            A = new int[M,N];

            //Manipulando dados para colocar na Matriz
            //Como é feito um de cada vez, voce lida como se fosse um vetor, um para linha outro coluna

            for (int i = 0; i < M; i++) {
                // s, vetorzinho para linha
                string[] s = Console.ReadLine().Split(' ');
                // outro for para coluna 
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);                
                }
            }

            for (int i = 0; i = M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.WriteLine(A[i,j]+ " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
