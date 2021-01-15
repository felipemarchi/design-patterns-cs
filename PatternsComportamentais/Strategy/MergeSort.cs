using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge Sorted list");
        }
    }
}
