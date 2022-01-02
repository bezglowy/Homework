using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2:");
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            string score;

            /* First method

            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
            */
            // Second method
            score = (number % 2 == 0) ? "Liczba jest parzysta" : "Liczba jest nieparzysta";
            Console.WriteLine(score);
        }
    }
}
