using System;
using System.Collections.Generic;
using System.Linq;

namespace DeleteOccurrencesReattempt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>() { 1, 1, 3, 3, 7, 2, 2, 2, 2 };
            int count =3;
            int temp = 0;
            for(int i = arr.Count-1; i >= 0; i--)
            {
                temp = 1;
                for(int j = i-1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        temp += 1;
                        if (temp > count)
                        {
                            arr.RemoveAt(i);
                            i--;
                        }
                    }

                }
            }
            //this loop is iterated only for testing the data 
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            string[] a = { "wme,r", "eew", "s" };
            foreach (string i in a.Take(3).Where(x => !x.Contains(","))) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
