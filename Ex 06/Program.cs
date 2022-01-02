using System;

namespace Ex_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6: ");
            Console.WriteLine("Podaj wzrost w cm: ");
            ushort height = ushort.Parse(Console.ReadLine());
            if (height <= 156)
            {
                Console.WriteLine("Jesteś karłem");
            }
            else if (height > 156 && height <= 164)
            {
                Console.WriteLine("Jesteś niskiego wzrostu");
            }

            else if (height > 164 && height <= 169)
            {
                Console.WriteLine("Jesteś średniego wzrostu");
            }

            else if (height > 169 && height <= 177)
            {
                Console.WriteLine("Jesteś wysokiego wzrostu");
            }
            else
            {
                Console.WriteLine("Jesteś bardzo wysokiego wzrostu");
            }
        }
    }
}
