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

try
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Натуральные числа: ");
    PrintRange(m, n);
    Console.WriteLine();
    int sumRange = GetSumRange(m, n);
    Console.WriteLine($"Сумма чисел: {sumRange}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
