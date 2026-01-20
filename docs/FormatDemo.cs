/*
# FormatDemo.cs
## Демонстрация Markdown в комментариях C#

**Логика программы:**
1. Запрос двух чисел у пользователя
2. Выполнение сложения
3. Форматированный вывод результата
*/

using System;

class Program
{
    static void Main()
    {
        // ## Ввод данных
        Console.Write("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // ## Вычисление
        double sum = number1 + number2;

        // ## Вывод результата
        Console.WriteLine($"Сумма: {number1} + {number2} = {sum}");

        Console.ReadLine();
    }
}