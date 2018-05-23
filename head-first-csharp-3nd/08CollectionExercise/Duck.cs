using System;
using System.Collections.Generic;
using System.Text;

namespace _08CollectionExercise
{
    class Duck : Bird, IComparable<Duck>
    {
        public int CompareTo(Duck other)
        {
            return 0;
        }
    }
}
