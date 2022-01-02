using System;

namespace Ex._10
{
    class Program
    {
        static void Main(string[] args)
        {
            /* First method */
            /*
            Console.WriteLine("Podaj dwie liczby by znaleźć ich NWW");
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            static int nww(int a, int b)
            {
                if(b>a)
                {
                    return nww(b, a);
                }
                int k = a;
                while(k % b != 0)
                {
                    k += a;
                }
                return k;
            }
            Console.Write(nww(firstNumber, secondNumber));
            */
            /* Second Method */
            Console.WriteLine("Podaj dwie liczby by znaleźć ich NWW");
            int firstNumber = Int32.Parse(Console.ReadLine());
            int secondNumber = Int32.Parse(Console.ReadLine());
            int nww;
            static int NWD(int a, int b)
            {
                if(a < b)
                {
                    return NWD(b, a);
                }
                int rest;
                while (a % b != 0)
                {
                    rest = a % b;
                    a = b;
                    b = rest;
                }
                return b;
            }
            Console.WriteLine("Największy wspólny dzielnik NWD to: " + NWD(firstNumber, secondNumber));
            nww = (firstNumber * secondNumber) / NWD(firstNumber, secondNumber);
            Console.WriteLine("Najmniejsza wspólna wielokrotność to: " + nww);


        }
    }
}
