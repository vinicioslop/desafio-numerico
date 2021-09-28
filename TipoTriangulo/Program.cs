using System;

namespace TipoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a = double.Parse(s[0]);
            double b = double.Parse(s[1]);
            double c = double.Parse(s[2]);

            double[] lado = new double[3];

            if (a > b)
                if (b > c)
                {
                    lado[0] = a;
                    lado[1] = b;
                    lado[2] = c;
                }
                // a>b>c
                else if (a > c)
                {
                    lado[0] = a;
                    lado[1] = c;
                    lado[2] = b;
                }
                else
                {
                    lado[0] = c;
                    lado[1] = a;
                    lado[2] = b;
                }
            else if (b > c)
            {
                if (a > c)
                {
                    lado[0] = b;
                    lado[1] = a;
                    lado[2] = c;
                }
                else
                {
                    lado[0] = b;
                    lado[1] = c;
                    lado[2] = a;
                }
            }
            else
            {
                lado[0] = c;
                lado[1] = b;
                lado[2] = a;
            }

            //continue a solucao
            if (!(a + b > c && a + c > b && b + c > a))
                Console.WriteLine("NAO FORMA TRIANGULO");
            else if (Math.Pow(lado[0], 2) == (Math.Pow(lado[1], 2) + Math.Pow(lado[2], 2)))
                Console.WriteLine("TRIANGULO RETANGULO");
            else if (Math.Pow(lado[0], 2) < (Math.Pow(lado[1], 2) + Math.Pow(lado[2], 2)))
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            else if (Math.Pow(lado[0], 2) > (Math.Pow(lado[1], 2) + Math.Pow(lado[2], 2)))
                Console.WriteLine("TRIANGULO ACUTANGULO");
            if (lado[0] == lado[1] && lado[0] == lado[2] && lado[1] == lado[2])
                Console.WriteLine("TRIANGULO EQUILATERO");
            if (lado[0] == lado[1] || lado[0] == lado[2] || lado[2] == lado[1])
                Console.WriteLine("TRIANGULO ISOSCELES");

            Console.ReadLine();
        }
    }
}
