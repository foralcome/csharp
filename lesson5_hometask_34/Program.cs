Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");

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
int GetCountEvenNumbers(int []array)
{
    int count = 0;
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if( array[i] %2 == 0 )
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
    int []array = FillArray(size, 100, 999);
    PrintArray(array);

    int countEvenInArray = GetCountEvenNumbers(array);
    Console.WriteLine($"В массиве найдено {countEvenInArray} чётных чисел");
}