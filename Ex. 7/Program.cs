using System;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's draw something! Give me a number: ");
            int.TryParse(Console.ReadLine(), out int number);
            int numberOfRows = 0;
            for (int i = 0; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = (number - i)/2 ; j >0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();
                numberOfRows += 1;
            }
            for (int i = numberOfRows -1 ; i > 0; i--)
            {
                for (int j = 1 ; j <= numberOfRows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j < i * 2 ; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }


        }
    }
}
