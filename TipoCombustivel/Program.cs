using System;

namespace TipoCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int opcao = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (opcao)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        continue;
                    default:
                        break;
                }
                opcao = Convert.ToInt32(Console.ReadLine());
                
            } while (opcao != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
