using System;

namespace Ex_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 8: ");
            Console.WriteLine("Matematyka: ");
            byte mathScore = byte.Parse(Console.ReadLine());
            Console.WriteLine("Fizyka: ");
            byte physicScore = byte.Parse(Console.ReadLine());
            Console.WriteLine("Chemia: ");
            byte chemistryScore = byte.Parse(Console.ReadLine());
            if (((mathScore + physicScore + chemistryScore) > 180 && (mathScore > 70 && physicScore > 55 && chemistryScore > 45)) || (((mathScore + physicScore) > 150) || ((mathScore + chemistryScore) > 150)))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }
        }
    }
}
