using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите число y: ");
        int y = int.Parse(Console.ReadLine());

        if (x <= 0 || y <= 0)
        {
            Console.WriteLine("Ошибка: оба числа должны быть натуральными (больше 0).");
            return;
        }

        int result = MultiplyUsingAddition(x, y);

        Console.WriteLine($"Произведение {x} и {y} равно {result}");
    }

    static int MultiplyUsingAddition(int x, int y)
    {
        int result = 0;

        for (int i = 0; i < y; i++)
        {
            result += x;
        }

        return result;
    }
}