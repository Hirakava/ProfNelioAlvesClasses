﻿using System;

namespace ExTop37SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            x = int.Parse(Console.ReadLine());
            string dia;

            if (x == 1)
            {
                dia = "Domingo";
            }
            else if (x == 2)
            {
                dia = "Segunda";
            }
            else if (x == 3)
            {
                dia = "Terca";
            }
            else if (x == 4)
            {
                dia = "Quarta";
            }
            else if (x == 5)
            {
                dia = "Quinta";
            }
            else if (x == 6)
            {
                dia = "Sexta";
            }
            else {
                dia = "Dia da Semana Inválido";            
            }
            
            Console.WriteLine("dia da Semana " + dia);
        }
    }
}
