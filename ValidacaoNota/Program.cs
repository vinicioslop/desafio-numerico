using System;

class Program
{
    static void Main(string[] args)
    {
        double somaDasNotas = 0;
        int contador = 0;

        do
        {
            double notaEntradaConsole = double.Parse(Console.ReadLine());

            if (notaEntradaConsole < 0 || notaEntradaConsole > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else
            {
                contador++;
                somaDasNotas += notaEntradaConsole;
            }
        } while (contador < 2);

        Console.WriteLine("media = " + (somaDasNotas / 2).ToString("N2"));
    }
}
