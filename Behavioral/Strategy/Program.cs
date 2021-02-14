using System;
using System.Collections.Generic;

namespace Strategy
{
    public class Program
    {
        // Define a family of algorithms, encapsulate each one, and make them interchangeable.
        // Strategy lets the algorithm vary independently from clients that use it.
        // بتوان الگوریتم های مختلف را جایگزین نمود
        static void Main(string[] _)
        {
            var bSorter = new Sorter(new BubbleSort());
            bSorter.Sort(new List<int> { 1, 2, 3, 4, 5 });


            var qSorter = new Sorter(new QuickSort());
            qSorter.Sort(new List<int> { 1, 2, 3, 4, 5 });

            Console.ReadKey();
        }
    }
}