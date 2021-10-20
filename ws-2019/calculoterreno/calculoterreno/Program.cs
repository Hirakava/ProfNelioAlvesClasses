using System;
using System.Globalization;

namespace calculoterreno
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseterreno, altura, area, preco, valormetroquadrado;

            Console.WriteLine("Informe Base em Metros : ");
            baseterreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe Altura em Metros : ");
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe Valor do Metro Quadrado em Reais : ");
            valormetroquadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = baseterreno * altura;
            preco = valormetroquadrado * area;


            Console.WriteLine("Area Total do Terreno : " + area.ToString("F2", CultureInfo.InvariantCulture) + " M2 ");
            Console.WriteLine("Preco Total do Terreno : R$" + preco.ToString("F2", CultureInfo.InvariantCulture) + " Reais ");
        }
    }
}
