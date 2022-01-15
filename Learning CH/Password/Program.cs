using System;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = string.Empty;
            int accessCounter = 10;
            bool isAccsess = false;

            do
            {
                Console.Write("Введите пароль: ");
                password = System.Console.ReadLine();
                if (password == "qwerty")
                {
                    isAccsess = true;
                    break;
                }
                accessCounter--;
                System.Console.WriteLine($"Пароль неверный, попыток осталось: {accessCounter}.");
            }
            while (accessCounter > 0);

            string message = isAccsess ? "Доступ открыт!" : "Доступ закрыт!";
            Console.WriteLine(message);
        }
    }
}
