using System;
using System.Collections.Generic;
using System.Text;

namespace ProductandLcmKata2
{
    public class Class1
    {
        public List<int> ProductArray = new List<int>();
        public List<int> LcmArray = new List<int>();
        public int ProductandLcm(int[,] list)
        {
            int a=1;
            int num1 = 0;
            int num2 = 0;
            int output;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    a =a* list[i, j];
                    if (j == 1)
                    {
                        num2 = list[i, j];
                    }
                    else
                    {
                        num1 = list[i, j];
                    }
                }
                LcmArray.Add(Lcm(num1, num2));
                ProductArray.Add(a);
                a = 1; 
            }
            output = SumofdifferencesbetweenproductsandLCMs(ProductArray, LcmArray);
            return output;
        }

        public int Lcm(int a ,int b)
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

        public int SumofdifferencesbetweenproductsandLCMs(List<int> ProductArray, List<int> LcmArray)
        {
            int a = 0;
            for(int i = 0; i <= ProductArray.Count-1; i++)
            {
                a += ProductArray[i] - LcmArray[i];
            }
            return a;
        }
    }
}
