using System;

namespace Ex_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 5: ");
            byte age = byte.Parse(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("Możesz zostać posłem");
                Console.WriteLine("Czy posiadasz IQ powyżej 100?");
                string iq = Console.ReadLine();
                if (iq == "nie")
                {
                    Console.WriteLine("Możesz zostać premierem");
                }
                if (age >= 30)
                {
                    Console.WriteLine("Możesz zostać senatorem");
                }
                if (age >= 35)
                {
                    Console.WriteLine("Możesz zostać prezydentem");
                }

            }
            else
                Console.WriteLine("Możesz tylko obserwować i się denerowować. Jesteś zbyt młody");
        }
    }
}
