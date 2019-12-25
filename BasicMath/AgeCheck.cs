using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMath
{
    class AgeCheck
    {
        private string adult = "Nagykorú vagy";
        private string notAdult = "Kiskorú vagy";

        
        public void writeYourBirthDay()
        {
            Console.WriteLine("Kérlek add meg a születési időpontodat a következő formátumban: ");
            Console.Write("MM DD YEAR" + "\n");
            string birthDay = Console.ReadLine();
            string adultOrNot = ageChecker(birthDay);
            Console.WriteLine(adultOrNot);
        }
        private string ageChecker(string ageInput)
        {
            string result;
            result = overAgedOrNot(ageInput);
            return result;
        }
        private string overAgedOrNot(string bday)
        {
            string result;

            int[] age = birthdaySplit(bday);
            int monthOfBirth = age[0];
            int dayOfBirth = age[1];
            int yearOfBirth = age[2];
            int nowDay = DateTime.Now.Day;
            int nowMonth = DateTime.Now.Month;
            int nowYear = DateTime.Now.Year;

            if ((nowYear - yearOfBirth) > 18)
            {
                result = adult;
            }else if((nowYear - yearOfBirth) == 18){
                if (monthOfBirth < nowMonth) result = adult;
                else if((monthOfBirth == nowMonth) && dayOfBirth <= nowDay)
                {
                    result = adult;
                }
                else
                {
                    result = notAdult;
                }
            }
            else
            {
                result = notAdult;
            }
            return result;
        }
        // Make an int array from birthday string
        private int[] birthdaySplit(string bday)
        {
            string[] r = bday.Split(" ");
            int[] res = new int[3];
            for(int i = 0; i < r.Length; i++)
            {
                res[i] = int.Parse(r[i]);
            }
            return res;
        }
        
    }
}
