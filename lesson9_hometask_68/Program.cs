Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

int GetNumberAkkerman(int m, int n)
{
    if (m < 0 || n < 0)
    {
        throw new ArgumentException($"Числа m и n должны быть неотрицательными!");
    }
    if (m == 0)
    {
        return (n + 1);
    }
    if (n == 0 && m > 0)
    {
        return GetNumberAkkerman(m - 1, 1);
    }
    return GetNumberAkkerman(m - 1, GetNumberAkkerman(m, n - 1));
}

try
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    int numberAkkerman = GetNumberAkkerman(m, n);
    Console.WriteLine($"Результат Функции Аккермана: {numberAkkerman}");
}
catch (Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
