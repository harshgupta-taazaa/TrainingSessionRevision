using System;
using System.Collections.Generic;

namespace SumConsecutivesKata4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> b = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 ,1,10,10,10,10};
            //int[] cars = { 1, 3, 4, 5 };
            SumConsecutive a = new SumConsecutive();
            //Console.WriteLine(cars);
            
             List<int>k=a.SumConsecutiveoflist(b);
            foreach(int p in k)
            {
                Console.WriteLine(p);
            }

        }
       
    }
}
