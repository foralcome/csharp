Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

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
double GetAvgInRowArray2d(int[,] array2d, int irow)
{
    if (irow < 0 || irow >= array2d.GetLength(0))
    {
        throw new IndexOutOfRangeException($"Номер строки должен быть в диапазоне от 0 до " + (array2d.GetLength(0) - 1) + " включительно!");
    }
    int sum = 0;
    for (int j = 0; j < array2d.GetLength(0); j++)
    {
        sum += array2d[irow, j];
    }
    double avg = (double)sum / array2d.GetLength(1);
    return avg;
}
double GetAvgInColumnArray2d(int[,] array2d, int icolumn)
{
    if (icolumn < 0 || icolumn >= array2d.GetLength(1))
    {
        throw new IndexOutOfRangeException($"Номер столбца должен быть в диапазоне от 0 до " + (array2d.GetLength(1) - 1) + " включительно!");
    }
    int sum = 0;
    for (int i = 0; i < array2d.GetLength(1); i++)
    {
        sum += array2d[i, icolumn];
    }
    double avg = (double)sum / array2d.GetLength(0);
    return avg;
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
    int[,] array2d = FillArray2dRandom(countRows, countColumns, 1, 9);
    PrintArray2d(array2d);

    try
    {
        Console.WriteLine();
        Console.WriteLine("РЕЖИМ: получение среднего арифметического строк");
        double avgRow = 0.0;
        for (int iRow = 0; iRow < array2d.GetLength(0); iRow++)
        {
            avgRow = GetAvgInRowArray2d(array2d, iRow);
            Console.WriteLine($"Ср.арифметическое строки {iRow}: {Math.Round(avgRow, 2)}");
        }
        Console.WriteLine();
        Console.WriteLine("РЕЖИМ: получение среднего арифметического столбца");
        double avgColumn = 0.0;
        for (int iColumn = 0; iColumn < array2d.GetLength(1); iColumn++)
        {
            avgColumn = GetAvgInColumnArray2d(array2d, iColumn);
            Console.WriteLine($"Ср.арифметическое столбца {iColumn}: {Math.Round(avgColumn, 2)}");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}