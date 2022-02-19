using System;
using System.Collections.Generic;
using System.Text;

namespace InitObject
{
    class Address
    {
        private string city;
        private string street;
        private string home;

        public string City { set { city = value; } }
        public string Street { set { street = value; } }
        public string Home { set { home = value; } }

        public string Print()
        {
            return $"{city}, {street} {home}";
        }
    }
}
