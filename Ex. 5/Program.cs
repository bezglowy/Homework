using System;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I display numbers from 1 to 20 raised to the third power!:");
            for (int i = 1; i < 21; i++)
            {
                Console.Write(Math.Pow(i, 3) + " ");
            }
        }
    }
}
