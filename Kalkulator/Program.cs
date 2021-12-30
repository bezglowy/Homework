using System;

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w prostym kalkulatorze!");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania: \r\n 1. Dodawania \r\n 2. Odejmowanie \r\n 3. Mnożenie \r\n 4. Dzielenie");
            int selectedOperation = int.Parse(Console.ReadLine());

            if(selectedOperation  == 1)
            {
                Console.WriteLine($"Wybrano operację dodawania liczb {firstNumber} i {secondNumber}");
                Console.WriteLine($"Wynik to {Homework2Calculator.Calculator.AddNumbers(firstNumber, secondNumber)}");
            }
            else if(selectedOperation ==2)
            {
                Console.WriteLine($"Wybrano operację odejmowania liczb {firstNumber} i {secondNumber}");
                Console.WriteLine($"Wynik to {Homework2Calculator.Calculator.SubtractNumbers(firstNumber, secondNumber)}");
            }
            else if (selectedOperation == 3)
            {
                Console.WriteLine($"Wybrano operację mnożenia liczb {firstNumber} i {secondNumber}");
                Console.WriteLine($"Wynik to {Homework2Calculator.Calculator.MultiplyNumbers(firstNumber, secondNumber)}");
            }
            else if (selectedOperation == 4)
            {
                if (secondNumber != 0)
                {
                    Console.WriteLine($"Wybrano operację dzielenia liczb {firstNumber} i {secondNumber}");
                    Console.WriteLine($"Wynik to {Homework2Calculator.Calculator.DivideNumbers(firstNumber, secondNumber)}");
                }
                else
                {
                    Console.WriteLine("Nie można dzielić przez 0");
                }

            }
            else
            {
                Console.WriteLine("Wybrano nieprawidłową operację");
            }


        }
    }
}
