using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();

        try
        {
            int result = CalculateSum(input);
            Console.WriteLine($"Результат вычисления: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }

    static int CalculateSum(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Входная строка не должна быть пустой.");
        }

        int sum = 0;
        int currentNumber = 0;
        char currentSign = '+'; // Знак перед первым числом

        foreach (char c in input)
        {
            if (char.IsDigit(c))
            {
                // Если символ - цифра, добавляем её к текущему числу
                currentNumber = currentNumber * 10 + (c - '0');
            }
            else if (c == '+' || c == '-')
            {
                // Когда встречаем знак, добавляем предыдущее число к сумме
                sum += currentSign == '+' ? currentNumber : -currentNumber;

                // Обновляем знак и сбрасываем текущее число
                currentSign = c;
                currentNumber = 0;
            }
            else
            {
                throw new ArgumentException("Строка содержит недопустимые символы.");
            }
        }

        // Добавляем последнее число в строке
        sum += currentSign == '+' ? currentNumber : -currentNumber;

        return sum;
    }
}