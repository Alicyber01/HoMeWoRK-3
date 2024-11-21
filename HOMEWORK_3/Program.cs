using System;
namespace homework_3;
class Program
{
    enum DayOfWeekEnum
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

    static void Main()
    {
        EXERCISE1();
        EXERCISE2();
        EXERCISE3();
        EXERCISE4();
        EXERCISE5();
    }

    // 3.1. Дана последовательность из 10 чисел. Определить, является ли эта последовательность
    //упорядоченной по возрастанию.В случае отрицательного ответа определить
    //порядковый номер первого числа, которое нарушает данную последовательность.
    //Использовать break.
    static void EXERCISE1()
    {
        int[] numbers = new int[10];

        Console.WriteLine("Введите 10 чисел:");

        for (int i = 0; i < 10; i++)
        {
            while (true)
            {
                Console.Write($"Число {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка! Введите целое число.");
                }
            }
        }

        bool isOrdered = true;
        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] <= numbers[i - 1])
            {
                Console.WriteLine($"Последовательность нарушена на числе {numbers[i]} (порядковый номер: {i + 1})");
                isOrdered = false;
                break;
            }
        }

        if (isOrdered)
        {
            Console.WriteLine("Последовательность упорядочена по возрастанию.");
        }
        Console.WriteLine();
    }

    // 3.2. Игральным картам условно присвоены следующие порядковые номера в зависимости от
    //их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
    //Порядковые номера остальных карт соответствуют их названиям(«шестерка»,
    //«девятка» и т. п.). По заданному номеру карты k(6 <=k <= 14) определить достоинство
    //соответствующей карты.Использовать try-catch-finally.
    static void EXERCISE2()
    {
        Console.Write("Введите порядковый номер карты (6 <= k <= 14): ");
        if (int.TryParse(Console.ReadLine(), out int k))
        {
            if (k >= 6 && k <= 14)
            {
                string cardName = k switch
                {
                    6 => "Шестёрка",
                    7 => "Семёрка",
                    8 => "Восьмёрка",
                    9 => "Девятка",
                    10 => "Десятка",
                    11 => "Валет",
                    12 => "Дама",
                    13 => "Король",
                    14 => "Туз",
                    _ => string.Empty
                };
                Console.WriteLine($"Карта с номером {k} — это {cardName}.");
            }
            else
            {
                Console.WriteLine("Ошибка! Номер карты должен быть в диапазоне от 6 до 14.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введите целое число.");
        }

        Console.WriteLine("Программа завершена.");
        Console.WriteLine();
    }

    // 3.3. Напишите программу, которая принимает на входе строку и производит выходные
    //данные в соответствии со следующей таблицей:Примечание. По умолчанию используется “все остальное”: если входные данные
    //функции не соответствуют ни одному из значений в таблице, то возвращаемое значение
    //должно быть «Beer».
    //Убедитесь, что вы охватили случаи, когда некоторые слова не отображаются с
    //правильным написанием заглавных букв.Например, ввод «pOLitiCIaN» должен
    //по-прежнему возвращать «Your tax dollars».
        static void EXERCISE3()
        {
            Console.Write("Введите входные данные: ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequilla");
                    break;
                case "School Counselor":
                    Console.WriteLine("Patron Tequilla");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipsters Craft Beer");
                    break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "Rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }
        // 3.4. Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,
       //...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
      //Использовать enum.
    static void EXERCISE4()
    {
        Console.Write("Введите номер дня недели (1 - Понедельник, ..., 7 - Воскресенье): ");

        if (int.TryParse(Console.ReadLine(), out int dayNumber))
        {
            if (dayNumber >= 1 && dayNumber <= 7)
            {
                DayOfWeekEnum dayOfWeek = (DayOfWeekEnum)dayNumber;
                Console.WriteLine($"День недели: {dayOfWeek}");
            }
            else
            {
                Console.WriteLine("Ошибка! Номер дня недели должен быть в диапазоне от 1 до 7.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка! Введите целое число.");
        }
        Console.WriteLine();
    }

    // 3.5. Создать массив строк. При помощи foreach обойти весь массив. При встрече элемента
    //"Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
    //результату.Вывести на экран сколько кукол в “сумке”.
    static void EXERCISE5()
    {
        string[] toys = { "Barbie doll", "Hello Kitty", "Barbie doll", "Toy car", "Barbie doll", "Lego", "Barbie doll", "Teddy bear", "Barbie doll" };

        int count = 0;

        foreach (var toy in toys)
        {
            if (toy == "Hello Kitty" || toy == "Barbie doll")
            {
                count++;
            }
        }

        Console.WriteLine($"Количество кукол в сумке: {count}");
    }
}