Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");

int [] FillArray(int size=10)
{
    int []array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,99);
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
}
