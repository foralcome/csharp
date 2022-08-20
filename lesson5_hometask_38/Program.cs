Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

int [] FillArray(int size=10, int minValue=1, int maxValue=100)
{
    int []array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue);
    }
    return array;
}
void PrintArray(int []array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if( i > 0 )
        {
            Console.Write(", ");
        }
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
int GetMinValue(int []array)
{
    int size = array.Length;
    int min = array[0];
    for (int i = 1; i < size; i++)
    {
        if( min > array[i] )
        {
            min = array[i];
        }
    }
    return min;
}
int GetMaxValue(int []array)
{
    int size = array.Length;
    int max = array[0];
    for (int i = 1; i < size; i++)
    {
        if( max<array[i] )
        {
            max = array[i];
        }
    }
    return max;
}
int [] GetMinMaxValue(int []array)
{
    int size = array.Length;
    int min = array[0];
    int max = array[0];
    for (int i = 1; i < size; i++)
    {
        if( min>array[i] )
        {
            min = array[i];
        }
        if( max<array[i] )
        {
            max = array[i];
        }
    }
    return new int[]{min,max};
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

if( size<=0 )
{
    Console.WriteLine("Размер массива должен быть больше 0!");
}
else
{
    int []array = FillArray(size);
    PrintArray(array);

    int min = GetMinValue(array);
    Console.WriteLine($"Минимальное значение {min}");

    int max = GetMaxValue(array);
    Console.WriteLine($"Максимальное значение {max}");

    int [] minmax = GetMinMaxValue(array);
    Console.WriteLine($"Минимальное значение {min} максимальное значение {max}");

    int dif = max - min;
    Console.WriteLine($"Разница минимального и минимального значений {dif}");
}