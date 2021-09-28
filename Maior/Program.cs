using System;

namespace Maior
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            //complete declarando as variáveis

            int MAIOR = 0;

            int A = Convert.ToInt32(vet[0]);
            int B = Convert.ToInt32(vet[1]);
            int C = Convert.ToInt32(vet[2]);

            int MAIORAB = (A + B + Math.Abs(A - B)) / 2;

            if (MAIORAB > C)
            {
                MAIOR = MAIORAB;
            }
            else
            {
                MAIOR = C;
            }

            Console.WriteLine($"{MAIOR} eh o maior");
        }
    }
}
