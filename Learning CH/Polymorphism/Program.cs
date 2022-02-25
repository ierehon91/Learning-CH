using System;

namespace Polymorphism
{

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    class Car
    {
        protected void StartEngine()
        {
            Console.WriteLine("Запуск двигателя!");
        }

        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Машина поехала!");
        }
    }

    class SportCar : Car
    {
        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("Очень очень быстро, ведь это спорткар!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Car car = new Car();
            Car sportCar = new SportCar();

            person.Drive(car);
            Console.WriteLine("\n");
            person.Drive(sportCar);
        }
    }
}
