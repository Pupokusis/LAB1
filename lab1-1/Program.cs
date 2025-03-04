using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int n;

        // Проверка корректности ввода
        if (!int.TryParse(Console.ReadLine(), out n) || n < 1000 || n > 9999)
        {
            Console.WriteLine("Ошибка: введите корректное четырехзначное число.");
            return;
        }

        int d1 = n / 1000;           
        int d2 = (n / 100) % 10;     
        int d3 = (n / 10) % 10;      
        int d4 = n % 10;             

        int count1 = (d1 == d2 ? 1 : 0) + (d1 == d3 ? 1 : 0) + (d1 == d4 ? 1 : 0);
        int count2 = (d2 == d1 ? 1 : 0) + (d2 == d3 ? 1 : 0) + (d2 == d4 ? 1 : 0);
        int count3 = (d3 == d1 ? 1 : 0) + (d3 == d2 ? 1 : 0) + (d3 == d4 ? 1 : 0);
        int count4 = (d4 == d1 ? 1 : 0) + (d4 == d2 ? 1 : 0) + (d4 == d3 ? 1 : 0);

        if (count1 == 2 || count2 == 2 || count3 == 2 || count4 == 2)
        {
            Console.WriteLine($"Число {n} содержит ровно три одинаковые цифры.");
        }
        else
        {
            Console.WriteLine($"Число {n} НЕ содержит ровно три одинаковые цифры.");
        }
    }
}