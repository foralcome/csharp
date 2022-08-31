Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

int GetSumRow(int[,] array, int indexRow=0)
{
    if (indexRow < 0 || indexRow >=array.GetLength(0) )
    {
        throw new ArgumentException($"Индекс строки должен быть в пределах от 0 до {(array.GetLength(0)-1)} включительно!");
    }
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[indexRow,j];
    }
    return sumRow;
}
int GetRowWithMinSum(int[,] array)
{
    int indexRowMinSum = 0;
    int minSumRow = GetSumRow(array,0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int currentSumRow = GetSumRow(array,i);
        if( currentSumRow < minSumRow )
        {
            indexRowMinSum = i;
            minSumRow = currentSumRow;
        }
    }
    return indexRowMinSum;
}
int GetSumColumn(int[,] array, int indexColumn=0)
{
    if (indexColumn < 0 || indexColumn >=array.GetLength(1) )
    {
        throw new ArgumentException($"Индекс столбца должен быть в пределах от 0 до {(array.GetLength(1)-1)} включительно!");
    }
    int sumColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumColumn += array[i, indexColumn];
    }
    return sumColumn;
}
int GetColumnWithMinSum(int[,] array)
{
    int indexColumnMinSum = 0;
    int minSumColumn = GetSumColumn(array,0);
    for (int i = 1; i < array.GetLength(1); i++)
    {
        int currentSumColumn = GetSumColumn(array,i);
        if( currentSumColumn < minSumColumn )
        {
            indexColumnMinSum = i;
            minSumColumn = currentSumColumn;
        }
    }
    return indexColumnMinSum;
}
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
void PrintArray2dWithSum(int[,] array)
{
    Console.Write(" ".PadLeft(5));
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"{i}".PadLeft(5));
    }
    Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
    Console.Write("sum".PadLeft(5));
    Console.ResetColor(); // сбрасываем в стандартный
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{i}".PadLeft(5));
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}".PadLeft(5));
        }
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        int sumRow = GetSumRow(array, i);
        Console.Write($"{sumRow}".PadLeft(5));
        Console.ResetColor(); // сбрасываем в стандартный
        Console.WriteLine("");
    }
    
    Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
    Console.Write("sum".PadLeft(5));
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int sumColumn = GetSumColumn(array, j);
        Console.Write($"{sumColumn}".PadLeft(5));
    }
    Console.ResetColor(); // сбрасываем в стандартный
    Console.WriteLine();
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
    PrintArray2dWithSum(array2d);

    try
    {
        int indexRowWithMinSum = GetRowWithMinSum(array2d);
        Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {indexRowWithMinSum}");

        int indexColumnWithMinSum = GetColumnWithMinSum(array2d);
        Console.WriteLine($"Индекс столбца с наименьшей суммой элементов: {indexColumnWithMinSum}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}