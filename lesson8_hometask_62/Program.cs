Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

int[,] FillArray2dSpiral(int size = 4, int minRandomValue = 1, int maxRandomValue = 100)
{
    if (size <= 0)
    {
        throw new ArgumentException("Размерность матрицы должна быть больше 0!");
    }
    int[,] array = new int[size, size];

    int currentIndexRow = 0;
    int indexMinRow = 0;
    int indexMaxRow = array.GetLength(0) - 1;
    int directionByRow = 1;    
    
    int currentIndexColumn = 0;
    int indexMinColumn = 0;
    int indexMaxColumn = array.GetLength(1) - 1;
    int directionByColumn = 1;

    int maxNumber = size * size;
    int curentNumber = 1;
    while(curentNumber <= maxNumber)
    {
        while( currentIndexColumn>=indexMinColumn && currentIndexColumn<=indexMaxColumn )
        {
            array[currentIndexRow,currentIndexColumn] = curentNumber;
            curentNumber++;
            currentIndexColumn += directionByColumn;
        }
        if( directionByColumn<0 )
        {
            indexMinRow++;
            indexMaxColumn--;
        }
        directionByColumn *= -1;
        currentIndexColumn += directionByColumn;
        currentIndexRow += directionByRow;

        while( currentIndexRow>=indexMinRow && currentIndexRow<=indexMaxRow )
        {
            array[currentIndexRow,currentIndexColumn] = curentNumber;
            curentNumber++;
            currentIndexRow += directionByRow;
        }
        if( directionByRow<0 )
        {
            indexMinColumn++;
            indexMaxRow--;
        }
        directionByRow *= -1;
        currentIndexRow += directionByRow;
        currentIndexColumn += directionByColumn;
    }

    return array;
}
void PrintArray2d(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}".PadLeft(5));
        }
        Console.WriteLine("");
    }
}

Console.Write("Укажите размер спиральной матрицы: ");
int size = int.Parse(Console.ReadLine());
if (size <= 0)
{
    Console.WriteLine("Размерность матрицы должна быть больше 0!");
}
else
{
    try
    {
        Console.WriteLine("Ваша спиральная матрица:");
        int[,] array2d = FillArray2dSpiral(size, 10, 99);
        PrintArray2d(array2d);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}