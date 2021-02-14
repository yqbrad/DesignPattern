using System;
using System.Collections.Generic;

namespace Strategy
{
    public class BubbleSort: ISortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("BubbleSort");
            return list;
        }
    }
}