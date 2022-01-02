using System;

namespace Ex_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3: ");
            int variable3 = int.Parse(Console.ReadLine());
            int evenOrOdd = Math.Sign(variable3);
            if (evenOrOdd == -1)
            {
                Console.WriteLine("Liczba jest ujemna.");
            }
            else if (evenOrOdd == 1)
            {
                Console.WriteLine("Liczba jest dodatnia.");
            }
            else
            {
                Console.WriteLine("Liczba jest równa 0.");
            }
        }
    }
}
