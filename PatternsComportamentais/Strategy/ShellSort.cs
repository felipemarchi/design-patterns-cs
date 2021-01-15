using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell Sorted list!");
        }
    }
}
