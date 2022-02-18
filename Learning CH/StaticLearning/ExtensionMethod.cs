using System;
using System.Collections.Generic;
using System.Text;

namespace MyExtencion
{
    static class ExtensionMethod
    {
        public static void Print( this DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString());
        }

        public static bool isDayOfWeek( this DateTime dateTime, DayOfWeek dayOfWeek)
        {
            return dateTime.DayOfWeek == dayOfWeek;
        }
    }
}
