using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLearning
{
    class CounterObjects
    {
        private static uint counter;

        public CounterObjects()
        {
            counter += 1;
        }

        public static uint Counter
        {
            get { return counter; }
        }
    }
}
