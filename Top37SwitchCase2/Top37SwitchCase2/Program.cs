using System;

namespace Top37SwitchCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; string dia;

            x = int.Parse(Console.ReadLine());

            switch (x) {
                case 1:
                    dia = "Domingo";
                    break;
                case 2:
                    dia = "Segunda";
                    break;
                case 3:
                    dia = "Terça";
                    break;
                case 4:
                    dia = "Quarta";
                    break;
                case 5:
                    dia = "Quinta";
                    break;
                case 6:
                    dia = "Sexta";
                    break;
                case 7:
                    dia = "Sabado"; ;
                    break;
                default:
                    dia = "Inválido ";
                    break;


            }

            
            Console.WriteLine("Dia da Semana: " +dia);
        }
    }
}
