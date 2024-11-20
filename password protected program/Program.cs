/*
Создайте переменную типа string, в которой хранится пароль для доступа к тайному сообщению. 
Пользователь вводит пароль, далее происходит проверка пароля на правильность, и если пароль неверный, то попросите его ввести пароль ещё раз. 
Если пароль подошёл, выведите секретное сообщение.  

Если пользователь неверно ввел пароль 3 раза, программа завершается.
*/
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            string password = "Инчакутек";
            int trysCount = 3;
            int trys = 1;            

            for (int i = 0; i < trysCount; i++) 
            {             
                Console.WriteLine("Введите пароль:");
                string inputPassword = Console.ReadLine();

                if (inputPassword == password)
                {
                    Console.WriteLine("Секретный шифр:\nЗдесь был гараж...");
                    break;
                }
                if (trysCount - i - trys < 1)
                {
                    Console.WriteLine("Неверный пароль - завершение программы...");
                }
                else
                {
                    Console.WriteLine($"Количество попыток осталось: {trysCount - i - trys}");
                }
            }
        }
    }
}