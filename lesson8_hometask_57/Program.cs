using System.Collections.Generic;

Console.WriteLine("Задача 57. Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.");

int[,] FillArray2dRandom(int countRows = 3, int countColumns = 3, int minRandomValue = 1, int maxRandomValue = 100)
{
    if (countRows <= 0 || countColumns <= 0)
    {
        throw new ArgumentException("Размерность массива должна быть больше 0!");
    }
    int[,] array = new int[countRows, countColumns];
    for (int i = 0; i < countRows; i++)
    {
        for (int j = 0; j < countColumns; j++)
        {
            array[i, j] = new Random().Next(minRandomValue, maxRandomValue);
        }
    }
    return array;
}
void PrintArray2d(int[,] array)
{
    Console.Write(" ".PadLeft(5));
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i}".PadLeft(5));
    }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}".PadLeft(5));
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}".PadLeft(5));
        }
        Console.WriteLine("");
    }
    Console.WriteLine();
}
Dictionary<int, int> GetDictionaryCountRepeatValuesInArray2d(int[,] array2d)
{
    Dictionary<int, int> d = new Dictionary<int, int>();

    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            if (d.ContainsKey(array2d[i, j]))
            {
                d[array2d[i, j]]++;
            }
            else
            {
                d.Add(array2d[i, j], 1);
            }
        }
    }

    return d;
}

void PrintDictionary(SortedDictionary<int, int> d)
{
    int i = 1;
    foreach (int number in d.Keys)
    {
        Console.WriteLine("{0}) {1}  => {2}", i, number, d[number]);
        i++;
    }
}

Console.Write("Укажите количество строк: ");
int countRows = int.Parse(Console.ReadLine());
Console.Write("Укажите количество столбцов: ");
int countColumns = int.Parse(Console.ReadLine());

if (countRows <= 0 || countColumns <= 0)
{
    Console.WriteLine("Размерность массива должна быть больше 0!");
}
else
{
    int[,] array2d = FillArray2dRandom(countRows, countColumns, 10, 99);
    PrintArray2d(array2d);

    try
    {
        Dictionary<int, int> Dict = GetDictionaryCountRepeatValuesInArray2d(array2d);
        //PrintDictionary(Dict);

        Console.WriteLine("Словарь повторяющихся значений массива (число => повторений):");
        var sortedDict = new SortedDictionary<int, int>(Dict);
        PrintDictionary(sortedDict);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}