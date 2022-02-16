using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLearning
{
    class Car
    {
        private int speed = 0;

        public void Stop()
        {
            speed = 0;
        }

        public void GoUp()
        {
            speed = 60;
        }

        public void GoBack()
        {
            speed = -5;
        }

        public void PrintSpeed()
        {
            if (speed == 0) Console.WriteLine("Автомобиль стоит на месте.");
            if (speed > 0) Console.WriteLine($"Автомобиль едет вперёд со скоростью {speed} км/ч.");
            if (speed < 0) Console.WriteLine($"Автомобиль едет назад со скоростью {-speed} км/ч.");
        }
    }
}
