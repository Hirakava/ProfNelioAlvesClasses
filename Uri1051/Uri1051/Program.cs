using System;
using System.Globalization;

namespace Uri1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double IrDevido, Salario;

            Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            if (Salario <= 2000.0)
            {
                IrDevido = 0.0;
            }
            else if (Salario <= 3000.0)
            {
                IrDevido = (Salario - 2000.0) * 0.08;
            }
            else if (Salario <= 4500.0)
            {
                IrDevido = (Salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                IrDevido = (Salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
            if (IrDevido == 0.0)
            {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + IrDevido.ToString("F2", CultureInfo.InvariantCulture));
            }                        
               
              
                   
        }
    }
}
