using System;
using System.Globalization;

namespace uri1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Triangulo, Circulo, Trapezio, Quadrado, Retangulo, Pi=3.14159;
            string[] Vetor;

            Vetor = Console.ReadLine().Split(' ');
            A = double.Parse(Vetor[0],CultureInfo.InvariantCulture);
            B = double.Parse(Vetor[1],CultureInfo.InvariantCulture);
            C = double.Parse(Vetor[2],CultureInfo.InvariantCulture);

            Triangulo = (A * C / 2.0);
            Circulo = Pi*(Math.Pow(C, 2));
            Trapezio = ((A+B)*C)/2;
            Quadrado = Math.Pow(B,2);
            Retangulo = A * B;


            Console.WriteLine("TRIANGULO: " + Triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + Circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + Trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + Quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + Retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
