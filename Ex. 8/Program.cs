using System;

namespace Ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            for (int i = userInput.Length -1 ; i>=0 ; i--)
            {
                if (i == userInput.Length - 1)
                {
                    Console.Write(char.ToUpper(userInput[i]));
                }

                else
                {
                    Console.Write(char.ToLower(userInput[i]));
                }

            }
        }
    }
}
