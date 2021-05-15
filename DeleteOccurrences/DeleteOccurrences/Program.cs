using System;
using System.Collections.Generic;

namespace DeleteOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> arr = new List<int>() { 1,2,3,2,3,3,2,1 };
            
            DeleteOccurrence Manager = new DeleteOccurrence();
            List<int> Result =Manager.DeleteExtraOccurrence(arr, 2);
            foreach (int a in Result)
            {
                Console.WriteLine(a);
            }
        }
    }
}
