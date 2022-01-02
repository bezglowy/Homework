using System;

namespace Ex_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4: ");
            string leapYear = DateTime.IsLeapYear(int.Parse(Console.ReadLine())) ? "Rok jest przestępny" : "Rok nie jest przestępny";
            Console.WriteLine(leapYear);
        }
    }
}
