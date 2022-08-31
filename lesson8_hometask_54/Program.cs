Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

void SortArray2dByRows(int[,] array, bool isAscending=true)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {

                if ( (isAscending==false && array[i,j] < array[i,k]) || (isAscending==true && array[i,j] > array[i,k]) )
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                }
            }
        }
    }
}
void SortArray2dByColumns(int[,] array, bool isAscending=true)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0) - 1; i++)
        {
            for (int k = i + 1; k < array.GetLength(0); k++)
            {
                if ( (isAscending==false && array[i,j] < array[k,i]) || (isAscending==true && array[i,j] > array[k,i]) )
                {
                    temp = array[i,j];
                    array[i,j] = array[k,i];
                    array[k,i] = temp;
                }
            }
        }
    }
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
        Console.WriteLine("Сортировка элементов строки по убыванию");
        SortArray2dByRows(array2d, false);
        PrintArray2d(array2d);

        Console.WriteLine();
        Console.WriteLine("Сортировка элементов столбца по убыванию");
        SortArray2dByColumns(array2d, false);
        PrintArray2d(array2d);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}