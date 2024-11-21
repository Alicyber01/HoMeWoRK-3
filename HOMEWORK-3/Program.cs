using System;

namespace Tumakov_labotary4;

//Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня
//в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
//февраля (високосный год не учитывать).
class Program
{
    static void Main()
    {
       EXERCISE1();
       EXERCISE2();
    }

    static void EXERCISE1()
    {
        int dayOfYear;

        while (true)
        {
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            if (int.TryParse(Console.ReadLine(), out dayOfYear))
            {
                if (dayOfYear >= 1 && dayOfYear <= 365)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 365.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }

        DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
        DateTime targetDate = startOfYear.AddDays(dayOfYear - 1);
        int month = targetDate.Month;
        int day = targetDate.Day;
        string monthName = targetDate.ToString("MMMM");

        Console.WriteLine($"День {dayOfYear} в году - это {day} {monthName}.");
    }

    //Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
    //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
    //исключение, и выдавать на экран сообщение.
    static void EXERCISE2()
    {
        int dayOfYear;

        while (true)
        {
            Console.Write("Введите номер дня в году (от 1 до 365): ");
            if (int.TryParse(Console.ReadLine(), out dayOfYear))
            {
                if (dayOfYear < 1 || dayOfYear > 365)
                {
                    Console.WriteLine("Ошибка! Число должно быть в диапазоне от 1 до 365.");
                }
                else
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введено не число. Пожалуйста, введите корректное число.");
            }
        }

        DateTime startOfYear = new DateTime(DateTime.Now.Year, 1, 1);
        DateTime targetDate = startOfYear.AddDays(dayOfYear - 1);
        int month = targetDate.Month;
        int day = targetDate.Day;
        string monthName = targetDate.ToString("MMMM");

        Console.WriteLine($"День {dayOfYear} в году - это {day} {monthName}.");
    }
}

