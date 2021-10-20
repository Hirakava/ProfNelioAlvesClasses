using System;
using System.Globalization;
using System.Xml.Schema;

namespace Uri1038b
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodPedido, QdePed;
            double ValTotal;

            string[] vet = Console.ReadLine().Split(' ');

            CodPedido = int.Parse(vet[0]);
            QdePed = int.Parse(vet[1]);            

            switch (CodPedido) {
                case 1:
                    ValTotal = QdePed * 4.00;
                    break;
                case 2:
                    ValTotal = QdePed * 4.50;
                    break;
                case 3:
                    ValTotal = QdePed * 5.00;
                    break;
                case 4:
                    ValTotal = QdePed * 2.00;
                    break;
                default:
                    ValTotal = QdePed * 1.50;
                    break;
                                        
            }
            Console.WriteLine("Total: R$ " + ValTotal.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
