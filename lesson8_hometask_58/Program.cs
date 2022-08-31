Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

int[,] FillMatrixRandom(int countRows = 3, int countColumns = 3, int minRandomValue = 1, int maxRandomValue = 100)
{
    if (countRows <= 0 || countColumns <= 0)
    {
        throw new ArgumentException("Размерность матрицы должна быть больше 0!");
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
void PrintMatrix(int[,] array, int countSpacePrint = 1)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        Console.ForegroundColor = ConsoleColor.Green;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}".PadLeft(countSpacePrint));
        }
        Console.ResetColor();
        Console.WriteLine("|");
    }
    Console.WriteLine();
}
int[,] GetMatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException("Количество столбцов матрицы 1 должно совпадать с количеством строк матрицы 2. Произведение матриц невозможно!");
    }

    int[,] matrixMultiplication = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrixMultiplication.GetLength(0); i++)
    {
        for (int j = 0; j < matrixMultiplication.GetLength(1); j++)
        {
            matrixMultiplication[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrixMultiplication[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return matrixMultiplication;
}

int minRandomValue = 1;
int maxRandomValue = 9;
int countSpacePrint = 2;

while (true)
{
    Console.Clear();
    try
    {
        Console.Write("Укажите количество строк матрицы A: ");
        int countRowsMatrixA = int.Parse(Console.ReadLine());
        if (countRowsMatrixA < 0)
        {
            throw new ArgumentException($"Размерность матрица должна быть положительной!");
        }
        Console.Write("Укажите количество столбцов матрицы A: ");
        int countColumnsMatrixA = int.Parse(Console.ReadLine());
        if (countColumnsMatrixA < 0)
        {
            throw new ArgumentException($"Размерность матрица должна быть положительной!");
        }

        Console.WriteLine($"Количество строк матрицы B: {countColumnsMatrixA}");
        int countRowsMatrixB = countColumnsMatrixA;
        Console.Write("Укажите количество столбцов матрицы B: ");
        int countColumnsMatrixB = int.Parse(Console.ReadLine());
        if (countColumnsMatrixB < 0)
        {
            throw new ArgumentException($"Размерность матрица должна быть положительной!");
        }

        Console.Clear();
        Console.WriteLine($"Матрица A размером {countRowsMatrixA} x {countColumnsMatrixA}: ");
        int[,] matrixA = FillMatrixRandom(countRowsMatrixA, countColumnsMatrixA, minRandomValue, maxRandomValue);
        PrintMatrix(matrixA, countSpacePrint);
        Console.WriteLine($"Матрица B размером {countRowsMatrixB} x {countColumnsMatrixB}: ");
        int[,] matrixB = FillMatrixRandom(countRowsMatrixB, countColumnsMatrixB, minRandomValue, maxRandomValue);
        PrintMatrix(matrixB, countSpacePrint);

        int[,] matrixC = new int[countRowsMatrixA, countColumnsMatrixB];
        Console.WriteLine($"Произведение матриц C[{countRowsMatrixA},{countColumnsMatrixB}] = A[{countRowsMatrixA},{countColumnsMatrixA}] * B[{countRowsMatrixB},{countColumnsMatrixB}]:");
        matrixC = GetMatrixMultiplication(matrixA, matrixB);
        PrintMatrix(matrixC, countSpacePrint * 2);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Произошло исключение: {ex.Message}");
    }

    Console.WriteLine();
    Console.WriteLine("Введите 1 для повторного запуска или 0 для выхода");
    int isContinue = int.Parse(Console.ReadLine());
    if (isContinue == 0)
    {
        break;
    }
}