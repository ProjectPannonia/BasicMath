using System;

namespace BasicMath
{
    class Lotto
    {
        public int[] getLottoNumbers()
        {
            int[] res = new int[5];
            
            Random random = new Random();
            
            for(int i = 0; i < res.Length; i++)
            {
                int actual = random.Next(1, 91);
                if (containsActualNumber(res, actual))
                {
                    --i;
                    continue;
                }
                else
                {
                    res[i] = actual;
                }
            }
            return res;
        }
        //Return true, if array contain zero
        private bool containsZero(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) return true;
            }
            return false;
        }
        // Return true, if actual number already in array
        private bool containsActualNumber(int[] arr, int num)
        {
            bool flag = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) flag = true;
            }
            return flag;
        }
    }
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
            /*
            Factorial factorial = new Factorial();
            Console.Write("Kérlek add meg a keresett számot: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(factorial.getFactorial(num));
            */
            /*int a = 5;
            Console.WriteLine("PostFix: " + a++);
            Console.WriteLine("PreFix: " + ++a);
            */
            Lotto lotto = new Lotto();
            bool flag = false;
            do
            {
                int[] myNumbers = lotto.getLottoNumbers();
                for (int i = 0; i < myNumbers.Length; i++)
                {
                    Console.WriteLine(i + ". number: " + myNumbers[i]);
                }
                Console.WriteLine("Sorsoljak neked új számokat?(y/n)");
                string answer = Console.ReadLine();
                if (answer.Equals("y")) flag = true;
                if (answer.Equals("n")) break;
            } while (flag);
        }
    }
}
