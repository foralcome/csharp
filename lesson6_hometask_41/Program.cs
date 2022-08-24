Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

int [] FillArrayRundom(int size=10, int minValue=1, int maxValue=100)
{
    int []array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue,maxValue);
    }
    return array;
}
int [] FillArrayManually(int size=10)
{
    int []array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите значение массива [{i+1}]: ");
        array[i] = int.Parse(Console.ReadLine());
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
int GetCountValueMoreThan(int []array, int valueMoreThen=0)
{
    int count = 0;
    int size = array.Length;
    for (int i = 1; i < size; i++)
    {
        if( array[i] > valueMoreThen )
        {
            count++;
        }
    }
    return count;
}
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

if( size<=0 )
{
    Console.WriteLine("Размер массива должен быть больше 0!");
}
else
{
    int []array = FillArrayManually(size);
    PrintArray(array);

    int valueMoreThen = 0;
    int countMoreThen0 = GetCountValueMoreThan(array, valueMoreThen);
    Console.WriteLine($"Количество значений (>{valueMoreThen}): {countMoreThen0}");
}