using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            Console.WriteLine("Podaj pierwszą zmienną: ");
            int variable1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą zmienną: ");
            int variable2 = int.Parse(Console.ReadLine());
            if (variable1 == variable2)
            {
                Console.WriteLine($"{variable1} i {variable2} są równe");
            }
            else
            {
                Console.WriteLine($"Zmienne {variable1} i {variable2} są różne");
            }


            else if (variable1 > variable2)
            {
                Console.WriteLine($"{variable1} jest większe od {variable2}");
            }
            else
            {
                {
                    Console.WriteLine($"{variable2} jest większe od {variable1}");
                }
            }

            Console.WriteLine("Task 2:");
            Console.WriteLine("Podaj liczbę: ");
            int number = int.Parse(Console.ReadLine());
            string score;

            /* First method

            if (number % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta");
            }
            */
           // Second method
            score = (number % 2 == 0) ? "Liczba jest parzysta" : "Liczba jest nieparzysta";
            Console.WriteLine(score);

            Console.WriteLine("Task 3: ");
            int variable3 = int.Parse(Console.ReadLine());
            int evenOrOdd = Math.Sign(variable3);
            if (evenOrOdd == -1)
            {
                Console.WriteLine("Liczba jest ujemna.");
            }
            else if (evenOrOdd == 1)
            {
                Console.WriteLine("Liczba jest dodatnia.");
            }
            else
            {
                Console.WriteLine("Liczba jest równa 0.");
            }

            Console.WriteLine("Task 4: ");
            string leapYear = DateTime.IsLeapYear(int.Parse(Console.ReadLine())) ? "Rok jest przestępny" : "Rok nie jest przestępny";
            Console.WriteLine(leapYear);

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

            Console.WriteLine("Task 7: ");
            Console.WriteLine("Podaj liczby: ");
            int firstNumberToCompare = int.Parse(Console.ReadLine());
            int secondNumberToCompare = int.Parse(Console.ReadLine());
            int thirdNumberToCompare = int.Parse(Console.ReadLine());
            int biggestNumber = Math.Max(firstNumberToCompare, secondNumberToCompare);
            biggestNumber = Math.Max(biggestNumber, thirdNumberToCompare);
            Console.WriteLine($"{biggestNumber} jest największą z podanych");

            Console.WriteLine("Task 8: ");
            Console.WriteLine("Matematyka: ");
            byte mathScore = byte.Parse(Console.ReadLine());
            Console.WriteLine("Fizyka: ");
            byte physicScore = byte.Parse(Console.ReadLine());
            Console.WriteLine("Chemia: ");
            byte chemistryScore = byte.Parse(Console.ReadLine());
            if (((mathScore + physicScore + chemistryScore) > 180 && (mathScore > 70 && physicScore > 55 && chemistryScore > 45)) || (((mathScore + physicScore) > 150) || ((mathScore + chemistryScore) > 150)))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            Console.WriteLine("Task 9: ");
            Console.WriteLine("Podaj temperaturę: ");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature < 0)
            {
                Console.WriteLine("cholerenie piździ");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
            }



            Console.WriteLine("Task 10: ");
            Console.WriteLine("Podaj długości boków trójkąta w kolejności od najmniejszej do największej: ");
            uint firstSide = uint.Parse(Console.ReadLine());
            uint secondSide = uint.Parse(Console.ReadLine());
            uint thirdSide = uint.Parse(Console.ReadLine());
            if ((firstSide + secondSide) > thirdSide)
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Trójkąt nie może być zbudowany");
            }

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

            Console.WriteLine("Task 12: ");
            Console.WriteLine("Podaj dzień tygodnia: ");
            byte numberOfDay = byte.Parse(Console.ReadLine());
            string numberOfDayResult = numberOfDay switch
            {
                1 => "Poniedziałek",
                2 => "Wtorek",
                3 => "Środa",
                4 => "Czwartek",
                5 => "Piątek",
                6 => "Sobota",
                7 => "Niedziela",
                _ => "Nieprawidłowy format wejściowy",
            };
            Console.WriteLine(numberOfDayResult);

        }
    }
}
