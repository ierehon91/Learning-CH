using System;

namespace ConstAndReadOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Loger());
            car.Drive();
            car.StartEngine();
            car.StartEngine();
            car.Drive();
        }
    }
}
