using System;
using System.Collections.Generic;
using System.Text;

namespace TwoJoggersKATA1
{
    class Joggers
    {
        public Tuple<int, int> Joggerss(int num1, int num2)
        {
            int LcmOfLaps = Lcm(num1, num2);
            var output = Tuple.Create(LcmOfLaps / num1, LcmOfLaps / num2);
            return output;

        }
        public int Lcm(int a, int b)
        {
            int num1, num2;
            if (a > b)
            {
                num1 = a; num2 = b;
            }
            else
            {
                num1 = b; num2 = a;
            }

            for (int i = 1; i <= num2; i++)
            {
                if ((num1 * i) % num2 == 0)
                {
                    return i * num1;
                }
            }
            return num2;
        }
    }
}

