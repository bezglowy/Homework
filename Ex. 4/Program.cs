using System;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me one number if you want to see something cool: ");
            Int32.TryParse(Console.ReadLine(), out int inputNumber);
            int temp = 1;
            for (int i = 1; temp <= inputNumber ; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (temp <= inputNumber)
                    {
                        Console.Write(temp + " ");
                    }
                    temp++;
                }
                Console.WriteLine();

            }
        }
    }
}
