﻿using System;

namespace BasicMath
{
    class Factorial
    {
        public String getFactorial(int number)
        {
            String result;
            int factorial = 1;
            for(int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            result = "A Megadott szám faktoriális értéke: " + factorial + ".";

            return result;
        }
    }
    class MyMath{
            public String biggestDivisor(int a, int b)
        {
            String result;

            int s1 = a;
            int s2 = b;

            if(s2 > s1)
            {
                int temp = s1;
                s1 = s2;
                s2 = temp;
            }

            while(s1 % s2 != 0)
            {
                int temp = s1;
                s2 = s1 % s2;
                s1 = s2;
            }
            result = "A két szám legnagyobb közös osztója: " + s2;
            return result;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            /*
            MyMath math = new MyMath();
            Console.Write("Kérlek add meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérlek add meg a második számot: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(math.biggestDivisor(a, b));
            //math.biggestDivisor(a, b);
            */

            Factorial factorial = new Factorial();
            Console.Write("Kérlek add meg a keresett számot: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial.getFactorial(num));

        }
    }
}
