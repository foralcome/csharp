Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

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
}
void PrintRangeRecursion(int curentNumber, int stopNumber = 10)
{
    if (curentNumber > stopNumber)
    {
        throw new ArgumentException($"Текущее число {curentNumber} должно быть меньше {stopNumber}!");
    }
    if (curentNumber == stopNumber)
    {
        Console.WriteLine($"{curentNumber}");
    }
    else
    {
        Console.Write($"{curentNumber},");
        PrintRangeRecursion(curentNumber + 1, stopNumber);
    }
}
int GetSumRange(int numberStart, int numberStop)
{
    if (numberStart > numberStop)
    {
        throw new ArgumentException($"Число {numberStart} должно быть меньше {numberStop}!");
    }

    int sum = 0;
    for (int i = numberStart; i <= numberStop; i++)
    {
        sum += i;
    }

    return sum;
}
int GetSumRangeRecursion(int curentNumber, int stopNumber = 10)
{
    if (curentNumber > stopNumber)
    {
        throw new ArgumentException($"Текущее число {curentNumber} должно быть меньше {stopNumber}!");
    }
    if (curentNumber == stopNumber)
    {
        return curentNumber;
    }
    else
    {
        return (curentNumber + GetSumRangeRecursion(curentNumber + 1, stopNumber));
    }
}

try
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine($"Рекурсивный вывод диапазона [{m},{n}]");
    PrintRangeRecursion(m, n);    
    int sumRange = GetSumRange(m, n);
    Console.WriteLine($"Сумма чисел (обычный способ): {sumRange}");
    int sumRangeRecursion = GetSumRangeRecursion(m, n);
    Console.WriteLine($"Сумма чисел (рекурсивный способ) {sumRangeRecursion}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
