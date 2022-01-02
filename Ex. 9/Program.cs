using System;

namespace Ex._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = Int32.Parse(Console.ReadLine());
            int restFromModulo;
            string backwardsBinarNumber = "";
            while(userInput > 0)
            {
                restFromModulo = userInput % 2;
                backwardsBinarNumber += restFromModulo.ToString();
                userInput = (userInput - restFromModulo)/2;    
            }
            for(int i=backwardsBinarNumber.Length -1 ; i>= 0; i--)
            {
                Console.Write(backwardsBinarNumber[i]);
            }
        }
    }
}
