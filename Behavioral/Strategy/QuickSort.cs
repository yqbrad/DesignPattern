using System;
using System.Collections.Generic;

namespace Strategy
{
    public class QuickSort: ISortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("QuickSort");
            return list;
        }
    }
}