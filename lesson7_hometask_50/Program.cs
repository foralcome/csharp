Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает"
                + "значение этого элемента или же указание, что такого элемента нет.");

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
int GetValueInArray2dByIndex(int[,] array, int irow, int icolumn)
{
    if (irow < 0 || irow >= array.GetLength(0))
    {
        throw new IndexOutOfRangeException($"Номер строки искомого элемента должен быть диапазоне от 0 до " + array.GetLength(0) + " включительно!");
    }
    if (icolumn < 0 || icolumn >= array.GetLength(1))
    {
        throw new IndexOutOfRangeException($"Номер столбца искомого элемента должен быть диапазоне от 0 до " + array.GetLength(1) + " включительно!");
    }
    return array[irow, icolumn];
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

    while (true)
    {
        try
        {
            Console.WriteLine();
            Console.WriteLine("РЕЖИМ: получение занчения элемента 2d массива по индексу");
            Console.Write("Введите номер искомой строки: ");
            int findRow = int.Parse(Console.ReadLine());
            if (findRow < 0 || findRow >= array2d.GetLength(0))
            {
                throw new IndexOutOfRangeException($"Номер строки искомого элемента должен быть диапазоне от 0 до " + array2d.GetLength(0) + " включительно!");
            }
            Console.Write("Введите номер искомого столбца: ");
            int findColumn = int.Parse(Console.ReadLine());
            if (findColumn < 0 || findColumn >= array2d.GetLength(1))
            {
                throw new IndexOutOfRangeException($"Номер столбца искомого элемента должен быть диапазоне от 0 до " + array2d.GetLength(1) + " включительно!");
            }

            int findValue = GetValueInArray2dByIndex(array2d, findRow, findColumn);
            Console.WriteLine($"Искомое значение по индексу [{findRow},{findColumn}]: {findValue}");
        }
        catch( Exception ex)
        {
            Console.WriteLine($"Произошло исключение: {ex.Message}");
        }

        Console.WriteLine();
        Console.WriteLine("Введите 1 для нового поиска или 0 для выхода");
        int isContinue = int.Parse(Console.ReadLine());
        if (isContinue == 0)
        {
            break;
        }
    }
}