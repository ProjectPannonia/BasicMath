using System;

namespace BasicMath
{
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
            /*
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
            */
            /*Console.Write("Kérlek add meg a születési dátumodat a következő formátumban, DD MM YEAR: ");
            string dateOfBirth = Console.ReadLine();
            string[] birthDayArr = dateOfBirth.Split(" ");

            int birthMonth = int.Parse(birthDayArr[0]);
            int birthDay = int.Parse(birthDayArr[1]);
            int birthYear = int.Parse(birthDayArr[2]);

            int actualMonth = DateTime.Now.Month;
            int actualDay = DateTime.Now.Day;
            int actualYear = DateTime.Now.Year;

            bool y = (actualYear - birthYear) >= 18;
            bool d = (birthDay <= actualDay);
            bool m = birthMonth <= actualMonth;

            if((actualYear - birthYear) == 18 && m && d)
            {
                Console.Write("Nagykorú vagy!");
            }
            if((actualYear - birthYear > 18))
            {
                Console.Write("Nagykorú vagy!");
            }
            else
            {
                Console.Write("Túl fiatal vagy!");
            }*/
            AgeCheck age = new AgeCheck();
            age.writeYourBirthDay();
        }
    }
}
