using System;

namespace Ex_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 10: ");
            Console.WriteLine("Podaj długości boków trójkąta w kolejności od najmniejszej do największej: ");
            uint firstSide = uint.Parse(Console.ReadLine());
            uint secondSide = uint.Parse(Console.ReadLine());
            uint thirdSide = uint.Parse(Console.ReadLine());
            if ((firstSide + secondSide) > thirdSide)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Trójkąt nie może być zbudowany");
            }
        }
    }
}
