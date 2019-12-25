using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMath
{
    class Factorial
    {
        public String getFactorial(int number)
        {
            String result;
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            result = "A Megadott szám faktoriális értéke: " + factorial + ".";

            return result;
        }
    }
}
