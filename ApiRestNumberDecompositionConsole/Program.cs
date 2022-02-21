using System;

namespace ApiRestNumberDecompositionConsole
{
    class Program
    {
        public static class Constants
        {
            public const int constant = default(int);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Número de Entrada: " + num);

            Console.Write("Números divideres:");
            for (int divider = 1; divider <= num; divider++)
            {
                if ((num % divider) == default(int))
                    Console.Write(" " + divider);
            }

            Console.WriteLine("");
            Console.Write("Divideres Primos:");
            for (int primeDivider = 1; primeDivider <= num; primeDivider++)
            {
                int counter = Constants.constant;

                if ((num % primeDivider) == default(int))
                {
                    for (int j = 1; j <= primeDivider; j++)
                    {
                        if ((primeDivider % j) == default(int))
                            counter++;
                    }

                    if (counter == 2)
                        Console.Write(" " + primeDivider);
                }
            }
        }
    }
}
