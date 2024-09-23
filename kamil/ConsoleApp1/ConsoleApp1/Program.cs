using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Пример вызова функции Calculate
        double num1 = 10;
        double num2 = 5;
        double num3 = 2;
        double result = Calculate(num1, num2, num3);
        Console.WriteLine($"Результат: {result}"); // Вывод: Результат: 2.5

        // Пример вызова функции GetDayOfTheWeek
        int dayNumber = 3;
        string dayOfWeek = GetDayOfTheWeek(dayNumber);
        Console.WriteLine($"День недели: {dayOfWeek}"); // Вывод: День недели: среда

        // Пример вызова функции min
        int a = 5;
        int b = 10;
        int minNumber = min(a, b);
        Console.WriteLine($"Меньшее число: {minNumber}"); // Вывод: Меньшее число: 5
    }

    // Функция для вычисления (num1 - num2) / num3
    public static double Calculate(double num1, double num2, double num3)
    {
        if (num3 == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно!");
        }

        return (num1 - num2) / num3;
    }

    // Функция, возвращающая день недели на русском языке
    public static string GetDayOfTheWeek(int dayNumber)
    {
        switch (dayNumber)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "Некорректный номер дня";
        }
    }

    // Функция, возвращающая меньшее из двух чисел
    public static int min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}
