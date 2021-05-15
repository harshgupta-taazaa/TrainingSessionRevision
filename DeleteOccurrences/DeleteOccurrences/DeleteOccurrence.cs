using System;
using System.Collections.Generic;
using System.Text;

namespace DeleteOccurrences
{
    public class DeleteOccurrence
    {
        List<int> newArray = new List<int>();
        public static List<int> newArray1=new List<int>();
        List<int> newArray2 = new List<int>();

       
        public List<int> DeleteExtraOccurrence(List<int> arr,int count)
        {
            newArray1 = arr;
            for (int i = 0; i < arr.Count - 1; i++)
            {

               RemoveExtraElements(newArray1, arr[i], count);
            }
            return newArray1;
        }

        public void RemoveExtraElements(List<int> arr, int Itemname,int Count)
        {

            if (NoOfTimesItemPresent(arr, Itemname) > Count)
            {
                int a = 0;
                for (int i = 0; i < arr.Count; i++)
                {
                    if (arr[i] == Itemname)
                    {
                        a += 1;
                        if (a <=Count)
                        {
                            newArray2.Add(arr[i]);
                        }
                    }
                    else
                    {
                        newArray2.Add(arr[i]);
                    }
                }
                newArray1.Clear();
                foreach(int p in newArray2)
                {
                    newArray1.Add(p);

                }
                
                newArray2.Clear();
            }
        }
        public int NoOfTimesItemPresent(List<int> arr,int item)
        {
            int count = 0;
            foreach(int i in arr)
            {
                if (i == item)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
