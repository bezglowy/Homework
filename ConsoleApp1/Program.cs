using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Console.WriteLine("Podaj pierwszą zmienną: ");
            int variable1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą zmienną: ");
            int variable2 = int.Parse(Console.ReadLine());
            if (variable1 == variable2)
            {
                Console.WriteLine($"{variable1} i {variable2} są równe");
            }
            else
            {
                Console.WriteLine($"Zmienne {variable1} i {variable2} są różne");
            }

            if (variable1 > variable2)
            {
                Console.WriteLine($"{variable1} jest większe od {variable2}");
            }
            else
            {
                {
                    Console.WriteLine($"{variable2} jest większe od {variable1}");
                }
            }
        }
    }
}
