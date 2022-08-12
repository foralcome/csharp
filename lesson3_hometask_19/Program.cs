Console.WriteLine("Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите 5-ти значное число: ");
string numStr = Console.ReadLine();
int num = int.Parse(numStr);
int numLen = numStr.Length;

if (numLen != 5)
{
    Console.WriteLine("Нужно 5-ти значное число!");
}
else
{
    int d = num;
    int numCompare = 0;
    int index = 0;
    while (index < numLen)
    {
        numCompare = numCompare * 10 + d % 10;
        d /= 10;
        index++;
    }

    if (num == numCompare)
    {
        Console.WriteLine("Число является полиндромом!");
    }
    else
    {
        Console.WriteLine("Число НЕ является полиндромом!");
    }
}