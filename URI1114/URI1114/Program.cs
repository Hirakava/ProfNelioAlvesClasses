using System;

namespace URI1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int Senha;

            Senha = int.Parse(Console.ReadLine());
            while (Senha != 2002)
            
            {
                Console.WriteLine("Senha Invalida");
                Senha = int.Parse(Console.ReadLine());
            }       
            
            Console.WriteLine("Acesso Permitido");
        }
    }
}
