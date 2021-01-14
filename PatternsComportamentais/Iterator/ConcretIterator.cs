using System;

namespace Iterator
{
    public class ConcretIterator : Iterator
    {
        private ConcretAggregate _aggregate;
        private int _current = 0;

        public ConcretIterator(ConcretAggregate aggregate)
        {
            this._aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            return _current >= _aggregate.Count;
        }

        public override object Next()
        {
            object ret = null;
            if (_current < _aggregate.Count - 1)
                ret = _aggregate[++_current];

            return ret;
        }
    }
}
