using System;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am searching for all odd numeber from 0 to 1000");
            int startNumber = 0;
            do
            {
                if (startNumber % 2 == 0)
                {
                    Console.Write(startNumber + " ");
                }
                startNumber++;
            }
            while (startNumber <= 1000);
        }
    }
}
