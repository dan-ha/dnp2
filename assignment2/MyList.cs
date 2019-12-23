using System;
using System.Collections.Generic;

namespace assignment2
{
    class MyList<T> : List<T>
    {
        public MyList(params T[] elements) : base(elements)
        {
        }

        public void Act(Action<T> f)
        {
            foreach (T t in this)
            {
                f(t);
            }
        }

        public MyList<T> Filter(Predicate<T> p)
        {
            MyList<T> res = new MyList<T>();
            foreach (T t in this)
            {
                if (p(t))
                {
                    res.Add(t);
                }
            }
            return res;
        }

    }
}
