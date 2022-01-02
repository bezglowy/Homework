using System;

namespace Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            for (decimal i = 1; i < 21; i++)
            {
                decimal partSum = 1 / i;
                sum += partSum;
            }
            Console.WriteLine("Suma wg wzoru 1 + 1/2 +1/3 + 1/4 +... jest równa: " + Math.Round(sum, 2));
        }
    }
}