Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");

void PrintRange(int numberStart, int numberStop)
{
    if (numberStart > numberStop)
    {
        throw new ArgumentException($"Число {numberStart} должно быть меньше {numberStop}!");
    }

    for (int i = numberStart; i <= numberStop; i++)
    {
        if (i != numberStart)
        {
            Console.Write(",");
        }
        Console.Write($"{i}");
    }
    Console.WriteLine();
}
void PrintRangeRecursion(int curentNumber, int stopNumber = 1)
{
    if (curentNumber < stopNumber)
    {
        throw new ArgumentException($"Текущее число {curentNumber} должно быть больше или равно {stopNumber}!");
    }
    if (curentNumber == stopNumber)
    {
        Console.Write($"{curentNumber}");
    }
    else
    {
        PrintRangeRecursion(curentNumber - 1);
        Console.Write($",{curentNumber}");
    }
}

try
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Обычный вывод диапазона [{m},{n}]");
    PrintRange(m, n);
    Console.WriteLine($"Рекурсивный вывод диапазона [{m},{n}]");
    PrintRangeRecursion(n, m);
    Console.WriteLine();
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
