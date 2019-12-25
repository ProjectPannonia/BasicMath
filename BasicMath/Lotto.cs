using System;
using System.Collections.Generic;
using System.Text;

namespace BasicMath
{
    class Lotto
    {
        public int[] getLottoNumbers()
        {
            int[] res = new int[5];

            Random random = new Random();

            for (int i = 0; i < res.Length; i++)
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0) return true;
            }
            return false;
        }
        // Return true, if actual number already in array
        private bool containsActualNumber(int[] arr, int num)
        {
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num) flag = true;
            }
            return flag;
        }
    }
}
