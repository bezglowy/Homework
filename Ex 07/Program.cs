using System;

namespace Ex_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 7: ");
            Console.WriteLine("Podaj liczby: ");
            int firstNumberToCompare = int.Parse(Console.ReadLine());
            int secondNumberToCompare = int.Parse(Console.ReadLine());
            int thirdNumberToCompare = int.Parse(Console.ReadLine());
            int biggestNumber = Math.Max(firstNumberToCompare, secondNumberToCompare);
            biggestNumber = Math.Max(biggestNumber, thirdNumberToCompare);
            Console.WriteLine($"{biggestNumber} jest największą z podanych");
        }
    }
}
