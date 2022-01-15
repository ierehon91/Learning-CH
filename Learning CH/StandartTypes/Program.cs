using System;
using static System.Console;

namespace StandartTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int nameShift = -7;
            const int bytesOfMemoryShift = 20;
            const int maxValueShift = 35;
            const int minValueShift = 35;
            WriteLine("--------------------------------------------------------------------------------------------------------");
            WriteLine($"{"Name",nameShift} {"Byte(s) of memory",bytesOfMemoryShift}{"Max",maxValueShift}{"Min",minValueShift}");
            WriteLine("--------------------------------------------------------------------------------------------------------");

            WriteLine($"{"sbyte",nameShift} {sizeof(sbyte),bytesOfMemoryShift} {sbyte.MaxValue,maxValueShift} {sbyte.MinValue,minValueShift}");
            WriteLine($"{"byte",nameShift} {sizeof(byte),bytesOfMemoryShift} {byte.MaxValue,maxValueShift} {byte.MinValue,minValueShift}");
            WriteLine($"{"short",nameShift} {sizeof(short),bytesOfMemoryShift} {short.MaxValue,maxValueShift} {short.MinValue,minValueShift}");
            WriteLine($"{"ushort",nameShift} {sizeof(ushort),bytesOfMemoryShift} {ushort.MaxValue,maxValueShift} {ushort.MinValue,minValueShift}");
            WriteLine($"{"int",nameShift} {sizeof(int),bytesOfMemoryShift} {int.MaxValue,maxValueShift} {int.MinValue,minValueShift}");
            WriteLine($"{"uint",nameShift} {sizeof(uint),bytesOfMemoryShift} {uint.MaxValue,maxValueShift} {uint.MinValue,minValueShift}");
            WriteLine($"{"long",nameShift} {sizeof(long),bytesOfMemoryShift} {long.MaxValue,maxValueShift} {long.MinValue,minValueShift}");
            WriteLine($"{"ulong",nameShift} {sizeof(ulong),bytesOfMemoryShift} {ulong.MaxValue,maxValueShift} {ulong.MinValue,minValueShift}");
            WriteLine($"{"float",nameShift} {sizeof(float),bytesOfMemoryShift} {float.MaxValue,maxValueShift} {float.MinValue,minValueShift}");
            WriteLine($"{"double",nameShift} {sizeof(double),bytesOfMemoryShift} {double.MaxValue,maxValueShift} {double.MinValue,minValueShift}");
            WriteLine($"{"decimal",nameShift} {sizeof(decimal),bytesOfMemoryShift} {decimal.MaxValue,maxValueShift} {decimal.MinValue,minValueShift}");
        }
    }
}
