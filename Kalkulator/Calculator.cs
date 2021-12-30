using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2Calculator
{
    public class Calculator
    {
        public static float AddNumbers(float firstNumber, float secondNumber)
        {
            float score = firstNumber + secondNumber;
            return score;
        }
        public static float SubtractNumbers(float firstNumber, float secondNumber)
        {
            float score = firstNumber - secondNumber;
            return score;
        }
        public static float DivideNumbers(float firstNumber, float secondNumber)
        {
                float score = firstNumber / secondNumber;
                return score;

        }
        public static float MultiplyNumbers(float firstNumber, float secondNumber)
        {
            float score = firstNumber * secondNumber;
            return score;
        }

    }
}
