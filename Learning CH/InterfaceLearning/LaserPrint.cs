using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLearning
{
    internal class LaserPrint : IPrinter, IFax
    {
        private double countToner;
        private int countLists;
        public double CountToner { get { return countToner; } }
        public int CountLists { get { return countLists; } }

        void IPrinter.Print()
        {
            countToner -= 0.1;
            if (countToner > 0 && countLists > 0)
            {
                countLists--;
                Console.WriteLine($"Печать лазерного принтера выполнена! Тонера осталось {(int)(CountToner * 100.0)}% Листов в лотке: {CountLists}");
            }
            else
            {
                Console.WriteLine("Закончился тонер или нет бумаги в лотке лазерного принтера!");
            }
        }

        void IFax.Print()
        {
            Console.WriteLine("Получен факс!");
        }

        public void AddLists(int countLists)
        {
            if (countLists > 0)
            {
                this.countLists = countLists;
            }
        }

        public void ReplacementToner()
        {
            this.countToner = 1;
        }
    }
}
