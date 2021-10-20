using System;
using System.Linq.Expressions;

namespace ExemploResolvido3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Val1, Val2, Val3;
            string[] vetor = Console.ReadLine().Split(' ');
            Val1 = int.Parse(vetor[0]);
            Val2 = int.Parse(vetor[1]);
            Val3 = int.Parse(vetor[2]);

            if (Val1 <= Val2 && Val1 <= Val3) 
            {
                Console.WriteLine("MENOR = " + Val1);
            }
            else if (Val2 <= Val1 && Val2 <= Val3) 
            { 
                Console.WriteLine("MENOR = " + Val2);
            }
            else if (Val3<=Val1 && Val3 <= Val2)
            { 
                 Console.WriteLine("MENOR = " + Val3);
            } 
            
        }
    }
}
