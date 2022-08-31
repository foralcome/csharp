Console.WriteLine("Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

int[,,] FillArray3dRandom(int countRows = 3, int minRandomValue = 1, int maxRandomValue = 100, bool isUnique = false)
{
    if (countRows <= 0)
    {
        throw new ArgumentException("Размерность массива должна быть больше 0!");
    }
    int[,,] array = new int[countRows, countRows, countRows];
    var currentValue = 0;

    List<int> values = new List<int>();

    for (int x = 0; x < countRows; x++)
    {
        for (int y = 0; y < countRows; y++)
        {
            for (int z = 0; z < countRows; z++)
            {
                currentValue = new Random().Next(minRandomValue, maxRandomValue);
                while(isUnique)
                {
                    if(values.IndexOf(currentValue)==-1)
                    {
                        break;
                    }
                    currentValue = new Random().Next(minRandomValue, maxRandomValue);
                }
                
                array[x, y, z] = currentValue;
                values.Add(currentValue);
            }
        }
    }
    return array;
}
void PrintArray3d(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                Console.Write($"{array[x, y, z]} ({x}, {y}, {z})");
                Console.WriteLine();
            }
        }
    }
}

Console.Write("Укажите размерность массива: ");
int size = int.Parse(Console.ReadLine());
if (size <= 0)
{
    Console.WriteLine("Размерность массива должна быть больше 0!");
}
else
{
    Console.WriteLine($"Создание 3D массива [{size},{size},{size}]");
    int[,,] array3d = FillArray3dRandom(size, 10, 99, true);
    PrintArray3d(array3d);
}