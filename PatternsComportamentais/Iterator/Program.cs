using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcretAggregate a = new ConcretAggregate();

            a[0] = "Item A";
            a[1] = "Item B";
            a[2] = "Item C";
            a[3] = "Item D";

            Iterator i = a.CreateIterator();

            Console.WriteLine("Iteragindo com a coleção: ");

            object item = i.First();

            while (item!=null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }
        }
    }
}
