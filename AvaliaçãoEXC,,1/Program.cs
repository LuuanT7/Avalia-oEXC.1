using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaçãoEXC__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notat, nota1, nota2, media;
            string aluno;
            Console.WriteLine("Digite o nome do Aluno: ");
            aluno = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(aluno);
            Console.WriteLine("Digite a nota do trabalho: ");
            notat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());
            media = (notat + nota1 + nota2) / 3;

            if (media >= 8.5 || media == 10)
            {
                Console.WriteLine("Media " + media + ", Conceito A.");
            }
            else if (media >= 7 || media <= 8.4)
            {
                Console.WriteLine("Media " + media + ", Conceito B.");
            }
            else if (media >= 6 || media <= 6.9)
            {
                Console.WriteLine("Media " + media + ", Conceito C.");
            }
            else if (media >= 0.1 || media <= 5.9)
            {
                Console.WriteLine("Media " + media + ", Conceito D.");
            }

            else
            {
                Console.WriteLine("Media " + media + ", Conceito E.");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
