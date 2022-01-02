using System;

namespace Ex._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am here to show you how fibonacci sequence looks like... ");
            Console.WriteLine("...but first, tell me how many numbers you want to see? ");
            int amountNumber = int.Parse(Console.ReadLine());
            int firstSeqNumber = 0;
            int secondSeqNumber = 1;
            int nextNumber;
            for (int i = 0; i < amountNumber; i++)
            {
                Console.WriteLine(firstSeqNumber);
                nextNumber = firstSeqNumber + secondSeqNumber;
                firstSeqNumber = secondSeqNumber;
                secondSeqNumber = nextNumber;

            }
        }
    }
}
