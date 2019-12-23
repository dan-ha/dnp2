using System;
using System.Collections.Generic;

namespace assignment2
{
    // Delegate types to describe predicates on ints and actions on ints
    public delegate bool IntPredicate(int x);
    public delegate void IntAction(int x);

    // Integer lists with Act and Filter operations.
    // An IntList containing the element 7 9 12 may be constructed as
    // new IntList(7, 9, 13) due to the params modifier.

    class IntList : List<int>
    {
        public IntList(params int[] elements): base(elements)
        {
        }

        public void Act(IntAction f)
        {
            foreach(int i in this)
            {
                f(i);
            }
        }

        public IntList Filter(IntPredicate p)
        {
            IntList res = new IntList();
            foreach(int i in this)
            {
                if (p(i))
                {
                    res.Add(i);
                }
            }
            return res;
        }
    }
}
