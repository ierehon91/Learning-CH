using System;
using System.Collections.Generic;
using System.Text;

namespace GetSetPropertys
{
    class Point
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
            get 
            {
                return x;
            }

            set 
            { 
                if (value < 0)
                {
                    x = 0;
                    return;
                }
                if (value > 100)
                {
                    x = 100;
                    return;
                }
                x = value; 
            }
        }
        
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                if (value < 0)
                {
                    y = 0;
                    return;
                }
                if (value > 100)
                {
                    y = 100;
                    return;
                }
                y = value;
            }
        }

        public int Z { get; set; } // автомотическое свойство (в VS набираем prop)

    }
}
