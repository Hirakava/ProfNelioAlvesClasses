using System;
using System.Globalization;

namespace aula18exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome Completo: ");
            string nome = (Console.ReadLine());
            Console.WriteLine("Quantos quartos tem em sua casa? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com Preco do seu Produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
           
            Console.WriteLine("Entre com seu Ultmo Nome, idade e Altura (mesma Linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string lastname = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco);
            Console.WriteLine(lastname);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

                  
          
            
            
        }
    }
}
