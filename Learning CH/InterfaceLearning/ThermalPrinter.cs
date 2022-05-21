using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning
{
    internal class ThermalPrinter : IPrinter
    {
        private double temperature = 20;
        public double Temperature { get { return temperature; } }

        private void Heating()
        {
            while (temperature < 100.0)
            {
                Console.WriteLine($"Нагрев термопринтера! Температура печки: {Temperature} C");
                temperature+=5;
            }
        }
        public void Print()
        {
            if (Temperature < 100.0)
            {
                Heating();
                Print();
            }
            else
            {
                Console.WriteLine("Печать термопринтера выполнена!");
            }
        }
    }
}
