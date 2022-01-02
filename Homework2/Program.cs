using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 12: ");
            Console.WriteLine("Podaj dzień tygodnia: ");
            byte numberOfDay = byte.Parse(Console.ReadLine());
            string numberOfDayResult = numberOfDay switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Nieprawidłowy format wejściowy",
            };
            Console.WriteLine(numberOfDayResult);

        }
    }
}
