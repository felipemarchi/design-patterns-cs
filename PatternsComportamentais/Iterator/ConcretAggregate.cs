using System;
using System.Collections;

namespace Iterator
{
    public class ConcretAggregate : Aggregate
    {

        private ArrayList _items = new ArrayList();
        public override Iterator CreateIterator()
        {
            return new ConcretIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
