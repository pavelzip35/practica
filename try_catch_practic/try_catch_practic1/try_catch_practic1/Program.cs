using System;

class Program
{
    static void Main()
    {
        // ЗАДАЧА 1
        Console.WriteLine("Задача 1");

        Dictionary<string, int> values = new Dictionary<string, int>
        {
            { "value1", 1 },
            { "value2", 2 },
            { "value3", 3 }
        };

        Console.Write("Введите переменную: ");
        string key = Console.ReadLine();
        try
        {
            Console.WriteLine($"Переменной {key} соответсвует значение {values[key]} в словаре");
        }

        catch (Exception ex)
        { Console.WriteLine(ex.Message); }
        Console.WriteLine("Hello, world");

        // ЗАДАЧА 2

        Console.WriteLine("Задача 2");

        Console.Write("Введите делимое: ");
        int delimoe = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите частное: ");
        int chastnoe = Convert.ToInt32(Console.ReadLine());

        try
        {
            Console.WriteLine(delimoe / chastnoe);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Hello, world");

        // ЗАДАЧА 3


        // Не совсем понял, что от меня требуют

    }
}
