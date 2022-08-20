Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

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
int GetSumByNotEvenIndex(int []array)
{
    int sum = 0;
    int size = array.Length;
    for (int i = 1; i < size; i=i+2)
    {
        sum += array[i];
    }
    return sum;
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

    int sum = GetSumByNotEvenIndex(array);
    Console.WriteLine($"Сумма чисел с нечётными позициями равна {sum}");
}