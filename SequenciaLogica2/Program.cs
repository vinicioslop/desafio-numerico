using System;

namespace SequenciaLogica2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(vet[0]);
            int b = Convert.ToInt32(vet[1]);

            int posicao = 0;

            //complete o código com sua solução

            for (int i = 1; i <= b; i++)
            {
                if (posicao < a - 1)
                {
                    Console.Write(i + " ");
                    posicao++;
                }
                else
                {
                    Console.Write($"{i}\n");
                    posicao = 0;
                }
            }
        }
    }
}
