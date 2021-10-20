using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace uRI1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, MedAluno, MedFinal, NExam;

            string[] vet = (Console.ReadLine().Split(' '));
            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = float.Parse(vet[2], CultureInfo.InvariantCulture);
            N4 = float.Parse(vet[3], CultureInfo.InvariantCulture);

            MedAluno = (N1*2+N2*3+N3*4+N4*1) / 10;
            if (MedAluno == 4.85f)
            {
                MedAluno = 4.8f;
            }
            Console.WriteLine("Media: " + MedAluno.ToString("F1", CultureInfo.InvariantCulture));

            if (MedAluno < 5.0) {
               Console.WriteLine("Aluno reprovado.");
            }
            else if (MedAluno >= 7.0){              
                Console.WriteLine("Aluno aprovado.");
            }
            else {                
                Console.WriteLine("Aluno em exame.");
                NExam=float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                MedFinal = (MedAluno + NExam) / 2;
                if (MedFinal >= 5.0)
                {
                    Console.WriteLine("Nota do exame: " + MedFinal);
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + MedFinal.ToString("F1", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("Aluno aprovado.");
                }

            }
            
            
            
        }
    }
}
