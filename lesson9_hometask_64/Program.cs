Console.WriteLine("Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.");

void PrintRange(int numberStart, int numberStop)
{
    if(numberStart > numberStop){
        throw new ArgumentException($"Число {numberStart} должно быть меньше {numberStop}!");
    }

    for (int i = numberStart; i <= numberStop; i++)
    {
        if(i!=numberStart)
        {
            Console.Write(",");
        }
        Console.Write($"{i}");
    }
    Console.WriteLine();
}

try
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());

    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    PrintRange(m,n);
}
catch(Exception ex)
{
    Console.WriteLine($"Произошло исключение: {ex.Message}");
}
