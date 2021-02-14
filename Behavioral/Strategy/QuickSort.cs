using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class QuickSort:ISortStrategy
    {
        public List<int> Sort(List<int> list)
        {
            Console.WriteLine("QuickSort");
            return list;
        }
    }
}
