Console.WriteLine("Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");

Console.Write("Введите 3-х значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num >= 1000)
{
    Console.WriteLine("Это не 3-х значное число! Число должно быть в диапазоне от 100 до 999 включительно");
}
else
{
    int num2 = (num % 100 - num % 10) / 10; 
    Console.WriteLine(num2);
}

