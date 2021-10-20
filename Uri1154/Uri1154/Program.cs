using System;
using System.Globalization;

namespace Uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int Idade, cont=0,IdadeSoma = 0; double MedIdade;

            Idade = int.Parse(Console.ReadLine());
            while (Idade > 0) {
                IdadeSoma = IdadeSoma + Idade;
                cont++;
                Idade = int.Parse(Console.ReadLine());

            }
            MedIdade = (double)IdadeSoma / cont;
            Console.WriteLine(MedIdade.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
