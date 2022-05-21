using System;
using System.Collections.Generic;

namespace InterfaceLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LaserPrint laser = new LaserPrint();
            laser.ReplacementToner();
            laser.AddLists(20);

            ThermalPrinter tPrinter = new ThermalPrinter();

            List<IPrinter> printers = new List<IPrinter>();
            printers.Add(tPrinter);
            printers.Add(laser);

            List<IFax> printers2 = new List<IFax>();
            printers2.Add(laser);

            for (int i = 0; i < 20; i++)
            {
                foreach (IPrinter printer in printers)
                {
                    printer.Print();
                }
                foreach (IPrinter printer in printers2)
                {
                    ((IFax)printer).Print();
                }
            }         
        }
    }
}
