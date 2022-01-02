using System;

namespace Lesson_8
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am checking prime numbers from 0 to 100");
            for (int i = 0; i <= 100; i++)
            {
                if (i==0 || i ==1)
                {
                    continue;
                }
                else
                {
                    int temp = 0;
                    for (int j = 2; j <= i/2; j++)
                    {
                        if((i % j) == 0)
                        {
                            temp++;
                            break;
                        }
                    }
                    if(temp ==0 && temp != 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
