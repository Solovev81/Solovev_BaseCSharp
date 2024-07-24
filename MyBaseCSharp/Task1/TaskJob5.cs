using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBaseCSharp.Task1
{
    public class TaskJob5
    {
        // Создать консольное приложение, которое при старте попросит указать
        // пароль и далее будет спрашивать его, пока не будет введен верный,
        // после ввода верного пароля программа закончит свое выполнение, а при
        // вводе некорректного пароля будет просьба ввести пароль еще раз.

        public void StartInstallation()
        {
            Console.WriteLine("Установка системы...");

            Console.Write("Создайте пароль: ");
            string? myPassword = Console.ReadLine();

            Console.Clear();

            Login(myPassword);
        }

        public void Login(string? myPassword)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать User!");

                Console.Write("Введи пароль: ");
                string? somePassword = Console.ReadLine();

                if (somePassword == myPassword)
                {
                    break;
                }

                Console.Clear();
            };
        }
    }
}
