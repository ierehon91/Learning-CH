using System;

namespace NullHanding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addres addres = new Addres();
            addres.Building = "21";
            addres.Street = "Krupskoi";
            addres.City = "Semiluki";
            addres.Country = null;
            addres.PrintAddres();
        }
    }

    class Addres
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string? Country;

        public void PrintAddres()
        {
            string print;
            if (Country == null && Building == null) print = $"{City} city, {Street} street";
            else if (Country == null) print = $"{City} city, {Street} street, {Building}";
            else if (Building == null) print = $"{Country}, {City} city, {Street} street";
            else print = $"{Country}, {City} city, {Street} street, {Building}";
            System.Console.WriteLine(print);
        }
    }
}
