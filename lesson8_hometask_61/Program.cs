Console.WriteLine("Задача 61. Вывести первые N строк треугольника Паскаля.");

int[,] FillArray2dPaskalTriangle(int size = 4)
{
    if (size <= 0)
    {
        throw new ArgumentException("Размер треугольника Паскаля должен быть больше 0!");
    }
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        array[i, 0] = 1;
        array[i, i] = 1;
    }

    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            array[i, j] = array[i - 1, j - 1] + array[i - 1, j];
        }
    }
    return array;
}
void PrintArray2dPaskalTriangle(int[,] array)
{

    int posTop = Console.CursorTop;

    int cellWidth = 3;
    int row = array.GetLength(0);
    int col = cellWidth * row;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < row; j++)
        {
            Console.SetCursorPosition(col, i + 1 + posTop);
            if (array[i, j] != 0)
            {
                Console.Write($"{array[i, j],4}");

            }
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine("");
    }
    Console.WriteLine();
}

Console.Write("Укажите количество строк: ");
int countRows = int.Parse(Console.ReadLine());

if (countRows <= 0)
{
    Console.WriteLine("Количество строк должно быть больше 0!");
}
else
{
    int[,] array2d = FillArray2dPaskalTriangle(countRows);
    PrintArray2dPaskalTriangle(array2d);

    try
    {

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }
}