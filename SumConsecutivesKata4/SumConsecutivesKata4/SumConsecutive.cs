using System;
using System.Collections.Generic;
using System.Text;

namespace SumConsecutivesKata4
{
    class SumConsecutive
    {
        public List<int> SumConsecutiveoflist(List<int> list)
        {
            List<int> arr = new List<int>();
            int a;
            for (int i = 0; i < list.Count; i++)
            {
                a = list[i];
                if (i == list.Count - 1)
                {
                    if (list[i] != list[i - 1])
                    {
                        arr.Add(list[i]);
                    }
                }
                for (int j=i+1;j<list.Count;j++)
                {
                    if (list[i] == list[j])
                    {
                        if (j == list.Count - 1)
                        {
                            a += list[j];
                            arr.Add(a);
                        }

                        else
                        {
                            a += list[j];
                            i += 1;
                           
                        }
                    }
                    else
                    {
                        arr.Add(a);
                        break;
                    }
                }
            }
            return arr;
        }
    }  
}
