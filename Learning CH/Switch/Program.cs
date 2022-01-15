using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите номер месяца: ");
            int numberMonth = int.Parse(Console.ReadLine());
            SimpleSwitch(numberMonth);
            ShugarSwitch(numberMonth);
        }
        static void SimpleSwitch(int numberMonth)
        {
            string timeOfTheYear = string.Empty;

            switch (numberMonth)
            {
                case 1:
                case 2:
                case 12:
                    timeOfTheYear = "Зима";
                    break;

                case 3:
                case 4:
                case 5:
                    timeOfTheYear = "Весна";
                    break;

                case 6:
                case 7:
                case 8:
                    timeOfTheYear = "Лето";
                    break;

                case 9:
                case 10:
                case 11:
                    timeOfTheYear = "Осень";
                    break;

                default:
                    Console.WriteLine("Такого номера месяца быть не может");
                    break;
            }
            if (timeOfTheYear != string.Empty) System.Console.WriteLine("Время года: " + timeOfTheYear);
        }

        static void ShugarSwitch(int numberMonth)
        {
            string nameMonth;
            nameMonth = numberMonth switch
            {
                1 => "Январь",
                2 => "Февраль",
                3 => "Март",
                4 => "Апрель",
                5 => "Май",
                6 => "Июнь",
                7 => "Июль",
                8 => "Август",
                9 => "Сентябрь",
                10 => "Октябрь",
                11 => "Ноябрь",
                12 => "Декабрь",
                _
                => "Такого месяца не существует"
            };

            System.Console.WriteLine(nameMonth);

        }
    }
}
