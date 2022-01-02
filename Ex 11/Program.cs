using System;

namespace Ex_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 11: ");
            Console.WriteLine("Podaj ocenę w skali 1-6: ");
            byte schoolDegree = byte.Parse(Console.ReadLine());

            /* Method 1-st */
            /* switch (schoolDegree)
             {
                 case 1:
                     Console.WriteLine("Niedostateczny");
                     break;
                 case 2:
                     Console.WriteLine("Dopuszczający");
                     break;
                 case 3:
                     Console.WriteLine("Dostateczny");
                     break;
                 case 4:
                     Console.WriteLine("Dobry");
                     break;
                 case 5:
                     Console.WriteLine("Bardzo dobry");
                     break;
                 case 6:
                     Console.WriteLine("Celujący");
                     break;
                 default:
                     Console.WriteLine("Ocena ma nieprawidłowy format wejścia.");
                     break;
            } */
            /* Method 2-nt */
            string result = schoolDegree switch
            {
                1 => "Niedostateczny",
                2 => "Dopuszczający",
                3 => "Dostateczny",
                4 => "Dobry",
                5 => "Bardzo dobry",
                6 => "Celujący",
                _ => "Ocena ma nieprawdidłowy format wejścia",
            };
            Console.WriteLine(result);

        }
    }
}
